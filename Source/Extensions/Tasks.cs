using System;
using System.Threading;
using System.Threading.Tasks;

namespace SmorcIRL.Extensions
{
    public static partial class Extensions
    {
        public static async Task<T> WithTimeout<T>(this Task<T> sourceTask, TimeSpan timeout, CancellationToken token = default)
        {
            if (await Task.WhenAny(sourceTask, Task.Delay(timeout, token)) != sourceTask)
            {
                throw new TimeoutException();
            }

            return await sourceTask;
        }
        public static async Task WithTimeout(this Task sourceTask, TimeSpan timeout, CancellationToken token = default)
        {
            if (await Task.WhenAny(sourceTask, Task.Delay(timeout, token)) != sourceTask)
            {
                throw new TimeoutException();
            }

            await sourceTask;
        }

        public static async Task WaitForCancelerationAsync(this CancellationToken token, bool throwEx = false)
        {
            try
            {
                await Task.Delay(Timeout.InfiniteTimeSpan, token);
            }
            catch (TaskCanceledException)
            {
                if (throwEx)
                {
                    throw;
                }
            }
        }
    }
}