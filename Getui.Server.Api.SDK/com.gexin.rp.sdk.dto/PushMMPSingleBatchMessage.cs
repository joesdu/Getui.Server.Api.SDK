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
    // Token: 0x0200000F RID: 15
    [DebuggerNonUserCode]
	public sealed class PushMMPSingleBatchMessage : GeneratedMessage<PushMMPSingleBatchMessage, PushMMPSingleBatchMessage.Builder>
	{
		// Token: 0x06000118 RID: 280 RVA: 0x000039F3 File Offset: 0x00001BF3
		private PushMMPSingleBatchMessage()
		{
		}

        // Token: 0x1700007A RID: 122
        // (get) Token: 0x06000119 RID: 281 RVA: 0x00003A1F File Offset: 0x00001C1F
        public static PushMMPSingleBatchMessage DefaultInstance { get; } = new PushMMPSingleBatchMessage().MakeReadOnly();

        // Token: 0x1700007B RID: 123
        // (get) Token: 0x0600011A RID: 282 RVA: 0x00003A26 File Offset: 0x00001C26
        public override PushMMPSingleBatchMessage DefaultInstanceForType => DefaultInstance;

        // Token: 0x1700007C RID: 124
        // (get) Token: 0x0600011B RID: 283 RVA: 0x00003A2D File Offset: 0x00001C2D
        protected override PushMMPSingleBatchMessage ThisMessage => this;

        // Token: 0x1700007D RID: 125
        // (get) Token: 0x0600011C RID: 284 RVA: 0x00003A30 File Offset: 0x00001C30
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPSingleBatchMessage__Descriptor;

        // Token: 0x1700007E RID: 126
        // (get) Token: 0x0600011D RID: 285 RVA: 0x00003A37 File Offset: 0x00001C37
        protected override FieldAccessorTable<PushMMPSingleBatchMessage, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPSingleBatchMessage__FieldAccessorTable;

        // Token: 0x1700007F RID: 127
        // (get) Token: 0x0600011E RID: 286 RVA: 0x00003A3E File Offset: 0x00001C3E
        public bool HasBatchId { get; private set; }

        // Token: 0x17000080 RID: 128
        // (get) Token: 0x0600011F RID: 287 RVA: 0x00003A46 File Offset: 0x00001C46
        public string BatchId => batchId_;

        // Token: 0x17000081 RID: 129
        // (get) Token: 0x06000120 RID: 288 RVA: 0x00003A4E File Offset: 0x00001C4E
        public IList<PushMMPSingleMessage> BatchItemList => batchItem_;

        // Token: 0x17000082 RID: 130
        // (get) Token: 0x06000121 RID: 289 RVA: 0x00003A56 File Offset: 0x00001C56
        public int BatchItemCount => batchItem_.Count;

        // Token: 0x06000122 RID: 290 RVA: 0x00003A63 File Offset: 0x00001C63
        public PushMMPSingleMessage GetBatchItem(int index)
		{
			return batchItem_[index];
		}

        // Token: 0x17000083 RID: 131
        // (get) Token: 0x06000123 RID: 291 RVA: 0x00003A71 File Offset: 0x00001C71
        public bool HasIsSync { get; private set; }

        // Token: 0x17000084 RID: 132
        // (get) Token: 0x06000124 RID: 292 RVA: 0x00003A79 File Offset: 0x00001C79
        public bool IsSync => isSync_;

        // Token: 0x17000085 RID: 133
        // (get) Token: 0x06000125 RID: 293 RVA: 0x00003A84 File Offset: 0x00001C84
        public override bool IsInitialized
		{
			get
			{
				if (!HasBatchId)
				{
					return false;
				}
				using (IEnumerator<PushMMPSingleMessage> enumerator = BatchItemList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (!enumerator.Current.IsInitialized)
						{
							return false;
						}
					}
				}
				return true;
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00003AE4 File Offset: 0x00001CE4
		public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] pushMMPSingleBatchMessageFieldNames = _pushMMPSingleBatchMessageFieldNames;
			if (HasBatchId)
			{
				output.WriteString(1, pushMMPSingleBatchMessageFieldNames[0], BatchId);
			}
			if (batchItem_.Count > 0)
			{
				output.WriteMessageArray(2, pushMMPSingleBatchMessageFieldNames[1], batchItem_);
			}
			if (HasIsSync)
			{
				output.WriteBool(3, pushMMPSingleBatchMessageFieldNames[2], IsSync);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00003B58 File Offset: 0x00001D58
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
				if (HasBatchId)
				{
					num += CodedOutputStream.ComputeStringSize(1, BatchId);
				}
				foreach (PushMMPSingleMessage value in BatchItemList)
				{
					num += CodedOutputStream.ComputeMessageSize(2, value);
				}
				if (HasIsSync)
				{
					num += CodedOutputStream.ComputeBoolSize(3, IsSync);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00003BFC File Offset: 0x00001DFC
		public static PushMMPSingleBatchMessage ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00003C0E File Offset: 0x00001E0E
		public static PushMMPSingleBatchMessage ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00003C21 File Offset: 0x00001E21
		public static PushMMPSingleBatchMessage ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00003C33 File Offset: 0x00001E33
		public static PushMMPSingleBatchMessage ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00003C46 File Offset: 0x00001E46
		public static PushMMPSingleBatchMessage ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00003C58 File Offset: 0x00001E58
		public static PushMMPSingleBatchMessage ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00003C6B File Offset: 0x00001E6B
		public static PushMMPSingleBatchMessage ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00003C7D File Offset: 0x00001E7D
		public static PushMMPSingleBatchMessage ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00003C90 File Offset: 0x00001E90
		public static PushMMPSingleBatchMessage ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00003CA2 File Offset: 0x00001EA2
		public static PushMMPSingleBatchMessage ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00003CB5 File Offset: 0x00001EB5
		private PushMMPSingleBatchMessage MakeReadOnly()
		{
			batchItem_.MakeReadOnly();
			return this;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00003CC3 File Offset: 0x00001EC3
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00003CCA File Offset: 0x00001ECA
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00003CD2 File Offset: 0x00001ED2
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00003CD9 File Offset: 0x00001ED9
		public static Builder CreateBuilder(PushMMPSingleBatchMessage prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00003CE4 File Offset: 0x00001EE4
		static PushMMPSingleBatchMessage()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x040000D5 RID: 213
        private static readonly string[] _pushMMPSingleBatchMessageFieldNames = new string[]
		{
			"batchId",
			"batchItem",
			"isSync"
		};

		// Token: 0x040000D6 RID: 214
		private static readonly uint[] _pushMMPSingleBatchMessageFieldTags = new uint[]
		{
			10U,
			18U,
			24U
		};

		// Token: 0x040000D7 RID: 215
		public const int BatchIdFieldNumber = 1;

        // Token: 0x040000D9 RID: 217
        private string batchId_ = "";

		// Token: 0x040000DA RID: 218
		public const int BatchItemFieldNumber = 2;

		// Token: 0x040000DB RID: 219
		private PopsicleList<PushMMPSingleMessage> batchItem_ = new PopsicleList<PushMMPSingleMessage>();

		// Token: 0x040000DC RID: 220
		public const int IsSyncFieldNumber = 3;

        // Token: 0x040000DE RID: 222
        private bool isSync_ = true;

		// Token: 0x040000DF RID: 223
		private int memoizedSerializedSize = -1;

		// Token: 0x0200006A RID: 106
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<PushMMPSingleBatchMessage, Builder>
		{
            // Token: 0x17000328 RID: 808
            // (get) Token: 0x060007D0 RID: 2000 RVA: 0x00012D40 File Offset: 0x00010F40
            protected override Builder ThisBuilder => this;

            // Token: 0x060007D1 RID: 2001 RVA: 0x00012D43 File Offset: 0x00010F43
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x060007D2 RID: 2002 RVA: 0x00012D5D File Offset: 0x00010F5D
			internal Builder(PushMMPSingleBatchMessage cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x060007D3 RID: 2003 RVA: 0x00012D74 File Offset: 0x00010F74
			private PushMMPSingleBatchMessage PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					PushMMPSingleBatchMessage other = result;
					result = new PushMMPSingleBatchMessage();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x17000329 RID: 809
            // (get) Token: 0x060007D4 RID: 2004 RVA: 0x00012DB0 File Offset: 0x00010FB0
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x1700032A RID: 810
            // (get) Token: 0x060007D5 RID: 2005 RVA: 0x00012DBD File Offset: 0x00010FBD
            protected override PushMMPSingleBatchMessage MessageBeingBuilt => PrepareBuilder();

            // Token: 0x060007D6 RID: 2006 RVA: 0x00012DC5 File Offset: 0x00010FC5
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x060007D7 RID: 2007 RVA: 0x00012DDA File Offset: 0x00010FDA
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x1700032B RID: 811
            // (get) Token: 0x060007D8 RID: 2008 RVA: 0x00012E00 File Offset: 0x00011000
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x1700032C RID: 812
            // (get) Token: 0x060007D9 RID: 2009 RVA: 0x00012E07 File Offset: 0x00011007
            public override PushMMPSingleBatchMessage DefaultInstanceForType => DefaultInstance;

            // Token: 0x060007DA RID: 2010 RVA: 0x00012E0E File Offset: 0x0001100E
            public override PushMMPSingleBatchMessage BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x060007DB RID: 2011 RVA: 0x00012E31 File Offset: 0x00011031
			public override Builder MergeFrom(IMessage other)
			{
				if (other is PushMMPSingleBatchMessage)
				{
					return MergeFrom((PushMMPSingleBatchMessage)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x060007DC RID: 2012 RVA: 0x00012E54 File Offset: 0x00011054
			public override Builder MergeFrom(PushMMPSingleBatchMessage other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasBatchId)
				{
					BatchId = other.BatchId;
				}
				if (other.batchItem_.Count != 0)
				{
					result.batchItem_.Add(other.batchItem_);
				}
				if (other.HasIsSync)
				{
					IsSync = other.IsSync;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x060007DD RID: 2013 RVA: 0x00012ECB File Offset: 0x000110CB
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x060007DE RID: 2014 RVA: 0x00012EDC File Offset: 0x000110DC
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_pushMMPSingleBatchMessageFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _pushMMPSingleBatchMessageFieldTags[num2];
                    }
                    if (num <= 10U)
                    {
                        if (num == 0U)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10U)
                        {
                            result.HasBatchId = input.ReadString(ref result.batchId_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 18U)
                        {
                            input.ReadMessageArray(num, text, result.batchItem_, PushMMPSingleMessage.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        if (num == 24U)
                        {
                            result.HasIsSync = input.ReadBool(ref result.isSync_);
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

            // Token: 0x1700032D RID: 813
            // (get) Token: 0x060007DF RID: 2015 RVA: 0x00013007 File Offset: 0x00011207
            public bool HasBatchId => result.HasBatchId;

            // Token: 0x1700032E RID: 814
            // (get) Token: 0x060007E0 RID: 2016 RVA: 0x00013014 File Offset: 0x00011214
            // (set) Token: 0x060007E1 RID: 2017 RVA: 0x00013021 File Offset: 0x00011221
            public string BatchId
			{
				get
				{
					return result.BatchId;
				}
				set
				{
					SetBatchId(value);
				}
			}

			// Token: 0x060007E2 RID: 2018 RVA: 0x0001302B File Offset: 0x0001122B
			public Builder SetBatchId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasBatchId = true;
				result.batchId_ = value;
				return this;
			}

			// Token: 0x060007E3 RID: 2019 RVA: 0x00013058 File Offset: 0x00011258
			public Builder ClearBatchId()
			{
				PrepareBuilder();
				result.HasBatchId = false;
				result.batchId_ = "";
				return this;
			}

            // Token: 0x1700032F RID: 815
            // (get) Token: 0x060007E4 RID: 2020 RVA: 0x0001307E File Offset: 0x0001127E
            public IPopsicleList<PushMMPSingleMessage> BatchItemList => PrepareBuilder().batchItem_;

            // Token: 0x17000330 RID: 816
            // (get) Token: 0x060007E5 RID: 2021 RVA: 0x0001308B File Offset: 0x0001128B
            public int BatchItemCount => result.BatchItemCount;

            // Token: 0x060007E6 RID: 2022 RVA: 0x00013098 File Offset: 0x00011298
            public PushMMPSingleMessage GetBatchItem(int index)
			{
				return result.GetBatchItem(index);
			}

			// Token: 0x060007E7 RID: 2023 RVA: 0x000130A6 File Offset: 0x000112A6
			public Builder SetBatchItem(int index, PushMMPSingleMessage value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.batchItem_[index] = value;
				return this;
			}

			// Token: 0x060007E8 RID: 2024 RVA: 0x000130CD File Offset: 0x000112CD
			public Builder SetBatchItem(int index, PushMMPSingleMessage.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.batchItem_[index] = builderForValue.Build();
				return this;
			}

			// Token: 0x060007E9 RID: 2025 RVA: 0x000130F9 File Offset: 0x000112F9
			public Builder AddBatchItem(PushMMPSingleMessage value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.batchItem_.Add(value);
				return this;
			}

			// Token: 0x060007EA RID: 2026 RVA: 0x0001311F File Offset: 0x0001131F
			public Builder AddBatchItem(PushMMPSingleMessage.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.batchItem_.Add(builderForValue.Build());
				return this;
			}

			// Token: 0x060007EB RID: 2027 RVA: 0x0001314A File Offset: 0x0001134A
			public Builder AddRangeBatchItem(IEnumerable<PushMMPSingleMessage> values)
			{
				PrepareBuilder();
				result.batchItem_.Add(values);
				return this;
			}

			// Token: 0x060007EC RID: 2028 RVA: 0x00013165 File Offset: 0x00011365
			public Builder ClearBatchItem()
			{
				PrepareBuilder();
				result.batchItem_.Clear();
				return this;
			}

            // Token: 0x17000331 RID: 817
            // (get) Token: 0x060007ED RID: 2029 RVA: 0x0001317F File Offset: 0x0001137F
            public bool HasIsSync => result.HasIsSync;

            // Token: 0x17000332 RID: 818
            // (get) Token: 0x060007EE RID: 2030 RVA: 0x0001318C File Offset: 0x0001138C
            // (set) Token: 0x060007EF RID: 2031 RVA: 0x00013199 File Offset: 0x00011399
            public bool IsSync
			{
				get
				{
					return result.IsSync;
				}
				set
				{
					SetIsSync(value);
				}
			}

			// Token: 0x060007F0 RID: 2032 RVA: 0x000131A3 File Offset: 0x000113A3
			public Builder SetIsSync(bool value)
			{
				PrepareBuilder();
				result.HasIsSync = true;
				result.isSync_ = value;
				return this;
			}

			// Token: 0x060007F1 RID: 2033 RVA: 0x000131C5 File Offset: 0x000113C5
			public Builder ClearIsSync()
			{
				PrepareBuilder();
				result.HasIsSync = false;
				result.isSync_ = true;
				return this;
			}

			// Token: 0x040003C5 RID: 965
			private bool resultIsReadOnly;

			// Token: 0x040003C6 RID: 966
			private PushMMPSingleBatchMessage result;
		}
	}
}
