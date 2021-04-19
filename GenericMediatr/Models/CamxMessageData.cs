namespace GenericMediatr.Models
{
	public class CamxMessageData
	{
		public CamxMessageData(long messageId, string element, string attribute, string value, string sender, string subElement = "")
		{
			MessageId = messageId;
			Sender = sender;
			Element = element;
			SubElement = subElement;
			Attribute = attribute;
			Value = value;
		}

		public long MessageId { get; set; }

		public string Sender { get; set; }

		public string Element { get; set; }

		public string SubElement { get; set; }

		public string Attribute { get; set; }

		public string Value { get; set; }
	}
}