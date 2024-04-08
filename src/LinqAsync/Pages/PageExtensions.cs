namespace LinqAsync.Pages;

/// <summary>
/// The extensions for Pageable query result
/// </summary>
public static class PageExtensions
{
    /// <summary>
    /// Convert the query result to Pageable query result
    /// </summary>
    /// <typeparam name="TSource">The type of result</typeparam>
    /// <param name="source">the result query expression</param>
    /// <param name="skip">Indicate how many records to skip before returning results</param>
    /// <param name="take">Indicate how many records to return</param>
    /// <param name="cancel">Cancellation token</param>
    /// <returns>Return paged collection</returns>
    private static async Task<Page<TSource>> ToPageCoreAsync<TSource>(
        IQueryable<TSource> source,
        int                 skip,
        int                 take,
        CancellationToken   cancel)
    {
        if (skip < 0)
            throw new ArgumentOutOfRangeException(nameof(skip));

        if (take <= 0)
            throw new ArgumentOutOfRangeException(nameof(take));

        var count = await source.CountAsync(cancel);
        var data  = Array.Empty<TSource>();
        if (count > 0)
            data = await source.Skip(skip).Take(take).ToArrayAsync(cancel);

        return new Page<TSource>(skip, take, count, data);
    }

    /// <summary>
    /// Convert the query result to Pageable query result
    /// </summary>
    /// <typeparam name="TSource">The type of result</typeparam>
    /// <param name="source">the result query expression</param>
    /// <param name="skip">Indicate how many records to skip before returning results</param>
    /// <param name="take">Indicate how many records to return</param>
    /// <param name="cancel">Cancellation token</param>
    /// <returns>Return paged collection</returns>
    public static Task<Page<TSource>> ToPageAsync<TSource>(
        this IQueryable<TSource> source,
        int                      skip,
        int                      take,
        CancellationToken        cancel)
    {
        return ToPageCoreAsync(source, skip, take, cancel);
    }

    /// <summary>
    /// Convert the query result to Pageable query result
    /// </summary>
    /// <typeparam name="TSource">The type of result</typeparam>
    /// <param name="source">the result query expression</param>
    /// <param name="pageFilter">the query filter about paged</param>
    /// <param name="cancel">Cancellation token</param>
    /// <returns>Return paged collection</returns>
    public static Task<Page<TSource>> ToPageAsync<TSource>(this IQueryable<TSource> source, PageFilter pageFilter, CancellationToken cancel)
    {
        if (pageFilter == null)
            throw new ArgumentNullException(nameof(pageFilter));

        return ToPageCoreAsync(source, pageFilter.Skip, pageFilter.Take, cancel);
    }

    /// <summary>
    /// Convert the query result to Pageable query result
    /// </summary>
    /// <typeparam name="TSource">The type of result</typeparam>
    /// <param name="source">the result query expression</param>
    /// <param name="skip">Indicate how many records to skip before returning results</param>
    /// <param name="take">Indicate how many records to return</param>
    /// <returns>Return paged collection</returns>
    private static Page<TSource> ToPageCore<TSource>(
        IQueryable<TSource> source,
        int                 skip,
        int                 take)
    {
        if (skip < 0)
            throw new ArgumentOutOfRangeException(nameof(skip));

        if (take <= 0)
            throw new ArgumentOutOfRangeException(nameof(take));

        var count = source.Count();
        var data  = Array.Empty<TSource>();
        if (count > 0)
            data = source.Skip(skip).Take(take).ToArray();

        return new Page<TSource>(skip, take, count, data);
    }

    /// <summary>
    /// Convert the query result to Pageable query result
    /// </summary>
    /// <typeparam name="TSource">The type of result</typeparam>
    /// <param name="source">the result query expression</param>
    /// <param name="skip">Indicate how many records to skip before returning results</param>
    /// <param name="take">Indicate how many records to return</param>
    /// <returns>Return paged collection</returns>
    public static Page<TSource> ToPage<TSource>(
        this IQueryable<TSource> source,
        int                      skip,
        int                      take
    )
    {
        return ToPageCore(source, skip, take);
    }

    /// <summary>
    /// Convert the query result to Pageable query result
    /// </summary>
    /// <typeparam name="TSource">The type of result</typeparam>
    /// <param name="source">the result query expression</param>
    /// <param name="pageQueryFilter">the query filter about paged</param>
    /// <returns>Return paged collection</returns>
    public static Page<TSource> ToPage<TSource>(this IQueryable<TSource> source, PageFilter pageQueryFilter)
    {
        if (pageQueryFilter == null)
            throw new ArgumentNullException(nameof(pageQueryFilter));

        return ToPageCore(source, pageQueryFilter.Skip, pageQueryFilter.Take);
    }

    /// <summary>
    /// ForEach the page
    /// </summary>
    /// <param name="page"></param>
    /// <param name="action"></param>
    /// <typeparam name="T"></typeparam>
    public static void ForEach<T>(this Page<T> page, Action<T> action)
    {
        foreach (var item in page.Items)
            action(item);
    }

    /// <summary>
    /// ForEach the page
    /// </summary>
    /// <param name="page"></param>
    /// <param name="action">The action, first parameter is the item, second parameter is the skip, and third parameter is the index</param>
    /// <typeparam name="T"></typeparam>
    public static void ForEach<T>(this Page<T> page, Action<T, int, int> action)
    {
        for (var i = 0; i < page.Items.Length; i++)
            action(page.Items[i], page.Skip, i);
    }

    /// <summary>
    /// ForEach the page
    /// </summary>
    /// <param name="page"></param>
    /// <param name="action"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static Task ForEachAsync<T>(this Page<T> page, Func<T, Task> action)
    {
        return Task.WhenAll(page.Items.Select(action));
    }

    /// <summary>
    /// ForEach the page
    /// </summary>
    /// <param name="page"></param>
    /// <param name="action">The action, first parameter is the item, second parameter is the skip, and third parameter is the index</param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static Task ForEachAsync<T>(this Page<T> page, Func<T, int, int, Task> action)
    {
        return Task.WhenAll(page.Items.Select((item, index) => action(item, page.Skip, index)));
    }
}
