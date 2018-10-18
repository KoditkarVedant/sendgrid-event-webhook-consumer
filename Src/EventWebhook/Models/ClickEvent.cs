using Newtonsoft.Json;
using System;

namespace EventWebhook.Models
{
    public class ClickEvent : OpenEvent
    {
        [JsonConverter(typeof(UriTypeConverter))]
        public Uri Url { get; set; }
    }
}
