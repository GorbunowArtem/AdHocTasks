using System.Collections.Generic;
using CFX;
using CFX.ResourcePerformance;
using GenericMediatr.Models;

namespace GenericMediatr.Parsers
{
	public abstract class BaseMessageParser<TMessage> where TMessage: CFXMessage
	{
		private readonly IIdGenerator _idGenerator;
		private List<CamxMessageData> _camxMessageDatas;
		private long _id;
		private string _sender;

		protected abstract string Element { get; }

		protected BaseMessageParser(IIdGenerator idGenerator)
		{
			_idGenerator = idGenerator;
			_camxMessageDatas = new List<CamxMessageData>();
		}

		protected abstract void PopulateMessageData();
		
		public List<CamxMessageData> Parse(CfxEctmEvent<TMessage> message)
		{
			_id = _idGenerator.Generate();

			_camxMessageDatas = new List<CamxMessageData>();

			var (header, body) = message.Transaction.Content;

			_sender = header.MachineName;
			
			_camxMessageDatas.Add(new CamxMessageData(_id, Element, "dateTime", message.TimeStamp.ToString(), _sender));

			PopulateMessageData();
			
			return _camxMessageDatas;
		}
		
		

		protected void AddToDatas(
			string attribute,
			string value,
			string subElement = "")
		{
			var data = new  CamxMessageData(_id, Element, attribute, value, _sender, subElement);
			
			_camxMessageDatas.Add(data);
		}
	}

	public interface IIdGenerator
	{
		long Generate();
	}
	
	public class IdGenerator: IIdGenerator
	{
		public long Generate()
		{

			return 10;
		}
	}
}