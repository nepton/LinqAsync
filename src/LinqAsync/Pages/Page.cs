namespace LinqAsync.Pages;

/// <summary>
/// The paged collection.
/// </summary>
/// <typeparam name="TSource"></typeparam>
public class Page<TSource>
{
    /// <summary>
    /// ctor
    /// </summary>
    /// <param name="skip">How many records to skip</param>
    /// <param name="take">How many records to take</param>
    /// <param name="total"></param>
    /// <param name="items">The records</param>
    public Page(int skip, int take, int total, TSource[] items)
    {
        if (items == null)
            throw new ArgumentNullException(nameof(items));
        if (skip < 0)
            throw new ArgumentOutOfRangeException(nameof(skip));
        if (take < 0)
            throw new ArgumentOutOfRangeException(nameof(take));
        if (total < 0)
            throw new ArgumentOutOfRangeException(nameof(total));

        Skip  = skip;
        Take  = take;
        Total = total;
        Items = items;
    }

    /// <summary>
    /// How many items are skipped in the current page
    /// </summary>
    public int Skip { get; }

    /// <summary>
    /// How many items are taken from the total number of items
    /// </summary>
    public int Take { get; }

    /// <summary>
    /// How many items are in the full collection.
    /// </summary>
    public int Total { get; }

    /// <summary>
    /// The records
    /// </summary>
    public TSource[] Items { get; }

    /// <summary>
    /// The empty page collection
    /// </summary>
    /// <returns></returns>
    public static Page<TSource> Empty()
    {
        return new Page<TSource>(0, 0, 0, Array.Empty<TSource>());
    }
};
