using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000009 RID: 9
    [DebuggerNonUserCode]
	public sealed class ReqServList : GeneratedMessage<ReqServList, ReqServList.Builder>
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00002793 File Offset: 0x00000993
		private ReqServList()
		{
		}

        // Token: 0x17000026 RID: 38
        // (get) Token: 0x06000057 RID: 87 RVA: 0x000027AD File Offset: 0x000009AD
        public static ReqServList DefaultInstance { get; } = new ReqServList().MakeReadOnly();

        // Token: 0x17000027 RID: 39
        // (get) Token: 0x06000058 RID: 88 RVA: 0x000027B4 File Offset: 0x000009B4
        public override ReqServList DefaultInstanceForType => DefaultInstance;

        // Token: 0x17000028 RID: 40
        // (get) Token: 0x06000059 RID: 89 RVA: 0x000027BB File Offset: 0x000009BB
        protected override ReqServList ThisMessage => this;

        // Token: 0x17000029 RID: 41
        // (get) Token: 0x0600005A RID: 90 RVA: 0x000027BE File Offset: 0x000009BE
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_ReqServList__Descriptor;

        // Token: 0x1700002A RID: 42
        // (get) Token: 0x0600005B RID: 91 RVA: 0x000027C5 File Offset: 0x000009C5
        protected override FieldAccessorTable<ReqServList, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_ReqServList__FieldAccessorTable;

        // Token: 0x1700002B RID: 43
        // (get) Token: 0x0600005C RID: 92 RVA: 0x000027CC File Offset: 0x000009CC
        public bool HasSeqId { get; private set; }

        // Token: 0x1700002C RID: 44
        // (get) Token: 0x0600005D RID: 93 RVA: 0x000027D4 File Offset: 0x000009D4
        public string SeqId => seqId_;

        // Token: 0x1700002D RID: 45
        // (get) Token: 0x0600005E RID: 94 RVA: 0x000027DC File Offset: 0x000009DC
        public bool HasTimestamp { get; private set; }

        // Token: 0x1700002E RID: 46
        // (get) Token: 0x0600005F RID: 95 RVA: 0x000027E4 File Offset: 0x000009E4
        public long Timestamp => timestamp_;

        // Token: 0x1700002F RID: 47
        // (get) Token: 0x06000060 RID: 96 RVA: 0x000027EC File Offset: 0x000009EC
        public override bool IsInitialized => HasTimestamp;

        // Token: 0x06000061 RID: 97 RVA: 0x000027FC File Offset: 0x000009FC
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] reqServListFieldNames = _reqServListFieldNames;
			if (HasSeqId)
			{
				output.WriteString(1, reqServListFieldNames[0], SeqId);
			}
			if (HasTimestamp)
			{
				output.WriteInt64(3, reqServListFieldNames[1], Timestamp);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002854 File Offset: 0x00000A54
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
				if (HasSeqId)
				{
					num += CodedOutputStream.ComputeStringSize(1, SeqId);
				}
				if (HasTimestamp)
				{
					num += CodedOutputStream.ComputeInt64Size(3, Timestamp);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000028B4 File Offset: 0x00000AB4
		public static ReqServList ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000028C6 File Offset: 0x00000AC6
		public static ReqServList ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000028D9 File Offset: 0x00000AD9
		public static ReqServList ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000028EB File Offset: 0x00000AEB
		public static ReqServList ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000028FE File Offset: 0x00000AFE
		public static ReqServList ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002910 File Offset: 0x00000B10
		public static ReqServList ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002923 File Offset: 0x00000B23
		public static ReqServList ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002935 File Offset: 0x00000B35
		public static ReqServList ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002948 File Offset: 0x00000B48
		public static ReqServList ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000295A File Offset: 0x00000B5A
		public static ReqServList ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000296D File Offset: 0x00000B6D
		private ReqServList MakeReadOnly()
		{
			return this;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002970 File Offset: 0x00000B70
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002977 File Offset: 0x00000B77
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000297F File Offset: 0x00000B7F
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002986 File Offset: 0x00000B86
		public static Builder CreateBuilder(ReqServList prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002990 File Offset: 0x00000B90
		static ReqServList()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x04000080 RID: 128
        private static readonly string[] _reqServListFieldNames = new string[]
		{
			"seqId",
			"timestamp"
		};

		// Token: 0x04000081 RID: 129
		private static readonly uint[] _reqServListFieldTags = new uint[]
		{
			10U,
			24U
		};

		// Token: 0x04000082 RID: 130
		public const int SeqIdFieldNumber = 1;

        // Token: 0x04000084 RID: 132
        private string seqId_ = "";

		// Token: 0x04000085 RID: 133
		public const int TimestampFieldNumber = 3;

        // Token: 0x04000087 RID: 135
        private long timestamp_;

		// Token: 0x04000088 RID: 136
		private int memoizedSerializedSize = -1;

		// Token: 0x02000062 RID: 98
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<ReqServList, Builder>
		{
            // Token: 0x170002E0 RID: 736
            // (get) Token: 0x060006FF RID: 1791 RVA: 0x00010E4D File Offset: 0x0000F04D
            protected override Builder ThisBuilder => this;

            // Token: 0x06000700 RID: 1792 RVA: 0x00010E50 File Offset: 0x0000F050
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000701 RID: 1793 RVA: 0x00010E6A File Offset: 0x0000F06A
			internal Builder(ReqServList cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x06000702 RID: 1794 RVA: 0x00010E80 File Offset: 0x0000F080
			private ReqServList PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					ReqServList other = result;
					result = new ReqServList();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x170002E1 RID: 737
            // (get) Token: 0x06000703 RID: 1795 RVA: 0x00010EBC File Offset: 0x0000F0BC
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x170002E2 RID: 738
            // (get) Token: 0x06000704 RID: 1796 RVA: 0x00010EC9 File Offset: 0x0000F0C9
            protected override ReqServList MessageBeingBuilt => PrepareBuilder();

            // Token: 0x06000705 RID: 1797 RVA: 0x00010ED1 File Offset: 0x0000F0D1
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x06000706 RID: 1798 RVA: 0x00010EE6 File Offset: 0x0000F0E6
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x170002E3 RID: 739
            // (get) Token: 0x06000707 RID: 1799 RVA: 0x00010F0C File Offset: 0x0000F10C
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x170002E4 RID: 740
            // (get) Token: 0x06000708 RID: 1800 RVA: 0x00010F13 File Offset: 0x0000F113
            public override ReqServList DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000709 RID: 1801 RVA: 0x00010F1A File Offset: 0x0000F11A
            public override ReqServList BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x0600070A RID: 1802 RVA: 0x00010F3D File Offset: 0x0000F13D
			public override Builder MergeFrom(IMessage other)
			{
				if (other is ReqServList)
				{
					return MergeFrom((ReqServList)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x0600070B RID: 1803 RVA: 0x00010F60 File Offset: 0x0000F160
			public override Builder MergeFrom(ReqServList other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasSeqId)
				{
					SeqId = other.SeqId;
				}
				if (other.HasTimestamp)
				{
					Timestamp = other.Timestamp;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x0600070C RID: 1804 RVA: 0x00010FB4 File Offset: 0x0000F1B4
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x0600070D RID: 1805 RVA: 0x00010FC4 File Offset: 0x0000F1C4
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_reqServListFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _reqServListFieldTags[num2];
                    }
                    if (num == 0U)
                    {
                        throw InvalidProtocolBufferException.InvalidTag();
                    }
                    if (num != 10U)
                    {
                        if (num != 24U)
                        {
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
                        else
                        {
                            result.HasTimestamp = input.ReadInt64(ref result.timestamp_);
                        }
                    }
                    else
                    {
                        result.HasSeqId = input.ReadString(ref result.seqId_);
                    }
                }
                if (builder != null)
				{
					UnknownFields = builder.Build();
				}
				return this;
			}

            // Token: 0x170002E5 RID: 741
            // (get) Token: 0x0600070E RID: 1806 RVA: 0x000110C8 File Offset: 0x0000F2C8
            public bool HasSeqId => result.HasSeqId;

            // Token: 0x170002E6 RID: 742
            // (get) Token: 0x0600070F RID: 1807 RVA: 0x000110D5 File Offset: 0x0000F2D5
            // (set) Token: 0x06000710 RID: 1808 RVA: 0x000110E2 File Offset: 0x0000F2E2
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

			// Token: 0x06000711 RID: 1809 RVA: 0x000110EC File Offset: 0x0000F2EC
			public Builder SetSeqId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSeqId = true;
				result.seqId_ = value;
				return this;
			}

			// Token: 0x06000712 RID: 1810 RVA: 0x00011119 File Offset: 0x0000F319
			public Builder ClearSeqId()
			{
				PrepareBuilder();
				result.HasSeqId = false;
				result.seqId_ = "";
				return this;
			}

            // Token: 0x170002E7 RID: 743
            // (get) Token: 0x06000713 RID: 1811 RVA: 0x0001113F File Offset: 0x0000F33F
            public bool HasTimestamp => result.HasTimestamp;

            // Token: 0x170002E8 RID: 744
            // (get) Token: 0x06000714 RID: 1812 RVA: 0x0001114C File Offset: 0x0000F34C
            // (set) Token: 0x06000715 RID: 1813 RVA: 0x00011159 File Offset: 0x0000F359
            public long Timestamp
			{
				get
				{
					return result.Timestamp;
				}
				set
				{
					SetTimestamp(value);
				}
			}

			// Token: 0x06000716 RID: 1814 RVA: 0x00011163 File Offset: 0x0000F363
			public Builder SetTimestamp(long value)
			{
				PrepareBuilder();
				result.HasTimestamp = true;
				result.timestamp_ = value;
				return this;
			}

			// Token: 0x06000717 RID: 1815 RVA: 0x00011185 File Offset: 0x0000F385
			public Builder ClearTimestamp()
			{
				PrepareBuilder();
				result.HasTimestamp = false;
				result.timestamp_ = 0L;
				return this;
			}

			// Token: 0x040003B9 RID: 953
			private bool resultIsReadOnly;

			// Token: 0x040003BA RID: 954
			private ReqServList result;
		}
	}
}
