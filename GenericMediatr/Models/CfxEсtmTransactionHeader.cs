using System;
using System.Text.Json.Serialization;

namespace GenericMediatr.Models
{
    public class CfxEсtmTransactionHeader
    {
        public DateTime TimeStamp { get; set; }

        [JsonPropertyName("uniqueID")]
        public Guid UniqueId { get; set; }

        public string CfxHandle { get; set; }

        public string IfgName { get; set; }

        public string Factory { get; set; }
        public string MachineName { get; set; }
    }
}