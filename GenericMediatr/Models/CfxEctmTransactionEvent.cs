namespace GenericMediatr.Models
{
    public class CfxEctmTransactionEvent<TMessage>
    {
        public CfxEсtmTransactionHeader Header { get; set; }

        public TMessage Body { get; set; }
    }
}
