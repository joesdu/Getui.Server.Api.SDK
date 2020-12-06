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
    // Token: 0x02000012 RID: 18
    [DebuggerNonUserCode]
	public sealed class SingleBatchRequest : GeneratedMessage<SingleBatchRequest, SingleBatchRequest.Builder>
	{
		// Token: 0x06000176 RID: 374 RVA: 0x000042BE File Offset: 0x000024BE
		private SingleBatchRequest()
		{
		}

        // Token: 0x170000A1 RID: 161
        // (get) Token: 0x06000177 RID: 375 RVA: 0x000042E3 File Offset: 0x000024E3
        public static SingleBatchRequest DefaultInstance { get; } = new SingleBatchRequest().MakeReadOnly();

        // Token: 0x170000A2 RID: 162
        // (get) Token: 0x06000178 RID: 376 RVA: 0x000042EA File Offset: 0x000024EA
        public override SingleBatchRequest DefaultInstanceForType => DefaultInstance;

        // Token: 0x170000A3 RID: 163
        // (get) Token: 0x06000179 RID: 377 RVA: 0x000042F1 File Offset: 0x000024F1
        protected override SingleBatchRequest ThisMessage => this;

        // Token: 0x170000A4 RID: 164
        // (get) Token: 0x0600017A RID: 378 RVA: 0x000042F4 File Offset: 0x000024F4
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_SingleBatchRequest__Descriptor;

        // Token: 0x170000A5 RID: 165
        // (get) Token: 0x0600017B RID: 379 RVA: 0x000042FB File Offset: 0x000024FB
        protected override FieldAccessorTable<SingleBatchRequest, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_SingleBatchRequest__FieldAccessorTable;

        // Token: 0x170000A6 RID: 166
        // (get) Token: 0x0600017C RID: 380 RVA: 0x00004302 File Offset: 0x00002502
        public bool HasBatchId { get; private set; }

        // Token: 0x170000A7 RID: 167
        // (get) Token: 0x0600017D RID: 381 RVA: 0x0000430A File Offset: 0x0000250A
        public string BatchId => batchId_;

        // Token: 0x170000A8 RID: 168
        // (get) Token: 0x0600017E RID: 382 RVA: 0x00004312 File Offset: 0x00002512
        public IList<SingleBatchItem> BatchItemList => batchItem_;

        // Token: 0x170000A9 RID: 169
        // (get) Token: 0x0600017F RID: 383 RVA: 0x0000431A File Offset: 0x0000251A
        public int BatchItemCount => batchItem_.Count;

        // Token: 0x06000180 RID: 384 RVA: 0x00004327 File Offset: 0x00002527
        public SingleBatchItem GetBatchItem(int index)
		{
			return batchItem_[index];
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00004338 File Offset: 0x00002538
		public override bool IsInitialized
		{
			get
			{
				if (!HasBatchId)
				{
					return false;
				}
				using (IEnumerator<SingleBatchItem> enumerator = BatchItemList.GetEnumerator())
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

		// Token: 0x06000182 RID: 386 RVA: 0x00004398 File Offset: 0x00002598
		public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] singleBatchRequestFieldNames = _singleBatchRequestFieldNames;
			if (HasBatchId)
			{
				output.WriteString(1, singleBatchRequestFieldNames[0], BatchId);
			}
			if (batchItem_.Count > 0)
			{
				output.WriteMessageArray(2, singleBatchRequestFieldNames[1], batchItem_);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000183 RID: 387 RVA: 0x000043F4 File Offset: 0x000025F4
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
				foreach (SingleBatchItem value in BatchItemList)
				{
					num += CodedOutputStream.ComputeMessageSize(2, value);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00004480 File Offset: 0x00002680
		public static SingleBatchRequest ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00004492 File Offset: 0x00002692
		public static SingleBatchRequest ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000044A5 File Offset: 0x000026A5
		public static SingleBatchRequest ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000187 RID: 391 RVA: 0x000044B7 File Offset: 0x000026B7
		public static SingleBatchRequest ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000188 RID: 392 RVA: 0x000044CA File Offset: 0x000026CA
		public static SingleBatchRequest ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x000044DC File Offset: 0x000026DC
		public static SingleBatchRequest ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600018A RID: 394 RVA: 0x000044EF File Offset: 0x000026EF
		public static SingleBatchRequest ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00004501 File Offset: 0x00002701
		public static SingleBatchRequest ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00004514 File Offset: 0x00002714
		public static SingleBatchRequest ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00004526 File Offset: 0x00002726
		public static SingleBatchRequest ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00004539 File Offset: 0x00002739
		private SingleBatchRequest MakeReadOnly()
		{
			batchItem_.MakeReadOnly();
			return this;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00004547 File Offset: 0x00002747
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000454E File Offset: 0x0000274E
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00004556 File Offset: 0x00002756
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000455D File Offset: 0x0000275D
		public static Builder CreateBuilder(SingleBatchRequest prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00004568 File Offset: 0x00002768
		static SingleBatchRequest()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x040000FB RID: 251
        private static readonly string[] _singleBatchRequestFieldNames = new string[]
		{
			"batchId",
			"batchItem"
		};

		// Token: 0x040000FC RID: 252
		private static readonly uint[] _singleBatchRequestFieldTags = new uint[]
		{
			10U,
			18U
		};

		// Token: 0x040000FD RID: 253
		public const int BatchIdFieldNumber = 1;

        // Token: 0x040000FF RID: 255
        private string batchId_ = "";

		// Token: 0x04000100 RID: 256
		public const int BatchItemFieldNumber = 2;

		// Token: 0x04000101 RID: 257
		private PopsicleList<SingleBatchItem> batchItem_ = new PopsicleList<SingleBatchItem>();

		// Token: 0x04000102 RID: 258
		private int memoizedSerializedSize = -1;

		// Token: 0x0200006D RID: 109
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<SingleBatchRequest, Builder>
		{
            // Token: 0x17000349 RID: 841
            // (get) Token: 0x06000832 RID: 2098 RVA: 0x00013BA3 File Offset: 0x00011DA3
            protected override Builder ThisBuilder => this;

            // Token: 0x06000833 RID: 2099 RVA: 0x00013BA6 File Offset: 0x00011DA6
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000834 RID: 2100 RVA: 0x00013BC0 File Offset: 0x00011DC0
			internal Builder(SingleBatchRequest cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x06000835 RID: 2101 RVA: 0x00013BD8 File Offset: 0x00011DD8
			private SingleBatchRequest PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					SingleBatchRequest other = result;
					result = new SingleBatchRequest();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x1700034A RID: 842
            // (get) Token: 0x06000836 RID: 2102 RVA: 0x00013C14 File Offset: 0x00011E14
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x1700034B RID: 843
            // (get) Token: 0x06000837 RID: 2103 RVA: 0x00013C21 File Offset: 0x00011E21
            protected override SingleBatchRequest MessageBeingBuilt => PrepareBuilder();

            // Token: 0x06000838 RID: 2104 RVA: 0x00013C29 File Offset: 0x00011E29
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x06000839 RID: 2105 RVA: 0x00013C3E File Offset: 0x00011E3E
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x1700034C RID: 844
            // (get) Token: 0x0600083A RID: 2106 RVA: 0x00013C64 File Offset: 0x00011E64
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x1700034D RID: 845
            // (get) Token: 0x0600083B RID: 2107 RVA: 0x00013C6B File Offset: 0x00011E6B
            public override SingleBatchRequest DefaultInstanceForType => DefaultInstance;

            // Token: 0x0600083C RID: 2108 RVA: 0x00013C72 File Offset: 0x00011E72
            public override SingleBatchRequest BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x0600083D RID: 2109 RVA: 0x00013C95 File Offset: 0x00011E95
			public override Builder MergeFrom(IMessage other)
			{
				if (other is SingleBatchRequest)
				{
					return MergeFrom((SingleBatchRequest)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x0600083E RID: 2110 RVA: 0x00013CB8 File Offset: 0x00011EB8
			public override Builder MergeFrom(SingleBatchRequest other)
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
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x0600083F RID: 2111 RVA: 0x00013D1B File Offset: 0x00011F1B
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000840 RID: 2112 RVA: 0x00013D2C File Offset: 0x00011F2C
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_singleBatchRequestFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _singleBatchRequestFieldTags[num2];
                    }
                    if (num == 0U)
                    {
                        throw InvalidProtocolBufferException.InvalidTag();
                    }
                    if (num != 10U)
                    {
                        if (num != 18U)
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
                            input.ReadMessageArray(num, text, result.batchItem_, SingleBatchItem.DefaultInstance, extensionRegistry);
                        }
                    }
                    else
                    {
                        result.HasBatchId = input.ReadString(ref result.batchId_);
                    }
                }
                if (builder != null)
				{
					UnknownFields = builder.Build();
				}
				return this;
			}

            // Token: 0x1700034E RID: 846
            // (get) Token: 0x06000841 RID: 2113 RVA: 0x00013E2D File Offset: 0x0001202D
            public bool HasBatchId => result.HasBatchId;

            // Token: 0x1700034F RID: 847
            // (get) Token: 0x06000842 RID: 2114 RVA: 0x00013E3A File Offset: 0x0001203A
            // (set) Token: 0x06000843 RID: 2115 RVA: 0x00013E47 File Offset: 0x00012047
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

			// Token: 0x06000844 RID: 2116 RVA: 0x00013E51 File Offset: 0x00012051
			public Builder SetBatchId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasBatchId = true;
				result.batchId_ = value;
				return this;
			}

			// Token: 0x06000845 RID: 2117 RVA: 0x00013E7E File Offset: 0x0001207E
			public Builder ClearBatchId()
			{
				PrepareBuilder();
				result.HasBatchId = false;
				result.batchId_ = "";
				return this;
			}

            // Token: 0x17000350 RID: 848
            // (get) Token: 0x06000846 RID: 2118 RVA: 0x00013EA4 File Offset: 0x000120A4
            public IPopsicleList<SingleBatchItem> BatchItemList => PrepareBuilder().batchItem_;

            // Token: 0x17000351 RID: 849
            // (get) Token: 0x06000847 RID: 2119 RVA: 0x00013EB1 File Offset: 0x000120B1
            public int BatchItemCount => result.BatchItemCount;

            // Token: 0x06000848 RID: 2120 RVA: 0x00013EBE File Offset: 0x000120BE
            public SingleBatchItem GetBatchItem(int index)
			{
				return result.GetBatchItem(index);
			}

			// Token: 0x06000849 RID: 2121 RVA: 0x00013ECC File Offset: 0x000120CC
			public Builder SetBatchItem(int index, SingleBatchItem value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.batchItem_[index] = value;
				return this;
			}

			// Token: 0x0600084A RID: 2122 RVA: 0x00013EF3 File Offset: 0x000120F3
			public Builder SetBatchItem(int index, SingleBatchItem.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.batchItem_[index] = builderForValue.Build();
				return this;
			}

			// Token: 0x0600084B RID: 2123 RVA: 0x00013F1F File Offset: 0x0001211F
			public Builder AddBatchItem(SingleBatchItem value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.batchItem_.Add(value);
				return this;
			}

			// Token: 0x0600084C RID: 2124 RVA: 0x00013F45 File Offset: 0x00012145
			public Builder AddBatchItem(SingleBatchItem.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.batchItem_.Add(builderForValue.Build());
				return this;
			}

			// Token: 0x0600084D RID: 2125 RVA: 0x00013F70 File Offset: 0x00012170
			public Builder AddRangeBatchItem(IEnumerable<SingleBatchItem> values)
			{
				PrepareBuilder();
				result.batchItem_.Add(values);
				return this;
			}

			// Token: 0x0600084E RID: 2126 RVA: 0x00013F8B File Offset: 0x0001218B
			public Builder ClearBatchItem()
			{
				PrepareBuilder();
				result.batchItem_.Clear();
				return this;
			}

			// Token: 0x040003CB RID: 971
			private bool resultIsReadOnly;

			// Token: 0x040003CC RID: 972
			private SingleBatchRequest result;
		}
	}
}
