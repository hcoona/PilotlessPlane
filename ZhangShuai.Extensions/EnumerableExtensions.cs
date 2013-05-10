using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace ZhangShuai.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<TResult> ToEnumerable<TFrom, TResult>(this TFrom source, Func<TFrom, IEnumerable<TResult>> f)
        {
            return f(source);
        }

        public static IEnumerable<T[]> ToWindowed<T>(this IEnumerable<T> source, int windowSize)
        {
            Contract.Requires<ArgumentNullException>(source != null);

            var queue = new Queue<T>(windowSize);
            using (var enumerator = source.GetEnumerator())
            {
                while (windowSize != 0)
                {
                    enumerator.MoveNext();
                    queue.Enqueue(enumerator.Current);
                    windowSize--;
                }
                yield return queue.ToArray();

                while (enumerator.MoveNext())
                {
                    queue.Dequeue();
                    queue.Enqueue(enumerator.Current);
                    yield return queue.ToArray();
                }
            }
        }
    }
}
