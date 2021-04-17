using System;
using System.Text.Json.Serialization;

namespace GenericMediatr.Models
{
    public class CfxEctmEvent<T>
        where T : class
    {
        [JsonPropertyName("etype")]
        public string EType { get; set; }

        public DateTime TimeStamp { get; set; }

        public CfxEctmTransaction<T> Transaction { get; set; }
    }
}
