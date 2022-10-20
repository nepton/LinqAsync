namespace LinqAsync.Pages;

/// <summary>
/// Pageable query filter
/// </summary>
public class PageFilter
{
    /// <summary>
    /// Number of records to skip before querying (default 0)
    /// </summary>
    public int Skip { get; set; } = 0;

    /// <summary>
    /// Number of records returned in this query (default: 20)
    /// </summary>
    public int Take { get; set; } = 20;
}