using System;
using System.Linq;
using SmorcIRL.Extensions;
using Xunit;

namespace Tests
{
    public class CollectionsTests
    {
        [Fact]
        public void Test_1()
        {
            CheckArr(null);
            CheckArr(Array.Empty<object>());
            CheckArr(new[] {new object()});

            static void CheckArr(object[] array)
            {
                var newArray = array.EmptyIfNull();
                int count = newArray.Length;

                Assert.True(array != null && array.Length == count || array == null && count == 0);
            }
        }
    }
}