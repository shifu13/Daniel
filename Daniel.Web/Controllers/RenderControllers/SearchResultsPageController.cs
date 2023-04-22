using Ecreo.Essentials.Frontend.Pagination;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Our.Umbraco.FullTextSearch.Interfaces;
using Our.Umbraco.FullTextSearch.Models;
using Our.Umbraco.FullTextSearch.Options;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using ContentModels = Ecreo.Essentials.UmbracoTemplate.Models.ContentModels;

namespace Ecreo.Essentials.UmbracoTemplate.Controllers.RenderControllers;

public class SearchResultsPageController : RenderController
{
    private readonly ISearchService _searchService;
    private readonly FullTextSearchOptions _options;

    public SearchResultsPageController(
        ISearchService searchService,
        IOptions<FullTextSearchOptions> options,
        ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor) : base(logger, compositeViewEngine, umbracoContextAccessor)
    {
        _searchService = searchService;
        _options = options.Value;
    }
    public override IActionResult Index()
    {
        var searchModel = CurrentPage as ContentModels.SearchResultsPage;

        if (searchModel != null && CurrentPage != null)
        {
            searchModel.FullTextSearchResult = null;

            if (Request.Query.ContainsKey("q"))
            {
                var currentPage = PaginationHelper.GetCurrentPageFromQueryString(Request, totalPages: int.MaxValue);

                var search = new Search(Request.Query["q"].ToString())
                    .EnableHighlighting()
                    .AddTitleProperty("metaTitle")
                    .AddTitleProperty("nodeName")
                    .AddSummaryProperty("metaDescription")
                    .AddSummaryProperty(_options.FullTextContentField)
                    .SetSummaryLength(160)
                    .SetPageLength(10)
                    .SetCulture(CurrentPage.GetCultureFromDomains()?.ToLower());

                searchModel.FullTextSearchResult = _searchService.Search(search, currentPage);
            }
        }

        return CurrentTemplate(searchModel);
    }
}
