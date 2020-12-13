using System;

namespace SmorcIRL.Extensions
{
    public static partial class Extensions
    {
        public static T ChangeType<T>(this object obj)
        {
            return (T) Convert.ChangeType(obj, typeof(T));
        }
    }
}