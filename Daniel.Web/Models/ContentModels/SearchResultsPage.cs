using Our.Umbraco.FullTextSearch.Interfaces;

namespace Ecreo.Essentials.UmbracoTemplate.Models.ContentModels;

public partial class SearchResultsPage
{
    public IFullTextSearchResult? FullTextSearchResult { get; set; }
}
