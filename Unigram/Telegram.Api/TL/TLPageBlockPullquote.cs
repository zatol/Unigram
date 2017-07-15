// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPageBlockPullquote : TLPageBlockBase 
	{
		public TLRichTextBase Text { get; set; }
		public TLRichTextBase Caption { get; set; }

		public TLPageBlockPullquote() { }
		public TLPageBlockPullquote(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.PageBlockPullquote; } }

		public override void Read(TLBinaryReader from)
		{
			Text = TLFactory.Read<TLRichTextBase>(from);
			Caption = TLFactory.Read<TLRichTextBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x4F4456D3);
			to.WriteObject(Text);
			to.WriteObject(Caption);
		}
	}
}