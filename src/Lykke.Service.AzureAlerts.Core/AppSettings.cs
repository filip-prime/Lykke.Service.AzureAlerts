﻿namespace Lykke.Service.AzureAlerts.Core
{
    public class AppSettings
    {
        public AzureAlertsSettings AzureAlertsService { get; set; }
        public SlackNotificationsSettings SlackNotifications { get; set; }
    }

    public class AzureAlertsSettings
    {
        public DbSettings Db { get; set; }
        public string Secret { get; set; }
    }

    public class DbSettings
    {
        public string LogsConnString { get; set; }
    }

    public class SlackNotificationsSettings
    {
        public AzureQueueSettings AzureQueue { get; set; }
    }

    public class AzureQueueSettings
    {
        public string ConnectionString { get; set; }

        public string QueueName { get; set; }
    }
}
