using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000024 RID: 36
    [DebuggerNonUserCode]
	public sealed class Target : GeneratedMessage<Target, Target.Builder>
	{
		// Token: 0x06000441 RID: 1089 RVA: 0x00008FE6 File Offset: 0x000071E6
		private Target()
		{
		}

        // Token: 0x1700021F RID: 543
        // (get) Token: 0x06000442 RID: 1090 RVA: 0x00009016 File Offset: 0x00007216
        public static Target DefaultInstance { get; } = new Target().MakeReadOnly();

        // Token: 0x17000220 RID: 544
        // (get) Token: 0x06000443 RID: 1091 RVA: 0x0000901D File Offset: 0x0000721D
        public override Target DefaultInstanceForType => DefaultInstance;

        // Token: 0x17000221 RID: 545
        // (get) Token: 0x06000444 RID: 1092 RVA: 0x00009024 File Offset: 0x00007224
        protected override Target ThisMessage => this;

        // Token: 0x17000222 RID: 546
        // (get) Token: 0x06000445 RID: 1093 RVA: 0x00009027 File Offset: 0x00007227
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_Target__Descriptor;

        // Token: 0x17000223 RID: 547
        // (get) Token: 0x06000446 RID: 1094 RVA: 0x0000902E File Offset: 0x0000722E
        protected override FieldAccessorTable<Target, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_Target__FieldAccessorTable;

        // Token: 0x17000224 RID: 548
        // (get) Token: 0x06000447 RID: 1095 RVA: 0x00009035 File Offset: 0x00007235
        public bool HasAppId { get; private set; }

        // Token: 0x17000225 RID: 549
        // (get) Token: 0x06000448 RID: 1096 RVA: 0x0000903D File Offset: 0x0000723D
        public string AppId => appId_;

        // Token: 0x17000226 RID: 550
        // (get) Token: 0x06000449 RID: 1097 RVA: 0x00009045 File Offset: 0x00007245
        public bool HasClientId { get; private set; }

        // Token: 0x17000227 RID: 551
        // (get) Token: 0x0600044A RID: 1098 RVA: 0x0000904D File Offset: 0x0000724D
        public string ClientId => clientId_;

        // Token: 0x17000228 RID: 552
        // (get) Token: 0x0600044B RID: 1099 RVA: 0x00009055 File Offset: 0x00007255
        public bool HasAlias { get; private set; }

        // Token: 0x17000229 RID: 553
        // (get) Token: 0x0600044C RID: 1100 RVA: 0x0000905D File Offset: 0x0000725D
        public string Alias => alias_;

        // Token: 0x1700022A RID: 554
        // (get) Token: 0x0600044D RID: 1101 RVA: 0x00009065 File Offset: 0x00007265
        public override bool IsInitialized => HasAppId && HasClientId;

        // Token: 0x0600044E RID: 1102 RVA: 0x0000907C File Offset: 0x0000727C
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] targetFieldNames = _targetFieldNames;
			if (HasAppId)
			{
				output.WriteString(1, targetFieldNames[1], AppId);
			}
			if (HasClientId)
			{
				output.WriteString(2, targetFieldNames[2], ClientId);
			}
			if (HasAlias)
			{
				output.WriteString(3, targetFieldNames[0], Alias);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x000090EC File Offset: 0x000072EC
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
				if (HasAppId)
				{
					num += CodedOutputStream.ComputeStringSize(1, AppId);
				}
				if (HasClientId)
				{
					num += CodedOutputStream.ComputeStringSize(2, ClientId);
				}
				if (HasAlias)
				{
					num += CodedOutputStream.ComputeStringSize(3, Alias);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00009163 File Offset: 0x00007363
		public static Target ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00009175 File Offset: 0x00007375
		public static Target ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00009188 File Offset: 0x00007388
		public static Target ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x0000919A File Offset: 0x0000739A
		public static Target ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000091AD File Offset: 0x000073AD
		public static Target ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x000091BF File Offset: 0x000073BF
		public static Target ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x000091D2 File Offset: 0x000073D2
		public static Target ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000091E4 File Offset: 0x000073E4
		public static Target ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000091F7 File Offset: 0x000073F7
		public static Target ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00009209 File Offset: 0x00007409
		public static Target ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0000921C File Offset: 0x0000741C
		private Target MakeReadOnly()
		{
			return this;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0000921F File Offset: 0x0000741F
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00009226 File Offset: 0x00007426
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0000922E File Offset: 0x0000742E
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00009235 File Offset: 0x00007435
		public static Builder CreateBuilder(Target prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00009240 File Offset: 0x00007440
		static Target()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x040002BA RID: 698
        private static readonly string[] _targetFieldNames = new string[]
		{
			"alias",
			"appId",
			"clientId"
		};

		// Token: 0x040002BB RID: 699
		private static readonly uint[] _targetFieldTags = new uint[]
		{
			26U,
			10U,
			18U
		};

		// Token: 0x040002BC RID: 700
		public const int AppIdFieldNumber = 1;

        // Token: 0x040002BE RID: 702
        private string appId_ = "";

		// Token: 0x040002BF RID: 703
		public const int ClientIdFieldNumber = 2;

        // Token: 0x040002C1 RID: 705
        private string clientId_ = "";

		// Token: 0x040002C2 RID: 706
		public const int AliasFieldNumber = 3;

        // Token: 0x040002C4 RID: 708
        private string alias_ = "";

		// Token: 0x040002C5 RID: 709
		private int memoizedSerializedSize = -1;

		// Token: 0x02000083 RID: 131
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<Target, Builder>
		{
            // Token: 0x170004A3 RID: 1187
            // (get) Token: 0x06000BEA RID: 3050 RVA: 0x0001C3A7 File Offset: 0x0001A5A7
            protected override Builder ThisBuilder => this;

            // Token: 0x06000BEB RID: 3051 RVA: 0x0001C3AA File Offset: 0x0001A5AA
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000BEC RID: 3052 RVA: 0x0001C3C4 File Offset: 0x0001A5C4
			internal Builder(Target cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x06000BED RID: 3053 RVA: 0x0001C3DC File Offset: 0x0001A5DC
			private Target PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					Target other = result;
					result = new Target();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x170004A4 RID: 1188
            // (get) Token: 0x06000BEE RID: 3054 RVA: 0x0001C418 File Offset: 0x0001A618
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x170004A5 RID: 1189
            // (get) Token: 0x06000BEF RID: 3055 RVA: 0x0001C425 File Offset: 0x0001A625
            protected override Target MessageBeingBuilt => PrepareBuilder();

            // Token: 0x06000BF0 RID: 3056 RVA: 0x0001C42D File Offset: 0x0001A62D
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x06000BF1 RID: 3057 RVA: 0x0001C442 File Offset: 0x0001A642
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x170004A6 RID: 1190
            // (get) Token: 0x06000BF2 RID: 3058 RVA: 0x0001C468 File Offset: 0x0001A668
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x170004A7 RID: 1191
            // (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0001C46F File Offset: 0x0001A66F
            public override Target DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000BF4 RID: 3060 RVA: 0x0001C476 File Offset: 0x0001A676
            public override Target BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x06000BF5 RID: 3061 RVA: 0x0001C499 File Offset: 0x0001A699
			public override Builder MergeFrom(IMessage other)
			{
				if (other is Target)
				{
					return MergeFrom((Target)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000BF6 RID: 3062 RVA: 0x0001C4BC File Offset: 0x0001A6BC
			public override Builder MergeFrom(Target other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasAppId)
				{
					AppId = other.AppId;
				}
				if (other.HasClientId)
				{
					ClientId = other.ClientId;
				}
				if (other.HasAlias)
				{
					Alias = other.Alias;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000BF7 RID: 3063 RVA: 0x0001C524 File Offset: 0x0001A724
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000BF8 RID: 3064 RVA: 0x0001C534 File Offset: 0x0001A734
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_targetFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _targetFieldTags[num2];
                    }
                    if (num <= 10U)
                    {
                        if (num == 0U)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10U)
                        {
                            result.HasAppId = input.ReadString(ref result.appId_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 18U)
                        {
                            result.HasClientId = input.ReadString(ref result.clientId_);
                            continue;
                        }
                        if (num == 26U)
                        {
                            result.HasAlias = input.ReadString(ref result.alias_);
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

            // Token: 0x170004A8 RID: 1192
            // (get) Token: 0x06000BF9 RID: 3065 RVA: 0x0001C662 File Offset: 0x0001A862
            public bool HasAppId => result.HasAppId;

            // Token: 0x170004A9 RID: 1193
            // (get) Token: 0x06000BFA RID: 3066 RVA: 0x0001C66F File Offset: 0x0001A86F
            // (set) Token: 0x06000BFB RID: 3067 RVA: 0x0001C67C File Offset: 0x0001A87C
            public string AppId
			{
				get
				{
					return result.AppId;
				}
				set
				{
					SetAppId(value);
				}
			}

			// Token: 0x06000BFC RID: 3068 RVA: 0x0001C686 File Offset: 0x0001A886
			public Builder SetAppId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasAppId = true;
				result.appId_ = value;
				return this;
			}

			// Token: 0x06000BFD RID: 3069 RVA: 0x0001C6B3 File Offset: 0x0001A8B3
			public Builder ClearAppId()
			{
				PrepareBuilder();
				result.HasAppId = false;
				result.appId_ = "";
				return this;
			}

            // Token: 0x170004AA RID: 1194
            // (get) Token: 0x06000BFE RID: 3070 RVA: 0x0001C6D9 File Offset: 0x0001A8D9
            public bool HasClientId => result.HasClientId;

            // Token: 0x170004AB RID: 1195
            // (get) Token: 0x06000BFF RID: 3071 RVA: 0x0001C6E6 File Offset: 0x0001A8E6
            // (set) Token: 0x06000C00 RID: 3072 RVA: 0x0001C6F3 File Offset: 0x0001A8F3
            public string ClientId
			{
				get
				{
					return result.ClientId;
				}
				set
				{
					SetClientId(value);
				}
			}

			// Token: 0x06000C01 RID: 3073 RVA: 0x0001C6FD File Offset: 0x0001A8FD
			public Builder SetClientId(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasClientId = true;
				result.clientId_ = value;
				return this;
			}

			// Token: 0x06000C02 RID: 3074 RVA: 0x0001C72A File Offset: 0x0001A92A
			public Builder ClearClientId()
			{
				PrepareBuilder();
				result.HasClientId = false;
				result.clientId_ = "";
				return this;
			}

            // Token: 0x170004AC RID: 1196
            // (get) Token: 0x06000C03 RID: 3075 RVA: 0x0001C750 File Offset: 0x0001A950
            public bool HasAlias => result.HasAlias;

            // Token: 0x170004AD RID: 1197
            // (get) Token: 0x06000C04 RID: 3076 RVA: 0x0001C75D File Offset: 0x0001A95D
            // (set) Token: 0x06000C05 RID: 3077 RVA: 0x0001C76A File Offset: 0x0001A96A
            public string Alias
			{
				get
				{
					return result.Alias;
				}
				set
				{
					SetAlias(value);
				}
			}

			// Token: 0x06000C06 RID: 3078 RVA: 0x0001C774 File Offset: 0x0001A974
			public Builder SetAlias(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasAlias = true;
				result.alias_ = value;
				return this;
			}

			// Token: 0x06000C07 RID: 3079 RVA: 0x0001C7A1 File Offset: 0x0001A9A1
			public Builder ClearAlias()
			{
				PrepareBuilder();
				result.HasAlias = false;
				result.alias_ = "";
				return this;
			}

			// Token: 0x040003EF RID: 1007
			private bool resultIsReadOnly;

			// Token: 0x040003F0 RID: 1008
			private Target result;
		}
	}
}
