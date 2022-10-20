using System.Linq.Expressions;
using LinqAsync;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

// ReSharper disable InvokeAsExtensionMethod

namespace Doulex.EntityFrameworkCore.Extensions
{
    /// <summary>
    /// Entity framework core 版异步查询扩展接口
    /// </summary>
    public class EntityFrameworkCoreAsyncQueryableMethodsProvider : IAsyncQueryableMethodsProvider
    {
        /// <summary>
        /// Asynchronously determines whether a sequence contains any elements.
        /// </summary>
        public Task<bool> AnyAsync<TSource>(
            IQueryable<TSource> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AnyAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously determines whether any element of a sequence satisfies a condition.
        /// </summary>
        public Task<bool> AnyAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, bool>> predicate,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AnyAsync(source, predicate, cancel);
        }

        /// <summary>
        /// Asynchronously determines whether all the elements of a sequence satisfy a condition.
        /// </summary>
        public Task<bool> AllAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, bool>> predicate,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AllAsync(source, predicate, cancel);
        }

        /// <summary>
        /// Asynchronously returns the number of elements in a sequence.
        /// </summary>
        public Task<int> CountAsync<TSource>(
            IQueryable<TSource> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.CountAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously returns the number of elements in a sequence that satisfy a condition.
        /// </summary>
        public Task<int> CountAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, bool>> predicate,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.CountAsync(source, predicate, cancel);
        }

