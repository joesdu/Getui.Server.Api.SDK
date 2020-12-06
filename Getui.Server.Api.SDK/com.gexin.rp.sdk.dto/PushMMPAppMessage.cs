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
    // Token: 0x02000018 RID: 24
    [DebuggerNonUserCode]
	public sealed class PushMMPAppMessage : GeneratedMessage<PushMMPAppMessage, PushMMPAppMessage.Builder>
	{
		// Token: 0x0600022E RID: 558 RVA: 0x00005363 File Offset: 0x00003563
		private PushMMPAppMessage()
		{
		}

        // Token: 0x170000EB RID: 235
        // (get) Token: 0x0600022F RID: 559 RVA: 0x0000539E File Offset: 0x0000359E
        public static PushMMPAppMessage DefaultInstance { get; } = new PushMMPAppMessage().MakeReadOnly();

        // Token: 0x170000EC RID: 236
        // (get) Token: 0x06000230 RID: 560 RVA: 0x000053A5 File Offset: 0x000035A5
        public override PushMMPAppMessage DefaultInstanceForType => DefaultInstance;

        // Token: 0x170000ED RID: 237
        // (get) Token: 0x06000231 RID: 561 RVA: 0x000053AC File Offset: 0x000035AC
        protected override PushMMPAppMessage ThisMessage => this;

        // Token: 0x170000EE RID: 238
        // (get) Token: 0x06000232 RID: 562 RVA: 0x000053AF File Offset: 0x000035AF
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPAppMessage__Descriptor;

        // Token: 0x170000EF RID: 239
        // (get) Token: 0x06000233 RID: 563 RVA: 0x000053B6 File Offset: 0x000035B6
        protected override FieldAccessorTable<PushMMPAppMessage, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_PushMMPAppMessage__FieldAccessorTable;

        // Token: 0x170000F0 RID: 240
        // (get) Token: 0x06000234 RID: 564 RVA: 0x000053BD File Offset: 0x000035BD
        public bool HasMessage { get; private set; }

        // Token: 0x170000F1 RID: 241
        // (get) Token: 0x06000235 RID: 565 RVA: 0x000053C5 File Offset: 0x000035C5
        public MMPMessage Message => message_ ?? MMPMessage.DefaultInstance;

        // Token: 0x170000F2 RID: 242
        // (get) Token: 0x06000236 RID: 566 RVA: 0x000053D6 File Offset: 0x000035D6
        public IList<string> AppIdListList => Lists.AsReadOnly(appIdList_);

        // Token: 0x170000F3 RID: 243
        // (get) Token: 0x06000237 RID: 567 RVA: 0x000053E3 File Offset: 0x000035E3
        public int AppIdListCount => appIdList_.Count;

        // Token: 0x06000238 RID: 568 RVA: 0x000053F0 File Offset: 0x000035F0
        public string GetAppIdList(int index)
		{
			return appIdList_[index];
		}

        // Token: 0x170000F4 RID: 244
        // (get) Token: 0x06000239 RID: 569 RVA: 0x000053FE File Offset: 0x000035FE
        public IList<string> PhoneTypeListList => Lists.AsReadOnly(phoneTypeList_);

        // Token: 0x170000F5 RID: 245
        // (get) Token: 0x0600023A RID: 570 RVA: 0x0000540B File Offset: 0x0000360B
        public int PhoneTypeListCount => phoneTypeList_.Count;

        // Token: 0x0600023B RID: 571 RVA: 0x00005418 File Offset: 0x00003618
        public string GetPhoneTypeList(int index)
		{
			return phoneTypeList_[index];
		}

        // Token: 0x170000F6 RID: 246
        // (get) Token: 0x0600023C RID: 572 RVA: 0x00005426 File Offset: 0x00003626
        public IList<string> ProvinceListList => Lists.AsReadOnly(provinceList_);

        // Token: 0x170000F7 RID: 247
        // (get) Token: 0x0600023D RID: 573 RVA: 0x00005433 File Offset: 0x00003633
        public int ProvinceListCount => provinceList_.Count;

        // Token: 0x0600023E RID: 574 RVA: 0x00005440 File Offset: 0x00003640
        public string GetProvinceList(int index)
		{
			return provinceList_[index];
		}

        // Token: 0x170000F8 RID: 248
        // (get) Token: 0x0600023F RID: 575 RVA: 0x0000544E File Offset: 0x0000364E
        public bool HasSeqId { get; private set; }

        // Token: 0x170000F9 RID: 249
        // (get) Token: 0x06000240 RID: 576 RVA: 0x00005456 File Offset: 0x00003656
        public string SeqId => seqId_;

        // Token: 0x170000FA RID: 250
        // (get) Token: 0x06000241 RID: 577 RVA: 0x0000545E File Offset: 0x0000365E
        public override bool IsInitialized => HasMessage && Message.IsInitialized;

        // Token: 0x06000242 RID: 578 RVA: 0x0000547C File Offset: 0x0000367C
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] pushMMPAppMessageFieldNames = _pushMMPAppMessageFieldNames;
			if (HasMessage)
			{
				output.WriteMessage(1, pushMMPAppMessageFieldNames[1], Message);
			}
			if (appIdList_.Count > 0)
			{
				output.WriteStringArray(2, pushMMPAppMessageFieldNames[0], appIdList_);
			}
			if (phoneTypeList_.Count > 0)
			{
				output.WriteStringArray(3, pushMMPAppMessageFieldNames[2], phoneTypeList_);
			}
			if (provinceList_.Count > 0)
			{
				output.WriteStringArray(4, pushMMPAppMessageFieldNames[3], provinceList_);
			}
			if (HasSeqId)
			{
				output.WriteString(5, pushMMPAppMessageFieldNames[4], SeqId);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0000552C File Offset: 0x0000372C
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
				if (HasMessage)
				{
					num += CodedOutputStream.ComputeMessageSize(1, Message);
				}
				int num2 = 0;
				foreach (string value in AppIdListList)
				{
					num2 += CodedOutputStream.ComputeStringSizeNoTag(value);
				}
				num += num2;
				num += appIdList_.Count;
				int num3 = 0;
				foreach (string value2 in PhoneTypeListList)
				{
					num3 += CodedOutputStream.ComputeStringSizeNoTag(value2);
				}
				num += num3;
				num += phoneTypeList_.Count;
				int num4 = 0;
				foreach (string value3 in ProvinceListList)
				{
					num4 += CodedOutputStream.ComputeStringSizeNoTag(value3);
				}
				num += num4;
				num += provinceList_.Count;
				if (HasSeqId)
				{
					num += CodedOutputStream.ComputeStringSize(5, SeqId);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00005694 File Offset: 0x00003894
		public static PushMMPAppMessage ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000056A6 File Offset: 0x000038A6
		public static PushMMPAppMessage ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000056B9 File Offset: 0x000038B9
		public static PushMMPAppMessage ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000056CB File Offset: 0x000038CB
		public static PushMMPAppMessage ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000056DE File Offset: 0x000038DE
		public static PushMMPAppMessage ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000056F0 File Offset: 0x000038F0
		public static PushMMPAppMessage ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00005703 File Offset: 0x00003903
		public static PushMMPAppMessage ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00005715 File Offset: 0x00003915
		public static PushMMPAppMessage ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00005728 File Offset: 0x00003928
		public static PushMMPAppMessage ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000573A File Offset: 0x0000393A
		public static PushMMPAppMessage ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000574D File Offset: 0x0000394D
		private PushMMPAppMessage MakeReadOnly()
		{
			appIdList_.MakeReadOnly();
			phoneTypeList_.MakeReadOnly();
			provinceList_.MakeReadOnly();
			return this;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00005771 File Offset: 0x00003971
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00005778 File Offset: 0x00003978
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00005780 File Offset: 0x00003980
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00005787 File Offset: 0x00003987
		public static Builder CreateBuilder(PushMMPAppMessage prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00005790 File Offset: 0x00003990
		static PushMMPAppMessage()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x04000141 RID: 321
        private static readonly string[] _pushMMPAppMessageFieldNames = new string[]
		{
			"appIdList",
			"message",
			"phoneTypeList",
			"provinceList",
			"seqId"
		};

		// Token: 0x04000142 RID: 322
		private static readonly uint[] _pushMMPAppMessageFieldTags = new uint[]
		{
			18U,
			10U,
			26U,
			34U,
			42U
		};

		// Token: 0x04000143 RID: 323
		public const int MessageFieldNumber = 1;

        // Token: 0x04000145 RID: 325
        private MMPMessage message_;

		// Token: 0x04000146 RID: 326
		public const int AppIdListFieldNumber = 2;

		// Token: 0x04000147 RID: 327
		private PopsicleList<string> appIdList_ = new PopsicleList<string>();

		// Token: 0x04000148 RID: 328
		public const int PhoneTypeListFieldNumber = 3;

		// Token: 0x04000149 RID: 329
		private PopsicleList<string> phoneTypeList_ = new PopsicleList<string>();

		// Token: 0x0400014A RID: 330
		public const int ProvinceListFieldNumber = 4;

		// Token: 0x0400014B RID: 331
		private PopsicleList<string> provinceList_ = new PopsicleList<string>();

		// Token: 0x0400014C RID: 332
		public const int SeqIdFieldNumber = 5;

        // Token: 0x0400014E RID: 334
        private string seqId_ = "";

		// Token: 0x0400014F RID: 335
		private int memoizedSerializedSize = -1;

		// Token: 0x02000073 RID: 115
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<PushMMPAppMessage, Builder>
		{
            // Token: 0x17000387 RID: 903
            // (get) Token: 0x060008E4 RID: 2276 RVA: 0x00015406 File Offset: 0x00013606
            protected override Builder ThisBuilder => this;

            // Token: 0x060008E5 RID: 2277 RVA: 0x00015409 File Offset: 0x00013609
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x060008E6 RID: 2278 RVA: 0x00015423 File Offset: 0x00013623
			internal Builder(PushMMPAppMessage cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x060008E7 RID: 2279 RVA: 0x0001543C File Offset: 0x0001363C
			private PushMMPAppMessage PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					PushMMPAppMessage other = result;
					result = new PushMMPAppMessage();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x17000388 RID: 904
            // (get) Token: 0x060008E8 RID: 2280 RVA: 0x00015478 File Offset: 0x00013678
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x17000389 RID: 905
            // (get) Token: 0x060008E9 RID: 2281 RVA: 0x00015485 File Offset: 0x00013685
            protected override PushMMPAppMessage MessageBeingBuilt => PrepareBuilder();

            // Token: 0x060008EA RID: 2282 RVA: 0x0001548D File Offset: 0x0001368D
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x060008EB RID: 2283 RVA: 0x000154A2 File Offset: 0x000136A2
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x1700038A RID: 906
            // (get) Token: 0x060008EC RID: 2284 RVA: 0x000154C8 File Offset: 0x000136C8
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x1700038B RID: 907
            // (get) Token: 0x060008ED RID: 2285 RVA: 0x000154CF File Offset: 0x000136CF
            public override PushMMPAppMessage DefaultInstanceForType => DefaultInstance;

            // Token: 0x060008EE RID: 2286 RVA: 0x000154D6 File Offset: 0x000136D6
            public override PushMMPAppMessage BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x060008EF RID: 2287 RVA: 0x000154F9 File Offset: 0x000136F9
			public override Builder MergeFrom(IMessage other)
			{
				if (other is PushMMPAppMessage)
				{
					return MergeFrom((PushMMPAppMessage)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x060008F0 RID: 2288 RVA: 0x0001551C File Offset: 0x0001371C
			public override Builder MergeFrom(PushMMPAppMessage other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasMessage)
				{
					MergeMessage(other.Message);
				}
				if (other.appIdList_.Count != 0)
				{
					result.appIdList_.Add(other.appIdList_);
				}
				if (other.phoneTypeList_.Count != 0)
				{
					result.phoneTypeList_.Add(other.phoneTypeList_);
				}
				if (other.provinceList_.Count != 0)
				{
					result.provinceList_.Add(other.provinceList_);
				}
				if (other.HasSeqId)
				{
					SeqId = other.SeqId;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x060008F1 RID: 2289 RVA: 0x000155DA File Offset: 0x000137DA
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x060008F2 RID: 2290 RVA: 0x000155E8 File Offset: 0x000137E8
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_pushMMPAppMessageFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _pushMMPAppMessageFieldTags[num2];
                    }
                    if (num <= 18U)
                    {
                        if (num == 0U)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10U)
                        {
                            MMPMessage.Builder builder2 = MMPMessage.CreateBuilder();
                            if (result.HasMessage)
                            {
                                builder2.MergeFrom(Message);
                            }
                            input.ReadMessage(builder2, extensionRegistry);
                            Message = builder2.BuildPartial();
                            continue;
                        }
                        if (num == 18U)
                        {
                            input.ReadStringArray(num, text, result.appIdList_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 26U)
                        {
                            input.ReadStringArray(num, text, result.phoneTypeList_);
                            continue;
                        }
                        if (num == 34U)
                        {
                            input.ReadStringArray(num, text, result.provinceList_);
                            continue;
                        }
                        if (num == 42U)
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

            // Token: 0x1700038C RID: 908
            // (get) Token: 0x060008F3 RID: 2291 RVA: 0x0001576C File Offset: 0x0001396C
            public bool HasMessage => result.HasMessage;

            // Token: 0x1700038D RID: 909
            // (get) Token: 0x060008F4 RID: 2292 RVA: 0x00015779 File Offset: 0x00013979
            // (set) Token: 0x060008F5 RID: 2293 RVA: 0x00015786 File Offset: 0x00013986
            public MMPMessage Message
			{
				get
				{
					return result.Message;
				}
				set
				{
					SetMessage(value);
				}
			}

			// Token: 0x060008F6 RID: 2294 RVA: 0x00015790 File Offset: 0x00013990
			public Builder SetMessage(MMPMessage value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasMessage = true;
				result.message_ = value;
				return this;
			}

			// Token: 0x060008F7 RID: 2295 RVA: 0x000157BD File Offset: 0x000139BD
			public Builder SetMessage(MMPMessage.Builder builderForValue)
			{
				ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
				PrepareBuilder();
				result.HasMessage = true;
				result.message_ = builderForValue.Build();
				return this;
			}

			// Token: 0x060008F8 RID: 2296 RVA: 0x000157F0 File Offset: 0x000139F0
			public Builder MergeMessage(MMPMessage value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				if (result.HasMessage && result.message_ != MMPMessage.DefaultInstance)
				{
					result.message_ = MMPMessage.CreateBuilder(result.message_).MergeFrom(value).BuildPartial();
				}
				else
				{
					result.message_ = value;
				}
				result.HasMessage = true;
				return this;
			}

			// Token: 0x060008F9 RID: 2297 RVA: 0x0001586F File Offset: 0x00013A6F
			public Builder ClearMessage()
			{
				PrepareBuilder();
				result.HasMessage = false;
				result.message_ = null;
				return this;
			}

            // Token: 0x1700038E RID: 910
            // (get) Token: 0x060008FA RID: 2298 RVA: 0x00015891 File Offset: 0x00013A91
            public IPopsicleList<string> AppIdListList => PrepareBuilder().appIdList_;

            // Token: 0x1700038F RID: 911
            // (get) Token: 0x060008FB RID: 2299 RVA: 0x0001589E File Offset: 0x00013A9E
            public int AppIdListCount => result.AppIdListCount;

            // Token: 0x060008FC RID: 2300 RVA: 0x000158AB File Offset: 0x00013AAB
            public string GetAppIdList(int index)
			{
				return result.GetAppIdList(index);
			}

			// Token: 0x060008FD RID: 2301 RVA: 0x000158B9 File Offset: 0x00013AB9
			public Builder SetAppIdList(int index, string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.appIdList_[index] = value;
				return this;
			}

			// Token: 0x060008FE RID: 2302 RVA: 0x000158E0 File Offset: 0x00013AE0
			public Builder AddAppIdList(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.appIdList_.Add(value);
				return this;
			}

			// Token: 0x060008FF RID: 2303 RVA: 0x00015906 File Offset: 0x00013B06
			public Builder AddRangeAppIdList(IEnumerable<string> values)
			{
				PrepareBuilder();
				result.appIdList_.Add(values);
				return this;
			}

			// Token: 0x06000900 RID: 2304 RVA: 0x00015921 File Offset: 0x00013B21
			public Builder ClearAppIdList()
			{
				PrepareBuilder();
				result.appIdList_.Clear();
				return this;
			}

            // Token: 0x17000390 RID: 912
            // (get) Token: 0x06000901 RID: 2305 RVA: 0x0001593B File Offset: 0x00013B3B
            public IPopsicleList<string> PhoneTypeListList => PrepareBuilder().phoneTypeList_;

            // Token: 0x17000391 RID: 913
            // (get) Token: 0x06000902 RID: 2306 RVA: 0x00015948 File Offset: 0x00013B48
            public int PhoneTypeListCount => result.PhoneTypeListCount;

            // Token: 0x06000903 RID: 2307 RVA: 0x00015955 File Offset: 0x00013B55
            public string GetPhoneTypeList(int index)
			{
				return result.GetPhoneTypeList(index);
			}

			// Token: 0x06000904 RID: 2308 RVA: 0x00015963 File Offset: 0x00013B63
			public Builder SetPhoneTypeList(int index, string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.phoneTypeList_[index] = value;
				return this;
			}

			// Token: 0x06000905 RID: 2309 RVA: 0x0001598A File Offset: 0x00013B8A
			public Builder AddPhoneTypeList(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.phoneTypeList_.Add(value);
				return this;
			}

			// Token: 0x06000906 RID: 2310 RVA: 0x000159B0 File Offset: 0x00013BB0
			public Builder AddRangePhoneTypeList(IEnumerable<string> values)
			{
				PrepareBuilder();
				result.phoneTypeList_.Add(values);
				return this;
			}

			// Token: 0x06000907 RID: 2311 RVA: 0x000159CB File Offset: 0x00013BCB
			public Builder ClearPhoneTypeList()
			{
				PrepareBuilder();
				result.phoneTypeList_.Clear();
				return this;
			}

            // Token: 0x17000392 RID: 914
            // (get) Token: 0x06000908 RID: 2312 RVA: 0x000159E5 File Offset: 0x00013BE5
            public IPopsicleList<string> ProvinceListList => PrepareBuilder().provinceList_;

            // Token: 0x17000393 RID: 915
            // (get) Token: 0x06000909 RID: 2313 RVA: 0x000159F2 File Offset: 0x00013BF2
            public int ProvinceListCount => result.ProvinceListCount;

            // Token: 0x0600090A RID: 2314 RVA: 0x000159FF File Offset: 0x00013BFF
            public string GetProvinceList(int index)
			{
				return result.GetProvinceList(index);
			}

			// Token: 0x0600090B RID: 2315 RVA: 0x00015A0D File Offset: 0x00013C0D
			public Builder SetProvinceList(int index, string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.provinceList_[index] = value;
				return this;
			}

			// Token: 0x0600090C RID: 2316 RVA: 0x00015A34 File Offset: 0x00013C34
			public Builder AddProvinceList(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.provinceList_.Add(value);
				return this;
			}

			// Token: 0x0600090D RID: 2317 RVA: 0x00015A5A File Offset: 0x00013C5A
			public Builder AddRangeProvinceList(IEnumerable<string> values)
			{
				PrepareBuilder();
				result.provinceList_.Add(values);
				return this;
			}

			// Token: 0x0600090E RID: 2318 RVA: 0x00015A75 File Offset: 0x00013C75
			public Builder ClearProvinceList()
			{
				PrepareBuilder();
				result.provinceList_.Clear();
				return this;
			}

            // Token: 0x17000394 RID: 916
            // (get) Token: 0x0600090F RID: 2319 RVA: 0x00015A8F File Offset: 0x00013C8F
            public bool HasSeqId => result.HasSeqId;

            // Token: 0x17000395 RID: 917
            // (get) Token: 0x06000910 RID: 2320 RVA: 0x00015A9C File Offset: 0x00013C9C
            // (set) Token: 0x06000911 RID: 2321 RVA: 0x00015AA9 File Offset: 0x00013CA9
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

			// Token: 0x06000912 RID: 2322 RVA: 0x00015AB3 File Offset: 0x00013CB3
			public Builder SetSeqId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSeqId = true;
				result.seqId_ = value;
				return this;
			}

			// Token: 0x06000913 RID: 2323 RVA: 0x00015AE0 File Offset: 0x00013CE0
			public Builder ClearSeqId()
			{
				PrepareBuilder();
				result.HasSeqId = false;
				result.seqId_ = "";
				return this;
			}

			// Token: 0x040003D7 RID: 983
			private bool resultIsReadOnly;

			// Token: 0x040003D8 RID: 984
			private PushMMPAppMessage result;
		}
	}
}
