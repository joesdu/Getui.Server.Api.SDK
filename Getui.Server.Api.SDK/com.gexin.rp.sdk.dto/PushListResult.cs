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
    // Token: 0x0200000B RID: 11
    [DebuggerNonUserCode]
	public sealed class PushListResult : GeneratedMessage<PushListResult, PushListResult.Builder>
	{
		// Token: 0x06000093 RID: 147 RVA: 0x00002CEB File Offset: 0x00000EEB
		private PushListResult()
		{
		}

        // Token: 0x1700003E RID: 62
        // (get) Token: 0x06000094 RID: 148 RVA: 0x00002D05 File Offset: 0x00000F05
        public static PushListResult DefaultInstance { get; } = new PushListResult().MakeReadOnly();

        // Token: 0x1700003F RID: 63
        // (get) Token: 0x06000095 RID: 149 RVA: 0x00002D0C File Offset: 0x00000F0C
        public override PushListResult DefaultInstanceForType => DefaultInstance;

        // Token: 0x17000040 RID: 64
        // (get) Token: 0x06000096 RID: 150 RVA: 0x00002D13 File Offset: 0x00000F13
        protected override PushListResult ThisMessage => this;

        // Token: 0x17000041 RID: 65
        // (get) Token: 0x06000097 RID: 151 RVA: 0x00002D16 File Offset: 0x00000F16
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_PushListResult__Descriptor;

        // Token: 0x17000042 RID: 66
        // (get) Token: 0x06000098 RID: 152 RVA: 0x00002D1D File Offset: 0x00000F1D
        protected override FieldAccessorTable<PushListResult, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_PushListResult__FieldAccessorTable;

        // Token: 0x17000043 RID: 67
        // (get) Token: 0x06000099 RID: 153 RVA: 0x00002D24 File Offset: 0x00000F24
        public IList<PushResult> ResultsList => results_;

        // Token: 0x17000044 RID: 68
        // (get) Token: 0x0600009A RID: 154 RVA: 0x00002D2C File Offset: 0x00000F2C
        public int ResultsCount => results_.Count;

        // Token: 0x0600009B RID: 155 RVA: 0x00002D39 File Offset: 0x00000F39
        public PushResult GetResults(int index)
		{
			return results_[index];
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002D48 File Offset: 0x00000F48
		public override bool IsInitialized
		{
			get
			{
				using (IEnumerator<PushResult> enumerator = ResultsList.GetEnumerator())
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

		// Token: 0x0600009D RID: 157 RVA: 0x00002D9C File Offset: 0x00000F9C
		public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] pushListResultFieldNames = _pushListResultFieldNames;
			if (results_.Count > 0)
			{
				output.WriteMessageArray(1, pushListResultFieldNames[0], results_);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00002DE0 File Offset: 0x00000FE0
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
				foreach (PushResult value in ResultsList)
				{
					num += CodedOutputStream.ComputeMessageSize(1, value);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002E58 File Offset: 0x00001058
		public static PushListResult ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002E6A File Offset: 0x0000106A
		public static PushListResult ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002E7D File Offset: 0x0000107D
		public static PushListResult ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002E8F File Offset: 0x0000108F
		public static PushListResult ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002EA2 File Offset: 0x000010A2
		public static PushListResult ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002EB4 File Offset: 0x000010B4
		public static PushListResult ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002EC7 File Offset: 0x000010C7
		public static PushListResult ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002ED9 File Offset: 0x000010D9
		public static PushListResult ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002EEC File Offset: 0x000010EC
		public static PushListResult ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002EFE File Offset: 0x000010FE
		public static PushListResult ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002F11 File Offset: 0x00001111
		private PushListResult MakeReadOnly()
		{
			results_.MakeReadOnly();
			return this;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002F1F File Offset: 0x0000111F
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002F26 File Offset: 0x00001126
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002F2E File Offset: 0x0000112E
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002F35 File Offset: 0x00001135
		public static Builder CreateBuilder(PushListResult prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002F3D File Offset: 0x0000113D
		static PushListResult()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x04000096 RID: 150
        private static readonly string[] _pushListResultFieldNames = new string[]
		{
			"results"
		};

		// Token: 0x04000097 RID: 151
		private static readonly uint[] _pushListResultFieldTags = new uint[]
		{
			10U
		};

		// Token: 0x04000098 RID: 152
		public const int ResultsFieldNumber = 1;

		// Token: 0x04000099 RID: 153
		private PopsicleList<PushResult> results_ = new PopsicleList<PushResult>();

		// Token: 0x0400009A RID: 154
		private int memoizedSerializedSize = -1;

		// Token: 0x02000065 RID: 101
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<PushListResult, Builder>
		{
            // Token: 0x170002F4 RID: 756
            // (get) Token: 0x06000738 RID: 1848 RVA: 0x000115F0 File Offset: 0x0000F7F0
            protected override Builder ThisBuilder => this;

            // Token: 0x06000739 RID: 1849 RVA: 0x000115F3 File Offset: 0x0000F7F3
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x0600073A RID: 1850 RVA: 0x0001160D File Offset: 0x0000F80D
			internal Builder(PushListResult cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x0600073B RID: 1851 RVA: 0x00011624 File Offset: 0x0000F824
			private PushListResult PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					PushListResult other = result;
					result = new PushListResult();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x170002F5 RID: 757
            // (get) Token: 0x0600073C RID: 1852 RVA: 0x00011660 File Offset: 0x0000F860
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x170002F6 RID: 758
            // (get) Token: 0x0600073D RID: 1853 RVA: 0x0001166D File Offset: 0x0000F86D
            protected override PushListResult MessageBeingBuilt => PrepareBuilder();

            // Token: 0x0600073E RID: 1854 RVA: 0x00011675 File Offset: 0x0000F875
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x0600073F RID: 1855 RVA: 0x0001168A File Offset: 0x0000F88A
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x170002F7 RID: 759
            // (get) Token: 0x06000740 RID: 1856 RVA: 0x000116B0 File Offset: 0x0000F8B0
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x170002F8 RID: 760
            // (get) Token: 0x06000741 RID: 1857 RVA: 0x000116B7 File Offset: 0x0000F8B7
            public override PushListResult DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000742 RID: 1858 RVA: 0x000116BE File Offset: 0x0000F8BE
            public override PushListResult BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x06000743 RID: 1859 RVA: 0x000116E1 File Offset: 0x0000F8E1
			public override Builder MergeFrom(IMessage other)
			{
				if (other is PushListResult)
				{
					return MergeFrom((PushListResult)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000744 RID: 1860 RVA: 0x00011704 File Offset: 0x0000F904
			public override Builder MergeFrom(PushListResult other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.results_.Count != 0)
				{
					result.results_.Add(other.results_);
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000745 RID: 1861 RVA: 0x00011753 File Offset: 0x0000F953
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000746 RID: 1862 RVA: 0x00011764 File Offset: 0x0000F964
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_pushListResultFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _pushListResultFieldTags[num2];
                    }
                    if (num == 0U)
                    {
                        throw InvalidProtocolBufferException.InvalidTag();
                    }
                    if (num != 10U)
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
                        input.ReadMessageArray(num, text, result.results_, PushResult.DefaultInstance, extensionRegistry);
                    }
                }
                if (builder != null)
				{
					UnknownFields = builder.Build();
				}
				return this;
			}

            // Token: 0x170002F9 RID: 761
            // (get) Token: 0x06000747 RID: 1863 RVA: 0x0001183F File Offset: 0x0000FA3F
            public IPopsicleList<PushResult> ResultsList => PrepareBuilder().results_;

            // Token: 0x170002FA RID: 762
            // (get) Token: 0x06000748 RID: 1864 RVA: 0x0001184C File Offset: 0x0000FA4C
            public int ResultsCount => result.ResultsCount;

            // Token: 0x06000749 RID: 1865 RVA: 0x00011859 File Offset: 0x0000FA59
            public PushResult GetResults(int index)
			{
				return result.GetResults(index);
			}

			// Token: 0x0600074A RID: 1866 RVA: 0x00011867 File Offset: 0x0000FA67
			public Builder SetResults(int index, PushResult value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.results_[index] = value;
				return this;
			}

			// Token: 0x0600074B RID: 1867 RVA: 0x0001188E File Offset: 0x0000FA8E
			public Builder SetResults(int index, PushResult.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.results_[index] = builderForValue.Build();
				return this;
			}

			// Token: 0x0600074C RID: 1868 RVA: 0x000118BA File Offset: 0x0000FABA
			public Builder AddResults(PushResult value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.results_.Add(value);
				return this;
			}

			// Token: 0x0600074D RID: 1869 RVA: 0x000118E0 File Offset: 0x0000FAE0
			public Builder AddResults(PushResult.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.results_.Add(builderForValue.Build());
				return this;
			}

			// Token: 0x0600074E RID: 1870 RVA: 0x0001190B File Offset: 0x0000FB0B
			public Builder AddRangeResults(IEnumerable<PushResult> values)
			{
				PrepareBuilder();
				result.results_.Add(values);
				return this;
			}

			// Token: 0x0600074F RID: 1871 RVA: 0x00011926 File Offset: 0x0000FB26
			public Builder ClearResults()
			{
				PrepareBuilder();
				result.results_.Clear();
				return this;
			}

			// Token: 0x040003BD RID: 957
			private bool resultIsReadOnly;

			// Token: 0x040003BE RID: 958
			private PushListResult result;
		}
	}
}