        /// <summary>
        /// Asynchronously returns an <see cref="T:System.Int64" /> that represents the total number of elements in a sequence.
        /// </summary>
        public Task<long> LongCountAsync<TSource>(
            IQueryable<TSource> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.LongCountAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously returns an <see cref="T:System.Int64" /> that represents the number of elements in a sequence that satisfy a condition.
        /// </summary>
        public Task<long> LongCountAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, bool>> predicate,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.LongCountAsync(source, predicate, cancel);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence.
        /// </summary>
        public Task<TSource> FirstAsync<TSource>(
            IQueryable<TSource> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.FirstAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence that satisfies a specified condition.
        /// </summary>
        public Task<TSource> FirstAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, bool>> predicate,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.FirstAsync(source, predicate, cancel);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence, or a default value if the sequence contains no elements.
        /// </summary>
        public Task<TSource?> FirstOrDefaultAsync<TSource>(
            IQueryable<TSource> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.FirstOrDefaultAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously returns the first element of a sequence that satisfies a specified condition or a default value if no such element is found.
        /// </summary>
        public Task<TSource?> FirstOrDefaultAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, bool>> predicate,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.FirstOrDefaultAsync(source, predicate, cancel);
        }

        /// <summary>
        /// Asynchronously returns the last element of a sequence.
        /// </summary>
        public Task<TSource> LastAsync<TSource>(
            IQueryable<TSource> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.LastAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously returns the last element of a sequence that satisfies a specified condition.
        /// </summary>
        public Task<TSource> LastAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, bool>> predicate,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.LastAsync(source, predicate, cancel);
        }

        /// <summary>
        /// Asynchronously returns the last element of a sequence, or a default value if the sequence contains no elements.
        /// </summary>
        public Task<TSource?> LastOrDefaultAsync<TSource>(
            IQueryable<TSource> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.LastOrDefaultAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously returns the last element of a sequence that satisfies a specified condition or a default value if no such element is found.
        /// </summary>
        public Task<TSource?> LastOrDefaultAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, bool>> predicate,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.LastOrDefaultAsync(source, predicate, cancel);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence.
        /// </summary>
        public Task<TSource> SingleAsync<TSource>(
            IQueryable<TSource> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SingleAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence that satisfies a specified condition, and throws an exception if more than one such element exists.
        /// </summary>
        public Task<TSource> SingleAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, bool>> predicate,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SingleAsync(source, predicate, cancel);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence, or a default value if the sequence is empty; this method throws an exception if there is more than one element in the sequence.
        /// </summary>
        public Task<TSource?> SingleOrDefaultAsync<TSource>(
            IQueryable<TSource> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SingleOrDefaultAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously returns the only element of a sequence that satisfies a specified condition or a default value if no such element exists; this method throws an exception if more than one element satisfies the condition.
        /// </summary>
        public Task<TSource?> SingleOrDefaultAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, bool>> predicate,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SingleOrDefaultAsync(source, predicate, cancel);
        }

        /// <summary>
        /// Asynchronously returns the minimum value of a sequence.
        /// </summary>
        public Task<TSource?> MinAsync<TSource>(
            IQueryable<TSource> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.MinAsync(source, cancel)!;
        }

        /// <summary>
        /// Asynchronously invokes a projection function on each element of a sequence and returns the minimum resulting value.
        /// </summary>
        public Task<TResult?> MinAsync<TSource, TResult>(
            IQueryable<TSource> source,
            Expression<Func<TSource, TResult>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.MinAsync(source, selector, cancel)!;
        }

        /// <summary>
        /// Asynchronously returns the maximum value of a sequence.
        /// </summary>
        public Task<TSource?> MaxAsync<TSource>(
            IQueryable<TSource> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.MaxAsync(source, cancel)!;
        }

        /// <summary>
        /// Asynchronously invokes a projection function on each element of a sequence and returns the maximum resulting value.
        /// </summary>
        public Task<TResult?> MaxAsync<TSource, TResult>(IQueryable<TSource> source,
            Expression<Func<TSource, TResult>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.MaxAsync(source, selector, cancel)!;
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of values.
        /// </summary>
        public Task<decimal> SumAsync(
            IQueryable<decimal> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of values.
        /// </summary>
        public Task<decimal?> SumAsync(
            IQueryable<decimal?> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<decimal> SumAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, decimal>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<decimal?> SumAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, decimal?>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of values.
        /// </summary>
        public Task<int> SumAsync(
            IQueryable<int> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of values.
        /// </summary>
        public Task<int?> SumAsync(
            IQueryable<int?> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<int> SumAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, int>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<int?> SumAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, int?>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of values.
        /// </summary>
        public Task<long> SumAsync(
            IQueryable<long> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of values.
        /// </summary>
        public Task<long?> SumAsync(
            IQueryable<long?> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<long> SumAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, long>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<long?> SumAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, long?>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of values.
        /// </summary>
        public Task<double> SumAsync(
            IQueryable<double> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of values.
        /// </summary>
        public Task<double?> SumAsync(
            IQueryable<double?> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<double> SumAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, double>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<double?> SumAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, double?>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of values.
        /// </summary>
        public Task<float> SumAsync(
            IQueryable<float> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of a sequence of values.
        /// </summary>
        public Task<float?> SumAsync(
            IQueryable<float?> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<float> SumAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, float>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the sum of the sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<float?> SumAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, float?>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.SumAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values.
        /// </summary>
        public Task<decimal> AverageAsync(
            IQueryable<decimal> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values.
        /// </summary>
        public Task<decimal?> AverageAsync(
            IQueryable<decimal?> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<decimal> AverageAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, decimal>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<decimal?> AverageAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, decimal?>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values.
        /// </summary>
        public Task<double> AverageAsync(
            IQueryable<int> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values.
        /// </summary>
        public Task<double?> AverageAsync(
            IQueryable<int?> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<double> AverageAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, int>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<double?> AverageAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, int?>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values.
        /// </summary>
        public Task<double> AverageAsync(
            IQueryable<long> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values.
        /// </summary>
        public Task<double?> AverageAsync(
            IQueryable<long?> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<double> AverageAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, long>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source,
                selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<double?> AverageAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, long?>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values.
        /// </summary>
        public Task<double> AverageAsync(
            IQueryable<double> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values.
        /// </summary>
        public Task<double?> AverageAsync(
            IQueryable<double?> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<double> AverageAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, double>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source,
                selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<double?> AverageAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, double?>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source,
                selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values.
        /// </summary>
        public Task<float> AverageAsync(
            IQueryable<float> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values.
        /// </summary>
        public Task<float?> AverageAsync(
            IQueryable<float?> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<float> AverageAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, float>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously computes the average of a sequence of values that is obtained by invoking a projection function on each element of the input sequence.
        /// </summary>
        public Task<float?> AverageAsync<TSource>(
            IQueryable<TSource> source,
            Expression<Func<TSource, float?>> selector,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.AverageAsync(source, selector, cancel);
        }

        /// <summary>
        /// Asynchronously determines whether a sequence contains a specified element by using the default equality comparer.
        /// </summary>
        public Task<bool> ContainsAsync<TSource>(
            IQueryable<TSource> source,
            TSource item,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.ContainsAsync(source, item, cancel);
        }

        /// <summary>
        /// Asynchronously creates a list from an IQueryable by enumerating it asynchronously.
        /// </summary>
        public Task<List<TSource>> ToListAsync<TSource>(
            IQueryable<TSource> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.ToListAsync(source, cancel);
        }

        /// <summary>
        /// Asynchronously creates an array from an IQueryable by enumerating it asynchronously.
        /// </summary>
        public Task<TSource[]> ToArrayAsync<TSource>(
            IQueryable<TSource> source,
            CancellationToken cancel = default)
        {
            return EntityFrameworkQueryableExtensions.ToArrayAsync(source, cancel);
        }


        /// <summary>
        /// Creates a dictionary from an IQueryable by enumerating it asynchronously according to a specified key selector function.
        /// </summary>
        public Task<Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(
            IQueryable<TSource> source,
            Func<TSource, TKey> keySelector,
            CancellationToken cancel = default) where TKey : notnull
        {
            return EntityFrameworkQueryableExtensions.ToDictionaryAsync(source, keySelector, cancel);
        }

        /// <summary>
        /// Creates a dictionary from an IQueryable by enumerating it asynchronously according to a specified key selector function and a comparer.
        /// </summary>
        public Task<Dictionary<TKey, TSource>> ToDictionaryAsync<TSource, TKey>(
            IQueryable<TSource> source,
            Func<TSource, TKey> keySelector,
            IEqualityComparer<TKey> comparer,
            CancellationToken cancel = default) where TKey : notnull
        {
            return EntityFrameworkQueryableExtensions.ToDictionaryAsync(source, keySelector, comparer, cancel);
        }

        /// <summary>
        /// Creates a dictionary from an IQueryable by enumerating it asynchronously according to a specified key selector and an element selector function.
        /// </summary>
        public Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(
            IQueryable<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector,
            CancellationToken cancel = default) where TKey : notnull
        {
            return EntityFrameworkQueryableExtensions.ToDictionaryAsync(source, keySelector, elementSelector, cancel);
        }

        /// <summary>
        /// Creates a dictionary from an IQueryable by enumerating it asynchronously according to a specified key selector function, a comparer, and an element selector function.
        /// </summary>
        public Task<Dictionary<TKey, TElement>> ToDictionaryAsync<TSource, TKey, TElement>(
            IQueryable<TSource> source,
            Func<TSource, TKey> keySelector,
            Func<TSource, TElement> elementSelector,
            IEqualityComparer<TKey> comparer,
            CancellationToken cancel = default) where TKey : notnull
        {
            return EntityFrameworkQueryableExtensions.ToDictionaryAsync(source, keySelector, elementSelector, comparer, cancel);
        }

        /// <summary>
        /// Get query provider supported
        /// </summary>
#pragma warning disable EF1001
        public Type QueryProvider => typeof(EntityQueryProvider);
#pragma warning restore EF1001
    }
}
