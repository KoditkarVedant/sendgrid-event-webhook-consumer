namespace EventWebhook.Models
{
    public enum EventType
    {
        Processed,
        Deferred,
        Delivered,
        Open,
        Click,
        Bounce,
        Dropped,
        SpamReport,
        Unsubscribe,
        GroupUnsubscribe,
        GroupResubscribe
    }
}
