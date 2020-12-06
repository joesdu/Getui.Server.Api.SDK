using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000025 RID: 37
    [DebuggerNonUserCode]
	public sealed class SmsContentEntry : GeneratedMessage<SmsContentEntry, SmsContentEntry.Builder>
	{
		// Token: 0x06000460 RID: 1120 RVA: 0x0000929B File Offset: 0x0000749B
		private SmsContentEntry()
		{
		}

        // Token: 0x1700022C RID: 556
        // (get) Token: 0x06000461 RID: 1121 RVA: 0x000092C0 File Offset: 0x000074C0
        public static SmsContentEntry DefaultInstance { get; } = new SmsContentEntry().MakeReadOnly();

        // Token: 0x1700022D RID: 557
        // (get) Token: 0x06000462 RID: 1122 RVA: 0x000092C7 File Offset: 0x000074C7
        public override SmsContentEntry DefaultInstanceForType => DefaultInstance;

        // Token: 0x1700022E RID: 558
        // (get) Token: 0x06000463 RID: 1123 RVA: 0x000092CE File Offset: 0x000074CE
        protected override SmsContentEntry ThisMessage => this;

        // Token: 0x1700022F RID: 559
        // (get) Token: 0x06000464 RID: 1124 RVA: 0x000092D1 File Offset: 0x000074D1
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_SmsContentEntry__Descriptor;

        // Token: 0x17000230 RID: 560
        // (get) Token: 0x06000465 RID: 1125 RVA: 0x000092D8 File Offset: 0x000074D8
        protected override FieldAccessorTable<SmsContentEntry, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_SmsContentEntry__FieldAccessorTable;

        // Token: 0x17000231 RID: 561
        // (get) Token: 0x06000466 RID: 1126 RVA: 0x000092DF File Offset: 0x000074DF
        public bool HasKey { get; private set; }

        // Token: 0x17000232 RID: 562
        // (get) Token: 0x06000467 RID: 1127 RVA: 0x000092E7 File Offset: 0x000074E7
        public string Key => key_;

        // Token: 0x17000233 RID: 563
        // (get) Token: 0x06000468 RID: 1128 RVA: 0x000092EF File Offset: 0x000074EF
        public bool HasValue { get; private set; }

        // Token: 0x17000234 RID: 564
        // (get) Token: 0x06000469 RID: 1129 RVA: 0x000092F7 File Offset: 0x000074F7
        public string Value => value_;

        // Token: 0x17000235 RID: 565
        // (get) Token: 0x0600046A RID: 1130 RVA: 0x000092FF File Offset: 0x000074FF
        public override bool IsInitialized => HasKey && HasValue;

        // Token: 0x0600046B RID: 1131 RVA: 0x00009318 File Offset: 0x00007518
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] smsContentEntryFieldNames = _smsContentEntryFieldNames;
			if (HasKey)
			{
				output.WriteString(1, smsContentEntryFieldNames[0], Key);
			}
			if (HasValue)
			{
				output.WriteString(2, smsContentEntryFieldNames[1], Value);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00009370 File Offset: 0x00007570
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
				if (HasKey)
				{
					num += CodedOutputStream.ComputeStringSize(1, Key);
				}
				if (HasValue)
				{
					num += CodedOutputStream.ComputeStringSize(2, Value);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x000093D0 File Offset: 0x000075D0
		public static SmsContentEntry ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000093E2 File Offset: 0x000075E2
		public static SmsContentEntry ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000093F5 File Offset: 0x000075F5
		public static SmsContentEntry ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00009407 File Offset: 0x00007607
		public static SmsContentEntry ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0000941A File Offset: 0x0000761A
		public static SmsContentEntry ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0000942C File Offset: 0x0000762C
		public static SmsContentEntry ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x0000943F File Offset: 0x0000763F
		public static SmsContentEntry ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00009451 File Offset: 0x00007651
		public static SmsContentEntry ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00009464 File Offset: 0x00007664
		public static SmsContentEntry ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00009476 File Offset: 0x00007676
		public static SmsContentEntry ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00009489 File Offset: 0x00007689
		private SmsContentEntry MakeReadOnly()
		{
			return this;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0000948C File Offset: 0x0000768C
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00009493 File Offset: 0x00007693
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0000949B File Offset: 0x0000769B
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x000094A2 File Offset: 0x000076A2
		public static Builder CreateBuilder(SmsContentEntry prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x000094AC File Offset: 0x000076AC
		static SmsContentEntry()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x040002C7 RID: 711
        private static readonly string[] _smsContentEntryFieldNames = new string[]
		{
			"key",
			"value"
		};

		// Token: 0x040002C8 RID: 712
		private static readonly uint[] _smsContentEntryFieldTags = new uint[]
		{
			10U,
			18U
		};

		// Token: 0x040002C9 RID: 713
		public const int KeyFieldNumber = 1;

        // Token: 0x040002CB RID: 715
        private string key_ = "";

		// Token: 0x040002CC RID: 716
		public const int ValueFieldNumber = 2;

        // Token: 0x040002CE RID: 718
        private string value_ = "";

		// Token: 0x040002CF RID: 719
		private int memoizedSerializedSize = -1;

		// Token: 0x02000084 RID: 132
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<SmsContentEntry, Builder>
		{
            // Token: 0x170004AE RID: 1198
            // (get) Token: 0x06000C08 RID: 3080 RVA: 0x0001C7C7 File Offset: 0x0001A9C7
            protected override Builder ThisBuilder => this;

            // Token: 0x06000C09 RID: 3081 RVA: 0x0001C7CA File Offset: 0x0001A9CA
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000C0A RID: 3082 RVA: 0x0001C7E4 File Offset: 0x0001A9E4
			internal Builder(SmsContentEntry cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x06000C0B RID: 3083 RVA: 0x0001C7FC File Offset: 0x0001A9FC
			private SmsContentEntry PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					SmsContentEntry other = result;
					result = new SmsContentEntry();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x170004AF RID: 1199
            // (get) Token: 0x06000C0C RID: 3084 RVA: 0x0001C838 File Offset: 0x0001AA38
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x170004B0 RID: 1200
            // (get) Token: 0x06000C0D RID: 3085 RVA: 0x0001C845 File Offset: 0x0001AA45
            protected override SmsContentEntry MessageBeingBuilt => PrepareBuilder();

            // Token: 0x06000C0E RID: 3086 RVA: 0x0001C84D File Offset: 0x0001AA4D
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x06000C0F RID: 3087 RVA: 0x0001C862 File Offset: 0x0001AA62
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x170004B1 RID: 1201
            // (get) Token: 0x06000C10 RID: 3088 RVA: 0x0001C888 File Offset: 0x0001AA88
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x170004B2 RID: 1202
            // (get) Token: 0x06000C11 RID: 3089 RVA: 0x0001C88F File Offset: 0x0001AA8F
            public override SmsContentEntry DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000C12 RID: 3090 RVA: 0x0001C896 File Offset: 0x0001AA96
            public override SmsContentEntry BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x06000C13 RID: 3091 RVA: 0x0001C8B9 File Offset: 0x0001AAB9
			public override Builder MergeFrom(IMessage other)
			{
				if (other is SmsContentEntry)
				{
					return MergeFrom((SmsContentEntry)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000C14 RID: 3092 RVA: 0x0001C8DC File Offset: 0x0001AADC
			public override Builder MergeFrom(SmsContentEntry other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasKey)
				{
					Key = other.Key;
				}
				if (other.HasValue)
				{
					Value = other.Value;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000C15 RID: 3093 RVA: 0x0001C930 File Offset: 0x0001AB30
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000C16 RID: 3094 RVA: 0x0001C940 File Offset: 0x0001AB40
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_smsContentEntryFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _smsContentEntryFieldTags[num2];
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
                            result.HasValue = input.ReadString(ref result.value_);
                        }
                    }
                    else
                    {
                        result.HasKey = input.ReadString(ref result.key_);
                    }
                }
                if (builder != null)
				{
					UnknownFields = builder.Build();
				}
				return this;
			}

            // Token: 0x170004B3 RID: 1203
            // (get) Token: 0x06000C17 RID: 3095 RVA: 0x0001CA44 File Offset: 0x0001AC44
            public bool HasKey => result.HasKey;

            // Token: 0x170004B4 RID: 1204
            // (get) Token: 0x06000C18 RID: 3096 RVA: 0x0001CA51 File Offset: 0x0001AC51
            // (set) Token: 0x06000C19 RID: 3097 RVA: 0x0001CA5E File Offset: 0x0001AC5E
            public string Key
			{
				get
				{
					return result.Key;
				}
				set
				{
					SetKey(value);
				}
			}

			// Token: 0x06000C1A RID: 3098 RVA: 0x0001CA68 File Offset: 0x0001AC68
			public Builder SetKey(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasKey = true;
				result.key_ = value;
				return this;
			}

			// Token: 0x06000C1B RID: 3099 RVA: 0x0001CA95 File Offset: 0x0001AC95
			public Builder ClearKey()
			{
				PrepareBuilder();
				result.HasKey = false;
				result.key_ = "";
				return this;
			}

            // Token: 0x170004B5 RID: 1205
            // (get) Token: 0x06000C1C RID: 3100 RVA: 0x0001CABB File Offset: 0x0001ACBB
            public bool HasValue => result.HasValue;

            // Token: 0x170004B6 RID: 1206
            // (get) Token: 0x06000C1D RID: 3101 RVA: 0x0001CAC8 File Offset: 0x0001ACC8
            // (set) Token: 0x06000C1E RID: 3102 RVA: 0x0001CAD5 File Offset: 0x0001ACD5
            public string Value
			{
				get
				{
					return result.Value;
				}
				set
				{
					SetValue(value);
				}
			}

			// Token: 0x06000C1F RID: 3103 RVA: 0x0001CADF File Offset: 0x0001ACDF
			public Builder SetValue(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasValue = true;
				result.value_ = value;
				return this;
			}

			// Token: 0x06000C20 RID: 3104 RVA: 0x0001CB0C File Offset: 0x0001AD0C
			public Builder ClearValue()
			{
				PrepareBuilder();
				result.HasValue = false;
				result.value_ = "";
				return this;
			}

			// Token: 0x040003F1 RID: 1009
			private bool resultIsReadOnly;

			// Token: 0x040003F2 RID: 1010
			private SmsContentEntry result;
		}
	}
}
