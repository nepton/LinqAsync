using System.Collections;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Doulex.EntityFrameworkCore.Extensions
{
    /// <summary>
    /// Provider queryable baseclass for entity query
    /// </summary>
    /// <remarks>
    /// How to use:
    /// Define interface in application
    /// interface IUserQueryable : IQueryable[User] { }
    ///
    /// Implement interface in repository
    /// class UserQueryable : EntityFrameworkCoreQueryable[User], IUserQueryable { }
    /// 
    /// </remarks>
    /// <typeparam name="TEntity"></typeparam>
    public class EntityFrameworkCoreQueryable<TEntity> : IQueryable<TEntity>, IAsyncEnumerable<TEntity>
        where TEntity : class
    {
        private readonly IQueryable<TEntity> _queryable;

        /// <summary>
        /// Constructor function
        /// </summary>
        /// <param name="context">The db context, if you want modifer the features of context, do it here</param>
        public EntityFrameworkCoreQueryable(DbContext context)
        {
            _queryable = context.Set<TEntity>().AsNoTracking();
        }

        #region Implements IQueryable interface

        /// <summary>Returns an enumerator that iterates through the collection.</summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        IEnumerator<TEntity> IEnumerable<TEntity>.GetEnumerator() => _queryable.GetEnumerator();

        /// <summary>Returns an enumerator that iterates through a collection.</summary>
        /// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable) _queryable).GetEnumerator();

        /// <summary>Gets the type of the element(s) that are returned when the expression tree associated with this instance of <see cref="T:System.Linq.IQueryable" /> is executed.</summary>
        /// <returns>A <see cref="T:System.Type" /> that represents the type of the element(s) that are returned when the expression tree associated with this object is executed.</returns>
        Type IQueryable.ElementType => _queryable.ElementType;

        /// <summary>Gets the expression tree that is associated with the instance of <see cref="T:System.Linq.IQueryable" />.</summary>
        /// <returns>The <see cref="T:System.Linq.Expressions.Expression" /> that is associated with this instance of <see cref="T:System.Linq.IQueryable" />.</returns>
        Expression IQueryable.Expression => _queryable.Expression;

        /// <summary>Gets the query provider that is associated with this data source.</summary>
        /// <returns>The <see cref="T:System.Linq.IQueryProvider" /> that is associated with this data source.</returns>
        IQueryProvider IQueryable.Provider => _queryable.Provider;

        #endregion

        #region Implements IAsyncEnumerable interface

        /// <summary>Returns an enumerator that iterates asynchronously through the collection.</summary>
        /// <param name="cancel">A <see cref="T:System.Threading.CancellationToken" /> that may be used to cancel the asynchronous iteration.</param>
        /// <returns>An enumerator that can be used to iterate asynchronously through the collection.</returns>
        IAsyncEnumerator<TEntity> IAsyncEnumerable<TEntity>.GetAsyncEnumerator(CancellationToken cancel) =>
            ((IAsyncEnumerable<TEntity>) _queryable).GetAsyncEnumerator(cancel);

        #endregion
    }
}
