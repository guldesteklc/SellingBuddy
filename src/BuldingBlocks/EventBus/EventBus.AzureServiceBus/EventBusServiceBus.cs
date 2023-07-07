using EventBus.Base;
using EventBus.Base.Events;
using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.ServiceBus.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.AzureServiceBus
{
    public class EventBusServiceBus : BaseEventBus
    {
        private ITopicClient topicClient;
        private ManagementClient managementClient;
        public EventBusServiceBus(EventBusConfig config, IServiceProvider serviceProvider) : base(config, serviceProvider)
        {
            managementClient = new ManagementClient(config.EventBusConnectionString);
        }

      //  private ITopicClient createTopicClient()
        //{
          //  if (topicClient == null || topicClient.IsClosedOrClosing)
            //{
              //  topicClient = new TopicClient(EventBusConfig.EventBusConnectionString,
          //          EventBusConfig.DefaultTopicName, RetryPolicy.Default);
            //}
            //if (!managementClient.TopicExistsAsync(EventBusConfig.DefaultTopicName).GetAwaiter().GetResult())
            //{
              //  managementClient.CreateTopicAsync(EventBusConfig.DefaultTopicName).GetAwaiter().GetResult();
                //return topicClient;
           // }
        //}



        public override void Subscribe<T, TH>()
        {
            throw new NotImplementedException();
        }

        public override void UnSubscribe<T, TH>()
        {
            throw new NotImplementedException();
        }
    }
}
