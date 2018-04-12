using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace queueTrigger
{
    public static class testQueueTrigger
    {
        [FunctionName("testQueueTrigger")]
        public static string Run([QueueTrigger("myqueue-items", Connection = "")]string myQueueItem)
        {
           // log.Info($"C# Queue trigger function processed: {myQueueItem}");
            return myQueueItem;
        }
    }
}
