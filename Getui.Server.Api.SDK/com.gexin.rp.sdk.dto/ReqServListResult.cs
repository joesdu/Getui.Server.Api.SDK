using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Collections;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x0200000A RID: 10
    [DebuggerNonUserCode]
	public sealed class ReqServListResult : GeneratedMessage<ReqServListResult, ReqServListResult.Builder>
	{
		// Token: 0x06000073 RID: 115 RVA: 0x000029E2 File Offset: 0x00000BE2
		private ReqServListResult()
		{
		}

        // Token: 0x17000031 RID: 49
        // (get) Token: 0x06000074 RID: 116 RVA: 0x00002A07 File Offset: 0x00000C07
        public static ReqServListResult DefaultInstance { get; } = new ReqServListResult().MakeReadOnly();

        // Token: 0x17000032 RID: 50
        // (get) Token: 0x06000075 RID: 117 RVA: 0x00002A0E File Offset: 0x00000C0E
        public override ReqServListResult DefaultInstanceForType => DefaultInstance;

        // Token: 0x17000033 RID: 51
        // (get) Token: 0x06000076 RID: 118 RVA: 0x00002A15 File Offset: 0x00000C15
        protected override ReqServListResult ThisMessage => this;

        // Token: 0x17000034 RID: 52
        // (get) Token: 0x06000077 RID: 119 RVA: 0x00002A18 File Offset: 0x00000C18
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_ReqServListResult__Descriptor;

        // Token: 0x17000035 RID: 53
        // (get) Token: 0x06000078 RID: 120 RVA: 0x00002A1F File Offset: 0x00000C1F
        protected override FieldAccessorTable<ReqServListResult, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_ReqServListResult__FieldAccessorTable;

        // Token: 0x17000036 RID: 54
        // (get) Token: 0x06000079 RID: 121 RVA: 0x00002A26 File Offset: 0x00000C26
        public bool HasCode { get; private set; }

        // Token: 0x17000037 RID: 55
        // (get) Token: 0x0600007A RID: 122 RVA: 0x00002A2E File Offset: 0x00000C2E
        public int Code => code_;

        // Token: 0x17000038 RID: 56
        // (get) Token: 0x0600007B RID: 123 RVA: 0x00002A36 File Offset: 0x00000C36
        public IList<string> HostList => Lists.AsReadOnly(host_);

        // Token: 0x17000039 RID: 57
        // (get) Token: 0x0600007C RID: 124 RVA: 0x00002A43 File Offset: 0x00000C43
        public int HostCount => host_.Count;

        // Token: 0x0600007D RID: 125 RVA: 0x00002A50 File Offset: 0x00000C50
        public string GetHost(int index)
		{
			return host_[index];
		}

        // Token: 0x1700003A RID: 58
        // (get) Token: 0x0600007E RID: 126 RVA: 0x00002A5E File Offset: 0x00000C5E
        public bool HasSeqId { get; private set; }

        // Token: 0x1700003B RID: 59
        // (get) Token: 0x0600007F RID: 127 RVA: 0x00002A66 File Offset: 0x00000C66
        public string SeqId => seqId_;

        // Token: 0x1700003C RID: 60
        // (get) Token: 0x06000080 RID: 128 RVA: 0x00002A6E File Offset: 0x00000C6E
        public override bool IsInitialized => HasCode;

        // Token: 0x06000081 RID: 129 RVA: 0x00002A7C File Offset: 0x00000C7C
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] reqServListResultFieldNames = _reqServListResultFieldNames;
			if (HasCode)
			{
				output.WriteInt32(1, reqServListResultFieldNames[0], Code);
			}
			if (host_.Count > 0)
			{
				output.WriteStringArray(2, reqServListResultFieldNames[1], host_);
			}
			if (HasSeqId)
			{
				output.WriteString(3, reqServListResultFieldNames[2], SeqId);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002AF0 File Offset: 0x00000CF0
		public override int SerializedSize
		{
			get
			{
				int num = memoizedSerializedSize;
				if (num != -1)
				{
					return num;
				}
				num = 0;
				if (HasCode)
				{
					num += CodedOutputStream.ComputeInt32Size(1, Code);
				}
				int num2 = 0;
				foreach (string value in HostList)
				{
					num2 += CodedOutputStream.ComputeStringSizeNoTag(value);
				}
				num += num2;
				num += host_.Count;
				if (HasSeqId)
				{
					num += CodedOutputStream.ComputeStringSize(3, SeqId);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002BA8 File Offset: 0x00000DA8
		public static ReqServListResult ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002BBA File Offset: 0x00000DBA
		public static ReqServListResult ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002BCD File Offset: 0x00000DCD
		public static ReqServListResult ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002BDF File Offset: 0x00000DDF
		public static ReqServListResult ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002BF2 File Offset: 0x00000DF2
		public static ReqServListResult ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002C04 File Offset: 0x00000E04
		public static ReqServListResult ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002C17 File Offset: 0x00000E17
		public static ReqServListResult ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002C29 File Offset: 0x00000E29
		public static ReqServListResult ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002C3C File Offset: 0x00000E3C
		public static ReqServListResult ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002C4E File Offset: 0x00000E4E
		public static ReqServListResult ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002C61 File Offset: 0x00000E61
		private ReqServListResult MakeReadOnly()
		{
			host_.MakeReadOnly();
			return this;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002C6F File Offset: 0x00000E6F
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002C76 File Offset: 0x00000E76
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002C7E File Offset: 0x00000E7E
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002C85 File Offset: 0x00000E85
		public static Builder CreateBuilder(ReqServListResult prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002C90 File Offset: 0x00000E90
		static ReqServListResult()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x0400008A RID: 138
        private static readonly string[] _reqServListResultFieldNames = new string[]
		{
			"code",
			"host",
			"seqId"
		};

		// Token: 0x0400008B RID: 139
		private static readonly uint[] _reqServListResultFieldTags = new uint[]
		{
			8U,
			18U,
			26U
		};

		// Token: 0x0400008C RID: 140
		public const int CodeFieldNumber = 1;

        // Token: 0x0400008E RID: 142
        private int code_;

		// Token: 0x0400008F RID: 143
		public const int HostFieldNumber = 2;

		// Token: 0x04000090 RID: 144
		private PopsicleList<string> host_ = new PopsicleList<string>();

		// Token: 0x04000091 RID: 145
		public const int SeqIdFieldNumber = 3;

        // Token: 0x04000093 RID: 147
        private string seqId_ = "";

		// Token: 0x04000094 RID: 148
		private int memoizedSerializedSize = -1;

		// Token: 0x02000063 RID: 99
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02000093 RID: 147
			public enum ReqServHostResultCode
			{
				// Token: 0x0400040C RID: 1036
				successed,
				// Token: 0x0400040D RID: 1037
				failed,
				// Token: 0x0400040E RID: 1038
				busy
			}
		}

		// Token: 0x02000064 RID: 100
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<ReqServListResult, Builder>
		{
            // Token: 0x170002E9 RID: 745
            // (get) Token: 0x06000718 RID: 1816 RVA: 0x000111A8 File Offset: 0x0000F3A8
            protected override Builder ThisBuilder => this;

            // Token: 0x06000719 RID: 1817 RVA: 0x000111AB File Offset: 0x0000F3AB
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x0600071A RID: 1818 RVA: 0x000111C5 File Offset: 0x0000F3C5
			internal Builder(ReqServListResult cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x0600071B RID: 1819 RVA: 0x000111DC File Offset: 0x0000F3DC
			private ReqServListResult PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					ReqServListResult other = result;
					result = new ReqServListResult();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x170002EA RID: 746
            // (get) Token: 0x0600071C RID: 1820 RVA: 0x00011218 File Offset: 0x0000F418
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x170002EB RID: 747
            // (get) Token: 0x0600071D RID: 1821 RVA: 0x00011225 File Offset: 0x0000F425
            protected override ReqServListResult MessageBeingBuilt => PrepareBuilder();

            // Token: 0x0600071E RID: 1822 RVA: 0x0001122D File Offset: 0x0000F42D
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x0600071F RID: 1823 RVA: 0x00011242 File Offset: 0x0000F442
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x170002EC RID: 748
            // (get) Token: 0x06000720 RID: 1824 RVA: 0x00011268 File Offset: 0x0000F468
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x170002ED RID: 749
            // (get) Token: 0x06000721 RID: 1825 RVA: 0x0001126F File Offset: 0x0000F46F
            public override ReqServListResult DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000722 RID: 1826 RVA: 0x00011276 File Offset: 0x0000F476
            public override ReqServListResult BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x06000723 RID: 1827 RVA: 0x00011299 File Offset: 0x0000F499
			public override Builder MergeFrom(IMessage other)
			{
				if (other is ReqServListResult)
				{
					return MergeFrom((ReqServListResult)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000724 RID: 1828 RVA: 0x000112BC File Offset: 0x0000F4BC
			public override Builder MergeFrom(ReqServListResult other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasCode)
				{
					Code = other.Code;
				}
				if (other.host_.Count != 0)
				{
					result.host_.Add(other.host_);
				}
				if (other.HasSeqId)
				{
					SeqId = other.SeqId;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000725 RID: 1829 RVA: 0x00011333 File Offset: 0x0000F533
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000726 RID: 1830 RVA: 0x00011344 File Offset: 0x0000F544
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_reqServListResultFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _reqServListResultFieldTags[num2];
                    }
                    if (num <= 8U)
                    {
                        if (num == 0U)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 8U)
                        {
                            result.HasCode = input.ReadInt32(ref result.code_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 18U)
                        {
                            input.ReadStringArray(num, text, result.host_);
                            continue;
                        }
                        if (num == 26U)
                        {
                            result.HasSeqId = input.ReadString(ref result.seqId_);
                            continue;
                        }
                    }
                    if (WireFormat.IsEndGroupTag(num))
                    {
                        if (builder != null)
                        {
                            UnknownFields = builder.Build();
                        }
                        return this;
                    }
                    if (builder == null)
                    {
                        builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                    }
                    ParseUnknownField(input, builder, extensionRegistry, num, text);
                }
                if (builder != null)
				{
					UnknownFields = builder.Build();
				}
				return this;
			}

            // Token: 0x170002EE RID: 750
            // (get) Token: 0x06000727 RID: 1831 RVA: 0x00011467 File Offset: 0x0000F667
            public bool HasCode => result.HasCode;

            // Token: 0x170002EF RID: 751
            // (get) Token: 0x06000728 RID: 1832 RVA: 0x00011474 File Offset: 0x0000F674
            // (set) Token: 0x06000729 RID: 1833 RVA: 0x00011481 File Offset: 0x0000F681
            public int Code
			{
				get
				{
					return result.Code;
				}
				set
				{
					SetCode(value);
				}
			}

			// Token: 0x0600072A RID: 1834 RVA: 0x0001148B File Offset: 0x0000F68B
			public Builder SetCode(int value)
			{
				PrepareBuilder();
				result.HasCode = true;
				result.code_ = value;
				return this;
			}

			// Token: 0x0600072B RID: 1835 RVA: 0x000114AD File Offset: 0x0000F6AD
			public Builder ClearCode()
			{
				PrepareBuilder();
				result.HasCode = false;
				result.code_ = 0;
				return this;
			}

            // Token: 0x170002F0 RID: 752
            // (get) Token: 0x0600072C RID: 1836 RVA: 0x000114CF File Offset: 0x0000F6CF
            public IPopsicleList<string> HostList => PrepareBuilder().host_;

            // Token: 0x170002F1 RID: 753
            // (get) Token: 0x0600072D RID: 1837 RVA: 0x000114DC File Offset: 0x0000F6DC
            public int HostCount => result.HostCount;

            // Token: 0x0600072E RID: 1838 RVA: 0x000114E9 File Offset: 0x0000F6E9
            public string GetHost(int index)
			{
				return result.GetHost(index);
			}

			// Token: 0x0600072F RID: 1839 RVA: 0x000114F7 File Offset: 0x0000F6F7
			public Builder SetHost(int index, string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.host_[index] = value;
				return this;
			}

			// Token: 0x06000730 RID: 1840 RVA: 0x0001151E File Offset: 0x0000F71E
			public Builder AddHost(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.host_.Add(value);
				return this;
			}

			// Token: 0x06000731 RID: 1841 RVA: 0x00011544 File Offset: 0x0000F744
			public Builder AddRangeHost(IEnumerable<string> values)
			{
				PrepareBuilder();
				result.host_.Add(values);
				return this;
			}

			// Token: 0x06000732 RID: 1842 RVA: 0x0001155F File Offset: 0x0000F75F
			public Builder ClearHost()
			{
				PrepareBuilder();
				result.host_.Clear();
				return this;
			}

            // Token: 0x170002F2 RID: 754
            // (get) Token: 0x06000733 RID: 1843 RVA: 0x00011579 File Offset: 0x0000F779
            public bool HasSeqId => result.HasSeqId;

            // Token: 0x170002F3 RID: 755
            // (get) Token: 0x06000734 RID: 1844 RVA: 0x00011586 File Offset: 0x0000F786
            // (set) Token: 0x06000735 RID: 1845 RVA: 0x00011593 File Offset: 0x0000F793
            public string SeqId
			{
				get
				{
					return result.SeqId;
				}
				set
				{
					SetSeqId(value);
				}
			}

			// Token: 0x06000736 RID: 1846 RVA: 0x0001159D File Offset: 0x0000F79D
			public Builder SetSeqId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSeqId = true;
				result.seqId_ = value;
				return this;
			}

			// Token: 0x06000737 RID: 1847 RVA: 0x000115CA File Offset: 0x0000F7CA
			public Builder ClearSeqId()
			{
				PrepareBuilder();
				result.HasSeqId = false;
				result.seqId_ = "";
				return this;
			}

			// Token: 0x040003BB RID: 955
			private bool resultIsReadOnly;

			// Token: 0x040003BC RID: 956
			private ReqServListResult result;
		}
	}
}
