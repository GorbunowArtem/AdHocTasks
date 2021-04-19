namespace GenericMediatr.Models
{
    public class CfxEctmTransactionEvent<TMessage>
    {
        public CfxEсtmTransactionHeader Header { get; set; }

        public TMessage Body { get; set; }
        
        
        public void Deconstruct(out CfxEсtmTransactionHeader header, out TMessage body)
        {
            header = Header;
            body = Body;
        }
    }
}
