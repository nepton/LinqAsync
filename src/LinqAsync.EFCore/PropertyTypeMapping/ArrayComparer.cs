using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Doulex.EntityFrameworkCore.Extensions.PropertyTypeMapping
{
    /// <summary>
    /// 数组比较器, 用来在映射一个数组至数据库字段时提供的元数据比较器
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ArrayComparer<T> : ValueComparer<T[]>
    {
        /// <summary>
        ///     <para>
        ///         Creates a new <see cref="T:Microsoft.EntityFrameworkCore.ChangeTracking.ValueComparer`1" /> with the given comparison and
        ///         snapshotting expressions.
        ///     </para>
        ///     <para>
        ///         Snapshotting is the process of creating a copy of the value into a snapshot so it can
        ///         later be compared to determine if it has changed. For some types, such as collections,
        ///         this needs to be a deep copy of the collection rather than just a shallow copy of the
        ///         reference.
        ///     </para>
        /// </summary>
        public ArrayComparer() :
            base((c1, c2) => c1 != null && c2 != null && c1.SequenceEqual(c2),
                c => c.Aggregate(0, (a, v) => v != null ? HashCode.Combine(a, v.GetHashCode()) : 0),
                c => c.ToArray())
        {
        }
    }
}
