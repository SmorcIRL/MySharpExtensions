using System;
using System.Collections.Generic;
using System.Linq;

namespace SmorcIRL.Extensions
{
    public static partial class Extensions
    {
        public static T[] EmptyIfNull<T>(this T[] array)
        {
            return array ?? Array.Empty<T>();
        }

        public static IEnumerable<T> EmptyIfNull<T>(this IEnumerable<T> enumerable)
        {
            return enumerable ?? Enumerable.Empty<T>();
        }
    }
}