// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLMessageActionChannelCreate : TLMessageActionBase 
	{
		public String Title { get; set; }

		public TLMessageActionChannelCreate() { }
		public TLMessageActionChannelCreate(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessageActionChannelCreate; } }

		public override void Read(TLBinaryReader from)
		{
			Title = from.ReadString();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x95D2AC92);
			to.Write(Title);
		}
	}
}