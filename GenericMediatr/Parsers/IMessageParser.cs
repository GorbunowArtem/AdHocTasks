using CFX;

namespace GenericMediatr.Parsers
{
	public interface IMessageParser<in T> where T: CFXMessage
	{
		void Parse(T message);
	}
}