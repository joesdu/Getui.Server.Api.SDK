using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x0200001F RID: 31
    [DebuggerNonUserCode]
	public sealed class NotifyInfo : GeneratedMessage<NotifyInfo, NotifyInfo.Builder>
	{
		// Token: 0x06000350 RID: 848 RVA: 0x00007390 File Offset: 0x00005590
		private NotifyInfo()
		{
		}

        // Token: 0x1700018A RID: 394
        // (get) Token: 0x06000351 RID: 849 RVA: 0x000073EC File Offset: 0x000055EC
        public static NotifyInfo DefaultInstance { get; } = new NotifyInfo().MakeReadOnly();

        // Token: 0x1700018B RID: 395
        // (get) Token: 0x06000352 RID: 850 RVA: 0x000073F3 File Offset: 0x000055F3
        public override NotifyInfo DefaultInstanceForType => DefaultInstance;

        // Token: 0x1700018C RID: 396
        // (get) Token: 0x06000353 RID: 851 RVA: 0x000073FA File Offset: 0x000055FA
        protected override NotifyInfo ThisMessage => this;

        // Token: 0x1700018D RID: 397
        // (get) Token: 0x06000354 RID: 852 RVA: 0x000073FD File Offset: 0x000055FD
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_NotifyInfo__Descriptor;

        // Token: 0x1700018E RID: 398
        // (get) Token: 0x06000355 RID: 853 RVA: 0x00007404 File Offset: 0x00005604
        protected override FieldAccessorTable<NotifyInfo, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_NotifyInfo__FieldAccessorTable;

        // Token: 0x1700018F RID: 399
        // (get) Token: 0x06000356 RID: 854 RVA: 0x0000740B File Offset: 0x0000560B
        public bool HasTitle { get; private set; }

        // Token: 0x17000190 RID: 400
        // (get) Token: 0x06000357 RID: 855 RVA: 0x00007413 File Offset: 0x00005613
        public string Title => title_;

        // Token: 0x17000191 RID: 401
        // (get) Token: 0x06000358 RID: 856 RVA: 0x0000741B File Offset: 0x0000561B
        public bool HasContent { get; private set; }

        // Token: 0x17000192 RID: 402
        // (get) Token: 0x06000359 RID: 857 RVA: 0x00007423 File Offset: 0x00005623
        public string Content => content_;

        // Token: 0x17000193 RID: 403
        // (get) Token: 0x0600035A RID: 858 RVA: 0x0000742B File Offset: 0x0000562B
        public bool HasPayload { get; private set; }

        // Token: 0x17000194 RID: 404
        // (get) Token: 0x0600035B RID: 859 RVA: 0x00007433 File Offset: 0x00005633
        public string Payload => payload_;

        // Token: 0x17000195 RID: 405
        // (get) Token: 0x0600035C RID: 860 RVA: 0x0000743B File Offset: 0x0000563B
        public bool HasIntent { get; private set; }

        // Token: 0x17000196 RID: 406
        // (get) Token: 0x0600035D RID: 861 RVA: 0x00007443 File Offset: 0x00005643
        public string Intent => intent_;

        // Token: 0x17000197 RID: 407
        // (get) Token: 0x0600035E RID: 862 RVA: 0x0000744B File Offset: 0x0000564B
        public bool HasUrl { get; private set; }

        // Token: 0x17000198 RID: 408
        // (get) Token: 0x0600035F RID: 863 RVA: 0x00007453 File Offset: 0x00005653
        public string Url => url_;

        // Token: 0x17000199 RID: 409
        // (get) Token: 0x06000360 RID: 864 RVA: 0x0000745B File Offset: 0x0000565B
        public bool HasType { get; private set; }

        // Token: 0x1700019A RID: 410
        // (get) Token: 0x06000361 RID: 865 RVA: 0x00007463 File Offset: 0x00005663
        public Types.Type Type => type_;

        // Token: 0x1700019B RID: 411
        // (get) Token: 0x06000362 RID: 866 RVA: 0x0000746B File Offset: 0x0000566B
        public bool HasNotifyId { get; private set; }

        // Token: 0x1700019C RID: 412
        // (get) Token: 0x06000363 RID: 867 RVA: 0x00007473 File Offset: 0x00005673
        public string NotifyId => notifyId_;

        // Token: 0x1700019D RID: 413
        // (get) Token: 0x06000364 RID: 868 RVA: 0x0000747B File Offset: 0x0000567B
        public override bool IsInitialized => HasTitle && HasContent;

        // Token: 0x06000365 RID: 869 RVA: 0x00007494 File Offset: 0x00005694
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] notifyInfoFieldNames = _notifyInfoFieldNames;
			if (HasTitle)
			{
				output.WriteString(1, notifyInfoFieldNames[4], Title);
			}
			if (HasContent)
			{
				output.WriteString(2, notifyInfoFieldNames[0], Content);
			}
			if (HasPayload)
			{
				output.WriteString(3, notifyInfoFieldNames[3], Payload);
			}
			if (HasIntent)
			{
				output.WriteString(4, notifyInfoFieldNames[1], Intent);
			}
			if (HasUrl)
			{
				output.WriteString(5, notifyInfoFieldNames[6], Url);
			}
			if (HasType)
			{
				output.WriteEnum(6, notifyInfoFieldNames[5], (int)Type, Type);
			}
			if (HasNotifyId)
			{
				output.WriteString(7, notifyInfoFieldNames[2], NotifyId);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00007570 File Offset: 0x00005770
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
				if (HasTitle)
				{
					num += CodedOutputStream.ComputeStringSize(1, Title);
				}
				if (HasContent)
				{
					num += CodedOutputStream.ComputeStringSize(2, Content);
				}
				if (HasPayload)
				{
					num += CodedOutputStream.ComputeStringSize(3, Payload);
				}
				if (HasIntent)
				{
					num += CodedOutputStream.ComputeStringSize(4, Intent);
				}
				if (HasUrl)
				{
					num += CodedOutputStream.ComputeStringSize(5, Url);
				}
				if (HasType)
				{
					num += CodedOutputStream.ComputeEnumSize(6, (int)Type);
				}
				if (HasNotifyId)
				{
					num += CodedOutputStream.ComputeStringSize(7, NotifyId);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00007643 File Offset: 0x00005843
		public static NotifyInfo ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00007655 File Offset: 0x00005855
		public static NotifyInfo ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00007668 File Offset: 0x00005868
		public static NotifyInfo ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000767A File Offset: 0x0000587A
		public static NotifyInfo ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000768D File Offset: 0x0000588D
		public static NotifyInfo ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000769F File Offset: 0x0000589F
		public static NotifyInfo ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000076B2 File Offset: 0x000058B2
		public static NotifyInfo ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000076C4 File Offset: 0x000058C4
		public static NotifyInfo ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000076D7 File Offset: 0x000058D7
		public static NotifyInfo ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000076E9 File Offset: 0x000058E9
		public static NotifyInfo ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000371 RID: 881 RVA: 0x000076FC File Offset: 0x000058FC
		private NotifyInfo MakeReadOnly()
		{
			return this;
		}

		// Token: 0x06000372 RID: 882 RVA: 0x000076FF File Offset: 0x000058FF
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00007706 File Offset: 0x00005906
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000770E File Offset: 0x0000590E
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00007715 File Offset: 0x00005915
		public static Builder CreateBuilder(NotifyInfo prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00007720 File Offset: 0x00005920
		static NotifyInfo()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x040001FD RID: 509
        private static readonly string[] _notifyInfoFieldNames = new string[]
		{
			"content",
			"intent",
			"notifyId",
			"payload",
			"title",
			"type",
			"url"
		};

		// Token: 0x040001FE RID: 510
		private static readonly uint[] _notifyInfoFieldTags = new uint[]
		{
			18U,
			34U,
			58U,
			26U,
			10U,
			48U,
			42U
		};

		// Token: 0x040001FF RID: 511
		public const int TitleFieldNumber = 1;

        // Token: 0x04000201 RID: 513
        private string title_ = "";

		// Token: 0x04000202 RID: 514
		public const int ContentFieldNumber = 2;

        // Token: 0x04000204 RID: 516
        private string content_ = "";

		// Token: 0x04000205 RID: 517
		public const int PayloadFieldNumber = 3;

        // Token: 0x04000207 RID: 519
        private string payload_ = "";

		// Token: 0x04000208 RID: 520
		public const int IntentFieldNumber = 4;

        // Token: 0x0400020A RID: 522
        private string intent_ = "";

		// Token: 0x0400020B RID: 523
		public const int UrlFieldNumber = 5;

        // Token: 0x0400020D RID: 525
        private string url_ = "";

		// Token: 0x0400020E RID: 526
		public const int TypeFieldNumber = 6;

        // Token: 0x04000210 RID: 528
        private Types.Type type_;

		// Token: 0x04000211 RID: 529
		public const int NotifyIdFieldNumber = 7;

        // Token: 0x04000213 RID: 531
        private string notifyId_ = "";

		// Token: 0x04000214 RID: 532
		private int memoizedSerializedSize = -1;

		// Token: 0x0200007B RID: 123
		[DebuggerNonUserCode]
		public static class Types
		{
			// Token: 0x02000096 RID: 150
			public enum Type
			{
				// Token: 0x0400041D RID: 1053
				_payload,
				// Token: 0x0400041E RID: 1054
				_intent,
				// Token: 0x0400041F RID: 1055
				_url
			}
		}

		// Token: 0x0200007C RID: 124
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<NotifyInfo, Builder>
		{
            // Token: 0x17000418 RID: 1048
            // (get) Token: 0x06000A78 RID: 2680 RVA: 0x00018EC5 File Offset: 0x000170C5
            protected override Builder ThisBuilder => this;

            // Token: 0x06000A79 RID: 2681 RVA: 0x00018EC8 File Offset: 0x000170C8
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000A7A RID: 2682 RVA: 0x00018EE2 File Offset: 0x000170E2
			internal Builder(NotifyInfo cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x06000A7B RID: 2683 RVA: 0x00018EF8 File Offset: 0x000170F8
			private NotifyInfo PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					NotifyInfo other = result;
					result = new NotifyInfo();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x17000419 RID: 1049
            // (get) Token: 0x06000A7C RID: 2684 RVA: 0x00018F34 File Offset: 0x00017134
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x1700041A RID: 1050
            // (get) Token: 0x06000A7D RID: 2685 RVA: 0x00018F41 File Offset: 0x00017141
            protected override NotifyInfo MessageBeingBuilt => PrepareBuilder();

            // Token: 0x06000A7E RID: 2686 RVA: 0x00018F49 File Offset: 0x00017149
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x06000A7F RID: 2687 RVA: 0x00018F5E File Offset: 0x0001715E
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x1700041B RID: 1051
            // (get) Token: 0x06000A80 RID: 2688 RVA: 0x00018F84 File Offset: 0x00017184
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x1700041C RID: 1052
            // (get) Token: 0x06000A81 RID: 2689 RVA: 0x00018F8B File Offset: 0x0001718B
            public override NotifyInfo DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000A82 RID: 2690 RVA: 0x00018F92 File Offset: 0x00017192
            public override NotifyInfo BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x06000A83 RID: 2691 RVA: 0x00018FB5 File Offset: 0x000171B5
			public override Builder MergeFrom(IMessage other)
			{
				if (other is NotifyInfo)
				{
					return MergeFrom((NotifyInfo)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000A84 RID: 2692 RVA: 0x00018FD8 File Offset: 0x000171D8
			public override Builder MergeFrom(NotifyInfo other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasTitle)
				{
					Title = other.Title;
				}
				if (other.HasContent)
				{
					Content = other.Content;
				}
				if (other.HasPayload)
				{
					Payload = other.Payload;
				}
				if (other.HasIntent)
				{
					Intent = other.Intent;
				}
				if (other.HasUrl)
				{
					Url = other.Url;
				}
				if (other.HasType)
				{
					Type = other.Type;
				}
				if (other.HasNotifyId)
				{
					NotifyId = other.NotifyId;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000A85 RID: 2693 RVA: 0x00019090 File Offset: 0x00017290
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000A86 RID: 2694 RVA: 0x000190A0 File Offset: 0x000172A0
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_notifyInfoFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _notifyInfoFieldTags[num2];
                    }
                    if (num <= 26U)
                    {
                        if (num <= 10U)
                        {
                            if (num == 0U)
                            {
                                throw InvalidProtocolBufferException.InvalidTag();
                            }
                            if (num == 10U)
                            {
                                result.HasTitle = input.ReadString(ref result.title_);
                                continue;
                            }
                        }
                        else
                        {
                            if (num == 18U)
                            {
                                result.HasContent = input.ReadString(ref result.content_);
                                continue;
                            }
                            if (num == 26U)
                            {
                                result.HasPayload = input.ReadString(ref result.payload_);
                                continue;
                            }
                        }
                    }
                    else if (num <= 42U)
                    {
                        if (num == 34U)
                        {
                            result.HasIntent = input.ReadString(ref result.intent_);
                            continue;
                        }
                        if (num == 42U)
                        {
                            result.HasUrl = input.ReadString(ref result.url_);
                            continue;
                        }
                    }
                    else if (num != 48U)
                    {
                        if (num == 58U)
                        {
                            result.HasNotifyId = input.ReadString(ref result.notifyId_);
                            continue;
                        }
                    }
                    else
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
                            builder.MergeVarintField(6, (ulong)((long)((int)obj)));
                            continue;
                        }
                        continue;
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

            // Token: 0x1700041D RID: 1053
            // (get) Token: 0x06000A87 RID: 2695 RVA: 0x000192B8 File Offset: 0x000174B8
            public bool HasTitle => result.HasTitle;

            // Token: 0x1700041E RID: 1054
            // (get) Token: 0x06000A88 RID: 2696 RVA: 0x000192C5 File Offset: 0x000174C5
            // (set) Token: 0x06000A89 RID: 2697 RVA: 0x000192D2 File Offset: 0x000174D2
            public string Title
			{
				get
				{
					return result.Title;
				}
				set
				{
					SetTitle(value);
				}
			}

			// Token: 0x06000A8A RID: 2698 RVA: 0x000192DC File Offset: 0x000174DC
			public Builder SetTitle(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasTitle = true;
				result.title_ = value;
				return this;
			}

			// Token: 0x06000A8B RID: 2699 RVA: 0x00019309 File Offset: 0x00017509
			public Builder ClearTitle()
			{
				PrepareBuilder();
				result.HasTitle = false;
				result.title_ = "";
				return this;
			}

            // Token: 0x1700041F RID: 1055
            // (get) Token: 0x06000A8C RID: 2700 RVA: 0x0001932F File Offset: 0x0001752F
            public bool HasContent => result.HasContent;

            // Token: 0x17000420 RID: 1056
            // (get) Token: 0x06000A8D RID: 2701 RVA: 0x0001933C File Offset: 0x0001753C
            // (set) Token: 0x06000A8E RID: 2702 RVA: 0x00019349 File Offset: 0x00017549
            public string Content
			{
				get
				{
					return result.Content;
				}
				set
				{
					SetContent(value);
				}
			}

			// Token: 0x06000A8F RID: 2703 RVA: 0x00019353 File Offset: 0x00017553
			public Builder SetContent(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasContent = true;
				result.content_ = value;
				return this;
			}

			// Token: 0x06000A90 RID: 2704 RVA: 0x00019380 File Offset: 0x00017580
			public Builder ClearContent()
			{
				PrepareBuilder();
				result.HasContent = false;
				result.content_ = "";
				return this;
			}

            // Token: 0x17000421 RID: 1057
            // (get) Token: 0x06000A91 RID: 2705 RVA: 0x000193A6 File Offset: 0x000175A6
            public bool HasPayload => result.HasPayload;

            // Token: 0x17000422 RID: 1058
            // (get) Token: 0x06000A92 RID: 2706 RVA: 0x000193B3 File Offset: 0x000175B3
            // (set) Token: 0x06000A93 RID: 2707 RVA: 0x000193C0 File Offset: 0x000175C0
            public string Payload
			{
				get
				{
					return result.Payload;
				}
				set
				{
					SetPayload(value);
				}
			}

			// Token: 0x06000A94 RID: 2708 RVA: 0x000193CA File Offset: 0x000175CA
			public Builder SetPayload(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasPayload = true;
				result.payload_ = value;
				return this;
			}

			// Token: 0x06000A95 RID: 2709 RVA: 0x000193F7 File Offset: 0x000175F7
			public Builder ClearPayload()
			{
				PrepareBuilder();
				result.HasPayload = false;
				result.payload_ = "";
				return this;
			}

            // Token: 0x17000423 RID: 1059
            // (get) Token: 0x06000A96 RID: 2710 RVA: 0x0001941D File Offset: 0x0001761D
            public bool HasIntent => result.HasIntent;

            // Token: 0x17000424 RID: 1060
            // (get) Token: 0x06000A97 RID: 2711 RVA: 0x0001942A File Offset: 0x0001762A
            // (set) Token: 0x06000A98 RID: 2712 RVA: 0x00019437 File Offset: 0x00017637
            public string Intent
			{
				get
				{
					return result.Intent;
				}
				set
				{
					SetIntent(value);
				}
			}

			// Token: 0x06000A99 RID: 2713 RVA: 0x00019441 File Offset: 0x00017641
			public Builder SetIntent(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasIntent = true;
				result.intent_ = value;
				return this;
			}

			// Token: 0x06000A9A RID: 2714 RVA: 0x0001946E File Offset: 0x0001766E
			public Builder ClearIntent()
			{
				PrepareBuilder();
				result.HasIntent = false;
				result.intent_ = "";
				return this;
			}

            // Token: 0x17000425 RID: 1061
            // (get) Token: 0x06000A9B RID: 2715 RVA: 0x00019494 File Offset: 0x00017694
            public bool HasUrl => result.HasUrl;

            // Token: 0x17000426 RID: 1062
            // (get) Token: 0x06000A9C RID: 2716 RVA: 0x000194A1 File Offset: 0x000176A1
            // (set) Token: 0x06000A9D RID: 2717 RVA: 0x000194AE File Offset: 0x000176AE
            public string Url
			{
				get
				{
					return result.Url;
				}
				set
				{
					SetUrl(value);
				}
			}

			// Token: 0x06000A9E RID: 2718 RVA: 0x000194B8 File Offset: 0x000176B8
			public Builder SetUrl(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasUrl = true;
				result.url_ = value;
				return this;
			}

			// Token: 0x06000A9F RID: 2719 RVA: 0x000194E5 File Offset: 0x000176E5
			public Builder ClearUrl()
			{
				PrepareBuilder();
				result.HasUrl = false;
				result.url_ = "";
				return this;
			}

            // Token: 0x17000427 RID: 1063
            // (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0001950B File Offset: 0x0001770B
            public bool HasType => result.HasType;

            // Token: 0x17000428 RID: 1064
            // (get) Token: 0x06000AA1 RID: 2721 RVA: 0x00019518 File Offset: 0x00017718
            // (set) Token: 0x06000AA2 RID: 2722 RVA: 0x00019525 File Offset: 0x00017725
            public Types.Type Type
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

			// Token: 0x06000AA3 RID: 2723 RVA: 0x0001952F File Offset: 0x0001772F
			public Builder SetType(Types.Type value)
			{
				PrepareBuilder();
				result.HasType = true;
				result.type_ = value;
				return this;
			}

			// Token: 0x06000AA4 RID: 2724 RVA: 0x00019551 File Offset: 0x00017751
			public Builder ClearType()
			{
				PrepareBuilder();
				result.HasType = false;
				result.type_ = Types.Type._payload;
				return this;
			}

            // Token: 0x17000429 RID: 1065
            // (get) Token: 0x06000AA5 RID: 2725 RVA: 0x00019573 File Offset: 0x00017773
            public bool HasNotifyId => result.HasNotifyId;

            // Token: 0x1700042A RID: 1066
            // (get) Token: 0x06000AA6 RID: 2726 RVA: 0x00019580 File Offset: 0x00017780
            // (set) Token: 0x06000AA7 RID: 2727 RVA: 0x0001958D File Offset: 0x0001778D
            public string NotifyId
			{
				get
				{
					return result.NotifyId;
				}
				set
				{
					SetNotifyId(value);
				}
			}

			// Token: 0x06000AA8 RID: 2728 RVA: 0x00019597 File Offset: 0x00017797
			public Builder SetNotifyId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasNotifyId = true;
				result.notifyId_ = value;
				return this;
			}

			// Token: 0x06000AA9 RID: 2729 RVA: 0x000195C4 File Offset: 0x000177C4
			public Builder ClearNotifyId()
			{
				PrepareBuilder();
				result.HasNotifyId = false;
				result.notifyId_ = "";
				return this;
			}

			// Token: 0x040003E5 RID: 997
			private bool resultIsReadOnly;

			// Token: 0x040003E6 RID: 998
			private NotifyInfo result;
		}
	}
}
