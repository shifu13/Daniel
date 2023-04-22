using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Our.Umbraco.FullTextSearch.Options;
using System;
using System.Collections.Generic;
using ContentModels = Ecreo.Essentials.UmbracoTemplate.Models.ContentModels;

namespace Ecreo.Essentials.UmbracoTemplate;

public class Startup
{
    private readonly IWebHostEnvironment _env;
    private readonly IConfiguration _config;

    /// <summary>
    /// Initializes a new instance of the <see cref="Startup" /> class.
    /// </summary>
    /// <param name="webHostEnvironment">The web hosting environment.</param>
    /// <param name="config">The configuration.</param>
    /// <remarks>
    /// Only a few services are possible to be injected here https://github.com/dotnet/aspnetcore/issues/9337
    /// </remarks>
    public Startup(IWebHostEnvironment webHostEnvironment, IConfiguration config)
    {
        _env = webHostEnvironment ?? throw new ArgumentNullException(nameof(webHostEnvironment));
        _config = config ?? throw new ArgumentNullException(nameof(config));
    }

    /// <summary>
    /// Configures the services.
    /// </summary>
    /// <param name="services">The services.</param>
    /// <remarks>
    /// This method gets called by the runtime. Use this method to add services to the container.
    /// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    /// </remarks>
    public void ConfigureServices(IServiceCollection services)
    {
        // The following line enables Application Insights telemetry collection.
        services.AddApplicationInsightsTelemetry();

        #region FullTextSearch config
        services.Configure<FullTextSearchOptions>(o =>
            {
                o.DefaultTitleField = "metaTitle";
                o.DisallowedPropertyAliases = new List<string> { "umbracoSitemapHide" };
                o.DisallowedContentTypeAliases = new List<string> { ContentModels.SearchResultsPage.ModelTypeAlias };
                o.XPathsToRemove = new List<string> { "//script", "//head" };
            });
        #endregion

        #region Umbraco config
        var umbraco = services
            .AddUmbraco(_env, _config)
            .AddBackOffice()
            .AddWebsite()
            .AddComposers();

        // configure azure blob storage : https://github.com/umbraco/Umbraco.StorageProviders
        /*
        umbraco
            .AddAzureBlobMediaFileSystem(options =>
            {
                options.ConnectionString = "";
                options.ContainerName = "";
            })
            .AddCdnMediaUrlProvider(options =>
            {
                options.Url = new Uri("https://my-cdn.example.com/");
            });
        */

        // build
        umbraco
            .Build();
        #endregion

    }

    /// <summary>
    /// Configures the application.
    /// </summary>
    /// <param name="app">The application builder.</param>
    /// <param name="env">The web hosting environment.</param>
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseHttpsRedirection();

        app.UseResponseCompression();

        app.UseUmbraco()
            .WithMiddleware(u =>
            {
                u.UseBackOffice();
                u.UseWebsite();
            })
            .WithEndpoints(u =>
            {
                u.UseInstallerEndpoints();
                u.UseBackOfficeEndpoints();
                u.UseWebsiteEndpoints();
            });
    }
}
