using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000019 RID: 25
    [DebuggerNonUserCode]
	public sealed class ServerNotify : GeneratedMessage<ServerNotify, ServerNotify.Builder>
	{
		// Token: 0x06000254 RID: 596 RVA: 0x000057FB File Offset: 0x000039FB
		private ServerNotify()
		{
		}

        // Token: 0x170000FC RID: 252
        // (get) Token: 0x06000255 RID: 597 RVA: 0x0000582B File Offset: 0x00003A2B
        public static ServerNotify DefaultInstance { get; } = new ServerNotify().MakeReadOnly();

        // Token: 0x170000FD RID: 253
        // (get) Token: 0x06000256 RID: 598 RVA: 0x00005832 File Offset: 0x00003A32
        public override ServerNotify DefaultInstanceForType => DefaultInstance;

        // Token: 0x170000FE RID: 254
        // (get) Token: 0x06000257 RID: 599 RVA: 0x00005839 File Offset: 0x00003A39
        protected override ServerNotify ThisMessage => this;

        // Token: 0x170000FF RID: 255
        // (get) Token: 0x06000258 RID: 600 RVA: 0x0000583C File Offset: 0x00003A3C
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_ServerNotify__Descriptor;

        // Token: 0x17000100 RID: 256
        // (get) Token: 0x06000259 RID: 601 RVA: 0x00005843 File Offset: 0x00003A43
        protected override FieldAccessorTable<ServerNotify, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_ServerNotify__FieldAccessorTable;

        // Token: 0x17000101 RID: 257
        // (get) Token: 0x0600025A RID: 602 RVA: 0x0000584A File Offset: 0x00003A4A
        public bool HasType { get; private set; }

        // Token: 0x17000102 RID: 258
        // (get) Token: 0x0600025B RID: 603 RVA: 0x00005852 File Offset: 0x00003A52
        public Types.NotifyType Type => type_;

        // Token: 0x17000103 RID: 259
        // (get) Token: 0x0600025C RID: 604 RVA: 0x0000585A File Offset: 0x00003A5A
        public bool HasInfo { get; private set; }

        // Token: 0x17000104 RID: 260
        // (get) Token: 0x0600025D RID: 605 RVA: 0x00005862 File Offset: 0x00003A62
        public string Info => info_;

        // Token: 0x17000105 RID: 261
        // (get) Token: 0x0600025E RID: 606 RVA: 0x0000586A File Offset: 0x00003A6A
        public bool HasExtradata { get; private set; }

        // Token: 0x17000106 RID: 262
        // (get) Token: 0x0600025F RID: 607 RVA: 0x00005872 File Offset: 0x00003A72
        public ByteString Extradata => extradata_;

        // Token: 0x17000107 RID: 263
        // (get) Token: 0x06000260 RID: 608 RVA: 0x0000587A File Offset: 0x00003A7A
        public bool HasSeqId { get; private set; }

        // Token: 0x17000108 RID: 264
        // (get) Token: 0x06000261 RID: 609 RVA: 0x00005882 File Offset: 0x00003A82
        public string SeqId => seqId_;

        // Token: 0x17000109 RID: 265
        // (get) Token: 0x06000262 RID: 610 RVA: 0x0000588A File Offset: 0x00003A8A
        public override bool IsInitialized => HasType;

        // Token: 0x06000263 RID: 611 RVA: 0x00005898 File Offset: 0x00003A98
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] serverNotifyFieldNames = _serverNotifyFieldNames;
			if (HasType)
			{
				output.WriteEnum(1, serverNotifyFieldNames[3], (int)Type, Type);
			}
			if (HasInfo)
			{
				output.WriteString(2, serverNotifyFieldNames[1], Info);
			}
			if (HasExtradata)
			{
				output.WriteBytes(3, serverNotifyFieldNames[0], Extradata);
			}
			if (HasSeqId)
			{
				output.WriteString(4, serverNotifyFieldNames[2], SeqId);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0000592C File Offset: 0x00003B2C
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
				if (HasType)
				{
					num += CodedOutputStream.ComputeEnumSize(1, (int)Type);
				}
				if (HasInfo)
				{
					num += CodedOutputStream.ComputeStringSize(2, Info);
				}
				if (HasExtradata)
				{
					num += CodedOutputStream.ComputeBytesSize(3, Extradata);
				}
				if (HasSeqId)
				{
					num += CodedOutputStream.ComputeStringSize(4, SeqId);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000059BA File Offset: 0x00003BBA
		public static ServerNotify ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000059CC File Offset: 0x00003BCC
		public static ServerNotify ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000059DF File Offset: 0x00003BDF
		public static ServerNotify ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000059F1 File Offset: 0x00003BF1
		public static ServerNotify ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00005A04 File Offset: 0x00003C04
		public static ServerNotify ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00005A16 File Offset: 0x00003C16
		public static ServerNotify ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00005A29 File Offset: 0x00003C29
		public static ServerNotify ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00005A3B File Offset: 0x00003C3B
		public static ServerNotify ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00005A4E File Offset: 0x00003C4E
		public static ServerNotify ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00005A60 File Offset: 0x00003C60
		public static ServerNotify ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00005A73 File Offset: 0x00003C73
		private ServerNotify MakeReadOnly()
		{
			return this;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00005A76 File Offset: 0x00003C76
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00005A7D File Offset: 0x00003C7D
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00005A85 File Offset: 0x00003C85
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00005A8C File Offset: 0x00003C8C
		public static Builder CreateBuilder(ServerNotify prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00005A94 File Offset: 0x00003C94
		static ServerNotify()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x04000151 RID: 337
        private static readonly string[] _serverNotifyFieldNames = new string[]
		{
			"extradata",
			"info",
			"seqId",
			"type"
		};

		// Token: 0x04000152 RID: 338
		private static readonly uint[] _serverNotifyFieldTags = new uint[]
		{
			26U,
			18U,
			34U,
			8U
		};

		// Token: 0x04000153 RID: 339
		public const int TypeFieldNumber = 1;

        // Token: 0x04000155 RID: 341
        private Types.NotifyType type_;

		// Token: 0x04000156 RID: 342
		public const int InfoFieldNumber = 2;

        // Token: 0x04000158 RID: 344
        private string info_ = "";

		// Token: 0x04000159 RID: 345
		public const int ExtradataFieldNumber = 3;

        // Token: 0x0400015B RID: 347
        private ByteString extradata_ = ByteString.Empty;

		// Token: 0x0400015C RID: 348
		public const int SeqIdFieldNumber = 4;

        // Token: 0x0400015E RID: 350
        private string seqId_ = "";

		// Token: 0x0400015F RID: 351
		private int memoizedSerializedSize = -1;

		// Token: 0x02000074 RID: 116
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02000095 RID: 149
			public enum NotifyType
			{
				// Token: 0x04000419 RID: 1049
				normal,
				// Token: 0x0400041A RID: 1050
				serverListChanged,
				// Token: 0x0400041B RID: 1051
				exception
			}
		}

		// Token: 0x02000075 RID: 117
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<ServerNotify, Builder>
		{
            // Token: 0x17000396 RID: 918
            // (get) Token: 0x06000914 RID: 2324 RVA: 0x00015B06 File Offset: 0x00013D06
            protected override Builder ThisBuilder => this;

            // Token: 0x06000915 RID: 2325 RVA: 0x00015B09 File Offset: 0x00013D09
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000916 RID: 2326 RVA: 0x00015B23 File Offset: 0x00013D23
			internal Builder(ServerNotify cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x06000917 RID: 2327 RVA: 0x00015B3C File Offset: 0x00013D3C
			private ServerNotify PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					ServerNotify other = result;
					result = new ServerNotify();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x17000397 RID: 919
            // (get) Token: 0x06000918 RID: 2328 RVA: 0x00015B78 File Offset: 0x00013D78
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x17000398 RID: 920
            // (get) Token: 0x06000919 RID: 2329 RVA: 0x00015B85 File Offset: 0x00013D85
            protected override ServerNotify MessageBeingBuilt => PrepareBuilder();

            // Token: 0x0600091A RID: 2330 RVA: 0x00015B8D File Offset: 0x00013D8D
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x0600091B RID: 2331 RVA: 0x00015BA2 File Offset: 0x00013DA2
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x17000399 RID: 921
            // (get) Token: 0x0600091C RID: 2332 RVA: 0x00015BC8 File Offset: 0x00013DC8
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x1700039A RID: 922
            // (get) Token: 0x0600091D RID: 2333 RVA: 0x00015BCF File Offset: 0x00013DCF
            public override ServerNotify DefaultInstanceForType => DefaultInstance;

            // Token: 0x0600091E RID: 2334 RVA: 0x00015BD6 File Offset: 0x00013DD6
            public override ServerNotify BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x0600091F RID: 2335 RVA: 0x00015BF9 File Offset: 0x00013DF9
			public override Builder MergeFrom(IMessage other)
			{
				if (other is ServerNotify)
				{
					return MergeFrom((ServerNotify)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000920 RID: 2336 RVA: 0x00015C1C File Offset: 0x00013E1C
			public override Builder MergeFrom(ServerNotify other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasType)
				{
					Type = other.Type;
				}
				if (other.HasInfo)
				{
					Info = other.Info;
				}
				if (other.HasExtradata)
				{
					Extradata = other.Extradata;
				}
				if (other.HasSeqId)
				{
					SeqId = other.SeqId;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000921 RID: 2337 RVA: 0x00015C98 File Offset: 0x00013E98
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000922 RID: 2338 RVA: 0x00015CA8 File Offset: 0x00013EA8
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_serverNotifyFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _serverNotifyFieldTags[num2];
                    }
                    if (num <= 8U)
                    {
                        if (num == 0U)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 8U)
                        {
                            if (input.ReadEnum(ref result.type_, out object obj))
                            {
                                result.HasType = true;
                                continue;
                            }
                            if (obj is int)
                            {
                                if (builder == null)
                                {
                                    builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                                }
                                builder.MergeVarintField(1, (ulong)((long)((int)obj)));
                                continue;
                            }
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 18U)
                        {
                            result.HasInfo = input.ReadString(ref result.info_);
                            continue;
                        }
                        if (num == 26U)
                        {
                            result.HasExtradata = input.ReadBytes(ref result.extradata_);
                            continue;
                        }
                        if (num == 34U)
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

            // Token: 0x1700039B RID: 923
            // (get) Token: 0x06000923 RID: 2339 RVA: 0x00015E35 File Offset: 0x00014035
            public bool HasType => result.HasType;

            // Token: 0x1700039C RID: 924
            // (get) Token: 0x06000924 RID: 2340 RVA: 0x00015E42 File Offset: 0x00014042
            // (set) Token: 0x06000925 RID: 2341 RVA: 0x00015E4F File Offset: 0x0001404F
            public Types.NotifyType Type
			{
				get
				{
					return result.Type;
				}
				set
				{
					SetType(value);
				}
			}

			// Token: 0x06000926 RID: 2342 RVA: 0x00015E59 File Offset: 0x00014059
			public Builder SetType(Types.NotifyType value)
			{
				PrepareBuilder();
				result.HasType = true;
				result.type_ = value;
				return this;
			}

			// Token: 0x06000927 RID: 2343 RVA: 0x00015E7B File Offset: 0x0001407B
			public Builder ClearType()
			{
				PrepareBuilder();
				result.HasType = false;
				result.type_ = Types.NotifyType.normal;
				return this;
			}

            // Token: 0x1700039D RID: 925
            // (get) Token: 0x06000928 RID: 2344 RVA: 0x00015E9D File Offset: 0x0001409D
            public bool HasInfo => result.HasInfo;

            // Token: 0x1700039E RID: 926
            // (get) Token: 0x06000929 RID: 2345 RVA: 0x00015EAA File Offset: 0x000140AA
            // (set) Token: 0x0600092A RID: 2346 RVA: 0x00015EB7 File Offset: 0x000140B7
            public string Info
			{
				get
				{
					return result.Info;
				}
				set
				{
					SetInfo(value);
				}
			}

			// Token: 0x0600092B RID: 2347 RVA: 0x00015EC1 File Offset: 0x000140C1
			public Builder SetInfo(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasInfo = true;
				result.info_ = value;
				return this;
			}

			// Token: 0x0600092C RID: 2348 RVA: 0x00015EEE File Offset: 0x000140EE
			public Builder ClearInfo()
			{
				PrepareBuilder();
				result.HasInfo = false;
				result.info_ = "";
				return this;
			}

            // Token: 0x1700039F RID: 927
            // (get) Token: 0x0600092D RID: 2349 RVA: 0x00015F14 File Offset: 0x00014114
            public bool HasExtradata => result.HasExtradata;

            // Token: 0x170003A0 RID: 928
            // (get) Token: 0x0600092E RID: 2350 RVA: 0x00015F21 File Offset: 0x00014121
            // (set) Token: 0x0600092F RID: 2351 RVA: 0x00015F2E File Offset: 0x0001412E
            public ByteString Extradata
			{
				get
				{
					return result.Extradata;
				}
				set
				{
					SetExtradata(value);
				}
			}

			// Token: 0x06000930 RID: 2352 RVA: 0x00015F38 File Offset: 0x00014138
			public Builder SetExtradata(ByteString value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasExtradata = true;
				result.extradata_ = value;
				return this;
			}

			// Token: 0x06000931 RID: 2353 RVA: 0x00015F65 File Offset: 0x00014165
			public Builder ClearExtradata()
			{
				PrepareBuilder();
				result.HasExtradata = false;
				result.extradata_ = ByteString.Empty;
				return this;
			}

            // Token: 0x170003A1 RID: 929
            // (get) Token: 0x06000932 RID: 2354 RVA: 0x00015F8B File Offset: 0x0001418B
            public bool HasSeqId => result.HasSeqId;

            // Token: 0x170003A2 RID: 930
            // (get) Token: 0x06000933 RID: 2355 RVA: 0x00015F98 File Offset: 0x00014198
            // (set) Token: 0x06000934 RID: 2356 RVA: 0x00015FA5 File Offset: 0x000141A5
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

			// Token: 0x06000935 RID: 2357 RVA: 0x00015FAF File Offset: 0x000141AF
			public Builder SetSeqId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSeqId = true;
				result.seqId_ = value;
				return this;
			}

			// Token: 0x06000936 RID: 2358 RVA: 0x00015FDC File Offset: 0x000141DC
			public Builder ClearSeqId()
			{
				PrepareBuilder();
				result.HasSeqId = false;
				result.seqId_ = "";
				return this;
			}

			// Token: 0x040003D9 RID: 985
			private bool resultIsReadOnly;

			// Token: 0x040003DA RID: 986
			private ServerNotify result;
		}
	}
}
