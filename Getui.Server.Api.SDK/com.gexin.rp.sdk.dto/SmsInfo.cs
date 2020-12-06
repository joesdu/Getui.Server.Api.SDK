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
    // Token: 0x02000026 RID: 38
    [DebuggerNonUserCode]
	public sealed class SmsInfo : GeneratedMessage<SmsInfo, SmsInfo.Builder>
	{
		// Token: 0x0600047D RID: 1149 RVA: 0x000094FE File Offset: 0x000076FE
		private SmsInfo()
		{
		}

        // Token: 0x17000237 RID: 567
        // (get) Token: 0x0600047E RID: 1150 RVA: 0x0000952E File Offset: 0x0000772E
        public static SmsInfo DefaultInstance { get; } = new SmsInfo().MakeReadOnly();

        // Token: 0x17000238 RID: 568
        // (get) Token: 0x0600047F RID: 1151 RVA: 0x00009535 File Offset: 0x00007735
        public override SmsInfo DefaultInstanceForType => DefaultInstance;

        // Token: 0x17000239 RID: 569
        // (get) Token: 0x06000480 RID: 1152 RVA: 0x0000953C File Offset: 0x0000773C
        protected override SmsInfo ThisMessage => this;

        // Token: 0x1700023A RID: 570
        // (get) Token: 0x06000481 RID: 1153 RVA: 0x0000953F File Offset: 0x0000773F
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_SmsInfo__Descriptor;

        // Token: 0x1700023B RID: 571
        // (get) Token: 0x06000482 RID: 1154 RVA: 0x00009546 File Offset: 0x00007746
        protected override FieldAccessorTable<SmsInfo, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_SmsInfo__FieldAccessorTable;

        // Token: 0x1700023C RID: 572
        // (get) Token: 0x06000483 RID: 1155 RVA: 0x0000954D File Offset: 0x0000774D
        public bool HasSmsTemplateId { get; private set; }

        // Token: 0x1700023D RID: 573
        // (get) Token: 0x06000484 RID: 1156 RVA: 0x00009555 File Offset: 0x00007755
        public string SmsTemplateId => smsTemplateId_;

        // Token: 0x1700023E RID: 574
        // (get) Token: 0x06000485 RID: 1157 RVA: 0x0000955D File Offset: 0x0000775D
        public IList<SmsContentEntry> SmsContentList => smsContent_;

        // Token: 0x1700023F RID: 575
        // (get) Token: 0x06000486 RID: 1158 RVA: 0x00009565 File Offset: 0x00007765
        public int SmsContentCount => smsContent_.Count;

        // Token: 0x06000487 RID: 1159 RVA: 0x00009572 File Offset: 0x00007772
        public SmsContentEntry GetSmsContent(int index)
		{
			return smsContent_[index];
		}

        // Token: 0x17000240 RID: 576
        // (get) Token: 0x06000488 RID: 1160 RVA: 0x00009580 File Offset: 0x00007780
        public bool HasOfflineSendtime { get; private set; }

        // Token: 0x17000241 RID: 577
        // (get) Token: 0x06000489 RID: 1161 RVA: 0x00009588 File Offset: 0x00007788
        public long OfflineSendtime => offlineSendtime_;

        // Token: 0x17000242 RID: 578
        // (get) Token: 0x0600048A RID: 1162 RVA: 0x00009590 File Offset: 0x00007790
        public bool HasSmsSendDuration { get; private set; }

        // Token: 0x17000243 RID: 579
        // (get) Token: 0x0600048B RID: 1163 RVA: 0x00009598 File Offset: 0x00007798
        public long SmsSendDuration => smsSendDuration_;

        // Token: 0x17000244 RID: 580
        // (get) Token: 0x0600048C RID: 1164 RVA: 0x000095A0 File Offset: 0x000077A0
        public bool HasSmsChecked { get; private set; }

        // Token: 0x17000245 RID: 581
        // (get) Token: 0x0600048D RID: 1165 RVA: 0x000095A8 File Offset: 0x000077A8
        public bool SmsChecked => smsChecked_;

        // Token: 0x17000246 RID: 582
        // (get) Token: 0x0600048E RID: 1166 RVA: 0x000095B0 File Offset: 0x000077B0
        public bool HasSmsCheckedErrorMsg { get; private set; }

        // Token: 0x17000247 RID: 583
        // (get) Token: 0x0600048F RID: 1167 RVA: 0x000095B8 File Offset: 0x000077B8
        public string SmsCheckedErrorMsg => smsCheckedErrorMsg_;

        // Token: 0x17000248 RID: 584
        // (get) Token: 0x06000490 RID: 1168 RVA: 0x000095C0 File Offset: 0x000077C0
        public override bool IsInitialized
		{
			get
			{
				if (!HasSmsTemplateId)
				{
					return false;
				}
				if (!HasOfflineSendtime)
				{
					return false;
				}
				using (IEnumerator<SmsContentEntry> enumerator = SmsContentList.GetEnumerator())
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

		// Token: 0x06000491 RID: 1169 RVA: 0x00009628 File Offset: 0x00007828
		public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] smsInfoFieldNames = _smsInfoFieldNames;
			if (HasSmsTemplateId)
			{
				output.WriteString(1, smsInfoFieldNames[5], SmsTemplateId);
			}
			if (smsContent_.Count > 0)
			{
				output.WriteMessageArray(2, smsInfoFieldNames[3], smsContent_);
			}
			if (HasOfflineSendtime)
			{
				output.WriteInt64(3, smsInfoFieldNames[0], OfflineSendtime);
			}
			if (HasSmsSendDuration)
			{
				output.WriteInt64(4, smsInfoFieldNames[4], SmsSendDuration);
			}
			if (HasSmsChecked)
			{
				output.WriteBool(5, smsInfoFieldNames[1], SmsChecked);
			}
			if (HasSmsCheckedErrorMsg)
			{
				output.WriteString(6, smsInfoFieldNames[2], SmsCheckedErrorMsg);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x000096E4 File Offset: 0x000078E4
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
				if (HasSmsTemplateId)
				{
					num += CodedOutputStream.ComputeStringSize(1, SmsTemplateId);
				}
				foreach (SmsContentEntry value in SmsContentList)
				{
					num += CodedOutputStream.ComputeMessageSize(2, value);
				}
				if (HasOfflineSendtime)
				{
					num += CodedOutputStream.ComputeInt64Size(3, OfflineSendtime);
				}
				if (HasSmsSendDuration)
				{
					num += CodedOutputStream.ComputeInt64Size(4, SmsSendDuration);
				}
				if (HasSmsChecked)
				{
					num += CodedOutputStream.ComputeBoolSize(5, SmsChecked);
				}
				if (HasSmsCheckedErrorMsg)
				{
					num += CodedOutputStream.ComputeStringSize(6, SmsCheckedErrorMsg);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000097CC File Offset: 0x000079CC
		public static SmsInfo ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000097DE File Offset: 0x000079DE
		public static SmsInfo ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x000097F1 File Offset: 0x000079F1
		public static SmsInfo ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00009803 File Offset: 0x00007A03
		public static SmsInfo ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00009816 File Offset: 0x00007A16
		public static SmsInfo ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00009828 File Offset: 0x00007A28
		public static SmsInfo ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000983B File Offset: 0x00007A3B
		public static SmsInfo ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0000984D File Offset: 0x00007A4D
		public static SmsInfo ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00009860 File Offset: 0x00007A60
		public static SmsInfo ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00009872 File Offset: 0x00007A72
		public static SmsInfo ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00009885 File Offset: 0x00007A85
		private SmsInfo MakeReadOnly()
		{
			smsContent_.MakeReadOnly();
			return this;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00009893 File Offset: 0x00007A93
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0000989A File Offset: 0x00007A9A
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x000098A2 File Offset: 0x00007AA2
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x000098A9 File Offset: 0x00007AA9
		public static Builder CreateBuilder(SmsInfo prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x000098B4 File Offset: 0x00007AB4
		static SmsInfo()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x040002D1 RID: 721
        private static readonly string[] _smsInfoFieldNames = new string[]
		{
			"offlineSendtime",
			"smsChecked",
			"smsCheckedErrorMsg",
			"smsContent",
			"smsSendDuration",
			"smsTemplateId"
		};

		// Token: 0x040002D2 RID: 722
		private static readonly uint[] _smsInfoFieldTags = new uint[]
		{
			24U,
			40U,
			50U,
			18U,
			32U,
			10U
		};

		// Token: 0x040002D3 RID: 723
		public const int SmsTemplateIdFieldNumber = 1;

        // Token: 0x040002D5 RID: 725
        private string smsTemplateId_ = "";

		// Token: 0x040002D6 RID: 726
		public const int SmsContentFieldNumber = 2;

		// Token: 0x040002D7 RID: 727
		private PopsicleList<SmsContentEntry> smsContent_ = new PopsicleList<SmsContentEntry>();

		// Token: 0x040002D8 RID: 728
		public const int OfflineSendtimeFieldNumber = 3;

        // Token: 0x040002DA RID: 730
        private long offlineSendtime_;

		// Token: 0x040002DB RID: 731
		public const int SmsSendDurationFieldNumber = 4;

        // Token: 0x040002DD RID: 733
        private long smsSendDuration_;

		// Token: 0x040002DE RID: 734
		public const int SmsCheckedFieldNumber = 5;

        // Token: 0x040002E0 RID: 736
        private bool smsChecked_;

		// Token: 0x040002E1 RID: 737
		public const int SmsCheckedErrorMsgFieldNumber = 6;

        // Token: 0x040002E3 RID: 739
        private string smsCheckedErrorMsg_ = "";

		// Token: 0x040002E4 RID: 740
		private int memoizedSerializedSize = -1;

		// Token: 0x02000085 RID: 133
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<SmsInfo, Builder>
		{
            // Token: 0x170004B7 RID: 1207
            // (get) Token: 0x06000C21 RID: 3105 RVA: 0x0001CB32 File Offset: 0x0001AD32
            protected override Builder ThisBuilder => this;

            // Token: 0x06000C22 RID: 3106 RVA: 0x0001CB35 File Offset: 0x0001AD35
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000C23 RID: 3107 RVA: 0x0001CB4F File Offset: 0x0001AD4F
			internal Builder(SmsInfo cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x06000C24 RID: 3108 RVA: 0x0001CB68 File Offset: 0x0001AD68
			private SmsInfo PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					SmsInfo other = result;
					result = new SmsInfo();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x170004B8 RID: 1208
            // (get) Token: 0x06000C25 RID: 3109 RVA: 0x0001CBA4 File Offset: 0x0001ADA4
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x170004B9 RID: 1209
            // (get) Token: 0x06000C26 RID: 3110 RVA: 0x0001CBB1 File Offset: 0x0001ADB1
            protected override SmsInfo MessageBeingBuilt => PrepareBuilder();

            // Token: 0x06000C27 RID: 3111 RVA: 0x0001CBB9 File Offset: 0x0001ADB9
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x06000C28 RID: 3112 RVA: 0x0001CBCE File Offset: 0x0001ADCE
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x170004BA RID: 1210
            // (get) Token: 0x06000C29 RID: 3113 RVA: 0x0001CBF4 File Offset: 0x0001ADF4
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x170004BB RID: 1211
            // (get) Token: 0x06000C2A RID: 3114 RVA: 0x0001CBFB File Offset: 0x0001ADFB
            public override SmsInfo DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000C2B RID: 3115 RVA: 0x0001CC02 File Offset: 0x0001AE02
            public override SmsInfo BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x06000C2C RID: 3116 RVA: 0x0001CC25 File Offset: 0x0001AE25
			public override Builder MergeFrom(IMessage other)
			{
				if (other is SmsInfo)
				{
					return MergeFrom((SmsInfo)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000C2D RID: 3117 RVA: 0x0001CC48 File Offset: 0x0001AE48
			public override Builder MergeFrom(SmsInfo other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasSmsTemplateId)
				{
					SmsTemplateId = other.SmsTemplateId;
				}
				if (other.smsContent_.Count != 0)
				{
					result.smsContent_.Add(other.smsContent_);
				}
				if (other.HasOfflineSendtime)
				{
					OfflineSendtime = other.OfflineSendtime;
				}
				if (other.HasSmsSendDuration)
				{
					SmsSendDuration = other.SmsSendDuration;
				}
				if (other.HasSmsChecked)
				{
					SmsChecked = other.SmsChecked;
				}
				if (other.HasSmsCheckedErrorMsg)
				{
					SmsCheckedErrorMsg = other.SmsCheckedErrorMsg;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000C2E RID: 3118 RVA: 0x0001CCFB File Offset: 0x0001AEFB
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000C2F RID: 3119 RVA: 0x0001CD0C File Offset: 0x0001AF0C
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_smsInfoFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _smsInfoFieldTags[num2];
                    }
                    if (num <= 18U)
                    {
                        if (num == 0U)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10U)
                        {
                            result.HasSmsTemplateId = input.ReadString(ref result.smsTemplateId_);
                            continue;
                        }
                        if (num == 18U)
                        {
                            input.ReadMessageArray(num, text, result.smsContent_, SmsContentEntry.DefaultInstance, extensionRegistry);
                            continue;
                        }
                    }
                    else if (num <= 32U)
                    {
                        if (num == 24U)
                        {
                            result.HasOfflineSendtime = input.ReadInt64(ref result.offlineSendtime_);
                            continue;
                        }
                        if (num == 32U)
                        {
                            result.HasSmsSendDuration = input.ReadInt64(ref result.smsSendDuration_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 40U)
                        {
                            result.HasSmsChecked = input.ReadBool(ref result.smsChecked_);
                            continue;
                        }
                        if (num == 50U)
                        {
                            result.HasSmsCheckedErrorMsg = input.ReadString(ref result.smsCheckedErrorMsg_);
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

            // Token: 0x170004BC RID: 1212
            // (get) Token: 0x06000C30 RID: 3120 RVA: 0x0001CEBC File Offset: 0x0001B0BC
            public bool HasSmsTemplateId => result.HasSmsTemplateId;

            // Token: 0x170004BD RID: 1213
            // (get) Token: 0x06000C31 RID: 3121 RVA: 0x0001CEC9 File Offset: 0x0001B0C9
            // (set) Token: 0x06000C32 RID: 3122 RVA: 0x0001CED6 File Offset: 0x0001B0D6
            public string SmsTemplateId
			{
				get
				{
					return result.SmsTemplateId;
				}
				set
				{
					SetSmsTemplateId(value);
				}
			}

			// Token: 0x06000C33 RID: 3123 RVA: 0x0001CEE0 File Offset: 0x0001B0E0
			public Builder SetSmsTemplateId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSmsTemplateId = true;
				result.smsTemplateId_ = value;
				return this;
			}

			// Token: 0x06000C34 RID: 3124 RVA: 0x0001CF0D File Offset: 0x0001B10D
			public Builder ClearSmsTemplateId()
			{
				PrepareBuilder();
				result.HasSmsTemplateId = false;
				result.smsTemplateId_ = "";
				return this;
			}

            // Token: 0x170004BE RID: 1214
            // (get) Token: 0x06000C35 RID: 3125 RVA: 0x0001CF33 File Offset: 0x0001B133
            public IPopsicleList<SmsContentEntry> SmsContentList => PrepareBuilder().smsContent_;

            // Token: 0x170004BF RID: 1215
            // (get) Token: 0x06000C36 RID: 3126 RVA: 0x0001CF40 File Offset: 0x0001B140
            public int SmsContentCount => result.SmsContentCount;

            // Token: 0x06000C37 RID: 3127 RVA: 0x0001CF4D File Offset: 0x0001B14D
            public SmsContentEntry GetSmsContent(int index)
			{
				return result.GetSmsContent(index);
			}

			// Token: 0x06000C38 RID: 3128 RVA: 0x0001CF5B File Offset: 0x0001B15B
			public Builder SetSmsContent(int index, SmsContentEntry value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.smsContent_[index] = value;
				return this;
			}

			// Token: 0x06000C39 RID: 3129 RVA: 0x0001CF82 File Offset: 0x0001B182
			public Builder SetSmsContent(int index, SmsContentEntry.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.smsContent_[index] = builderForValue.Build();
				return this;
			}

			// Token: 0x06000C3A RID: 3130 RVA: 0x0001CFAE File Offset: 0x0001B1AE
			public Builder AddSmsContent(SmsContentEntry value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.smsContent_.Add(value);
				return this;
			}

			// Token: 0x06000C3B RID: 3131 RVA: 0x0001CFD4 File Offset: 0x0001B1D4
			public Builder AddSmsContent(SmsContentEntry.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.smsContent_.Add(builderForValue.Build());
				return this;
			}

			// Token: 0x06000C3C RID: 3132 RVA: 0x0001CFFF File Offset: 0x0001B1FF
			public Builder AddRangeSmsContent(IEnumerable<SmsContentEntry> values)
			{
				PrepareBuilder();
				result.smsContent_.Add(values);
				return this;
			}

			// Token: 0x06000C3D RID: 3133 RVA: 0x0001D01A File Offset: 0x0001B21A
			public Builder ClearSmsContent()
			{
				PrepareBuilder();
				result.smsContent_.Clear();
				return this;
			}

            // Token: 0x170004C0 RID: 1216
            // (get) Token: 0x06000C3E RID: 3134 RVA: 0x0001D034 File Offset: 0x0001B234
            public bool HasOfflineSendtime => result.HasOfflineSendtime;

            // Token: 0x170004C1 RID: 1217
            // (get) Token: 0x06000C3F RID: 3135 RVA: 0x0001D041 File Offset: 0x0001B241
            // (set) Token: 0x06000C40 RID: 3136 RVA: 0x0001D04E File Offset: 0x0001B24E
            public long OfflineSendtime
			{
				get
				{
					return result.OfflineSendtime;
				}
				set
				{
					SetOfflineSendtime(value);
				}
			}

			// Token: 0x06000C41 RID: 3137 RVA: 0x0001D058 File Offset: 0x0001B258
			public Builder SetOfflineSendtime(long value)
			{
				PrepareBuilder();
				result.HasOfflineSendtime = true;
				result.offlineSendtime_ = value;
				return this;
			}

			// Token: 0x06000C42 RID: 3138 RVA: 0x0001D07A File Offset: 0x0001B27A
			public Builder ClearOfflineSendtime()
			{
				PrepareBuilder();
				result.HasOfflineSendtime = false;
				result.offlineSendtime_ = 0L;
				return this;
			}

            // Token: 0x170004C2 RID: 1218
            // (get) Token: 0x06000C43 RID: 3139 RVA: 0x0001D09D File Offset: 0x0001B29D
            public bool HasSmsSendDuration => result.HasSmsSendDuration;

            // Token: 0x170004C3 RID: 1219
            // (get) Token: 0x06000C44 RID: 3140 RVA: 0x0001D0AA File Offset: 0x0001B2AA
            // (set) Token: 0x06000C45 RID: 3141 RVA: 0x0001D0B7 File Offset: 0x0001B2B7
            public long SmsSendDuration
			{
				get
				{
					return result.SmsSendDuration;
				}
				set
				{
					SetSmsSendDuration(value);
				}
			}

			// Token: 0x06000C46 RID: 3142 RVA: 0x0001D0C1 File Offset: 0x0001B2C1
			public Builder SetSmsSendDuration(long value)
			{
				PrepareBuilder();
				result.HasSmsSendDuration = true;
				result.smsSendDuration_ = value;
				return this;
			}

			// Token: 0x06000C47 RID: 3143 RVA: 0x0001D0E3 File Offset: 0x0001B2E3
			public Builder ClearSmsSendDuration()
			{
				PrepareBuilder();
				result.HasSmsSendDuration = false;
				result.smsSendDuration_ = 0L;
				return this;
			}

            // Token: 0x170004C4 RID: 1220
            // (get) Token: 0x06000C48 RID: 3144 RVA: 0x0001D106 File Offset: 0x0001B306
            public bool HasSmsChecked => result.HasSmsChecked;

            // Token: 0x170004C5 RID: 1221
            // (get) Token: 0x06000C49 RID: 3145 RVA: 0x0001D113 File Offset: 0x0001B313
            // (set) Token: 0x06000C4A RID: 3146 RVA: 0x0001D120 File Offset: 0x0001B320
            public bool SmsChecked
			{
				get
				{
					return result.SmsChecked;
				}
				set
				{
					SetSmsChecked(value);
				}
			}

			// Token: 0x06000C4B RID: 3147 RVA: 0x0001D12A File Offset: 0x0001B32A
			public Builder SetSmsChecked(bool value)
			{
				PrepareBuilder();
				result.HasSmsChecked = true;
				result.smsChecked_ = value;
				return this;
			}

			// Token: 0x06000C4C RID: 3148 RVA: 0x0001D14C File Offset: 0x0001B34C
			public Builder ClearSmsChecked()
			{
				PrepareBuilder();
				result.HasSmsChecked = false;
				result.smsChecked_ = false;
				return this;
			}

            // Token: 0x170004C6 RID: 1222
            // (get) Token: 0x06000C4D RID: 3149 RVA: 0x0001D16E File Offset: 0x0001B36E
            public bool HasSmsCheckedErrorMsg => result.HasSmsCheckedErrorMsg;

            // Token: 0x170004C7 RID: 1223
            // (get) Token: 0x06000C4E RID: 3150 RVA: 0x0001D17B File Offset: 0x0001B37B
            // (set) Token: 0x06000C4F RID: 3151 RVA: 0x0001D188 File Offset: 0x0001B388
            public string SmsCheckedErrorMsg
			{
				get
				{
					return result.SmsCheckedErrorMsg;
				}
				set
				{
					SetSmsCheckedErrorMsg(value);
				}
			}

			// Token: 0x06000C50 RID: 3152 RVA: 0x0001D192 File Offset: 0x0001B392
			public Builder SetSmsCheckedErrorMsg(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSmsCheckedErrorMsg = true;
				result.smsCheckedErrorMsg_ = value;
				return this;
			}

			// Token: 0x06000C51 RID: 3153 RVA: 0x0001D1BF File Offset: 0x0001B3BF
			public Builder ClearSmsCheckedErrorMsg()
			{
				PrepareBuilder();
				result.HasSmsCheckedErrorMsg = false;
				result.smsCheckedErrorMsg_ = "";
				return this;
			}

			// Token: 0x040003F3 RID: 1011
			private bool resultIsReadOnly;

			// Token: 0x040003F4 RID: 1012
			private SmsInfo result;
		}
	}
}
