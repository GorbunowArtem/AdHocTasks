using System.Text.Json.Serialization;

namespace GenericMediatr.Models
{
    public class CfxEсtmMessage<T> 
        where T : class
    {
        [JsonPropertyName("ectm")]
        public CfxEctmEvent<T> EctmEvent { get; set; }
    }
}
