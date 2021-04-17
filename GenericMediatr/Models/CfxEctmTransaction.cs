using System.Text.Json.Serialization;

namespace GenericMediatr.Models
{
    public class CfxEctmTransaction<TMessage>
    {
        [JsonPropertyName("content")]
        public CfxEctmTransactionEvent<TMessage> Content { get; set; }
    }
}
