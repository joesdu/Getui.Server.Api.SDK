using Google.ProtocolBuffers;
using Google.ProtocolBuffers.Descriptors;
using Google.ProtocolBuffers.FieldAccess;
using System;
using System.Diagnostics;
using System.IO;

namespace com.gexin.rp.sdk.dto
{
    // Token: 0x02000022 RID: 34
    [DebuggerNonUserCode]
	public sealed class AppStartUp : GeneratedMessage<AppStartUp, AppStartUp.Builder>
	{
		// Token: 0x06000405 RID: 1029 RVA: 0x00008AFF File Offset: 0x00006CFF
		private AppStartUp()
		{
		}

        // Token: 0x17000207 RID: 519
        // (get) Token: 0x06000406 RID: 1030 RVA: 0x00008B2F File Offset: 0x00006D2F
        public static AppStartUp DefaultInstance { get; } = new AppStartUp().MakeReadOnly();

        // Token: 0x17000208 RID: 520
        // (get) Token: 0x06000407 RID: 1031 RVA: 0x00008B36 File Offset: 0x00006D36
        public override AppStartUp DefaultInstanceForType => DefaultInstance;

        // Token: 0x17000209 RID: 521
        // (get) Token: 0x06000408 RID: 1032 RVA: 0x00008B3D File Offset: 0x00006D3D
        protected override AppStartUp ThisMessage => this;

        // Token: 0x1700020A RID: 522
        // (get) Token: 0x06000409 RID: 1033 RVA: 0x00008B40 File Offset: 0x00006D40
        public static MessageDescriptor Descriptor => GtReq.internal__static_com_gexin_rp_sdk_dto_AppStartUp__Descriptor;

        // Token: 0x1700020B RID: 523
        // (get) Token: 0x0600040A RID: 1034 RVA: 0x00008B47 File Offset: 0x00006D47
        protected override FieldAccessorTable<AppStartUp, Builder> InternalFieldAccessors => GtReq.internal__static_com_gexin_rp_sdk_dto_AppStartUp__FieldAccessorTable;

        // Token: 0x1700020C RID: 524
        // (get) Token: 0x0600040B RID: 1035 RVA: 0x00008B4E File Offset: 0x00006D4E
        public bool HasAndroid { get; private set; }

        // Token: 0x1700020D RID: 525
        // (get) Token: 0x0600040C RID: 1036 RVA: 0x00008B56 File Offset: 0x00006D56
        public string Android => android_;

        // Token: 0x1700020E RID: 526
        // (get) Token: 0x0600040D RID: 1037 RVA: 0x00008B5E File Offset: 0x00006D5E
        public bool HasSymbia { get; private set; }

        // Token: 0x1700020F RID: 527
        // (get) Token: 0x0600040E RID: 1038 RVA: 0x00008B66 File Offset: 0x00006D66
        public string Symbia => symbia_;

        // Token: 0x17000210 RID: 528
        // (get) Token: 0x0600040F RID: 1039 RVA: 0x00008B6E File Offset: 0x00006D6E
        public bool HasIos { get; private set; }

        // Token: 0x17000211 RID: 529
        // (get) Token: 0x06000410 RID: 1040 RVA: 0x00008B76 File Offset: 0x00006D76
        public string Ios => ios_;

        // Token: 0x17000212 RID: 530
        // (get) Token: 0x06000411 RID: 1041 RVA: 0x00008B7E File Offset: 0x00006D7E
        public override bool IsInitialized => true;

        // Token: 0x06000412 RID: 1042 RVA: 0x00008B84 File Offset: 0x00006D84
        public override void WriteTo(ICodedOutputStream output)
		{
			int serializedSize = SerializedSize;
			string[] appStartUpFieldNames = _appStartUpFieldNames;
			if (HasAndroid)
			{
				output.WriteString(1, appStartUpFieldNames[0], Android);
			}
			if (HasSymbia)
			{
				output.WriteString(2, appStartUpFieldNames[2], Symbia);
			}
			if (HasIos)
			{
				output.WriteString(3, appStartUpFieldNames[1], Ios);
			}
			UnknownFields.WriteTo(output);
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00008BF4 File Offset: 0x00006DF4
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
				if (HasAndroid)
				{
					num += CodedOutputStream.ComputeStringSize(1, Android);
				}
				if (HasSymbia)
				{
					num += CodedOutputStream.ComputeStringSize(2, Symbia);
				}
				if (HasIos)
				{
					num += CodedOutputStream.ComputeStringSize(3, Ios);
				}
				num += UnknownFields.SerializedSize;
				memoizedSerializedSize = num;
				return num;
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00008C6B File Offset: 0x00006E6B
		public static AppStartUp ParseFrom(ByteString data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00008C7D File Offset: 0x00006E7D
		public static AppStartUp ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00008C90 File Offset: 0x00006E90
		public static AppStartUp ParseFrom(byte[] data)
		{
			return CreateBuilder().MergeFrom(data).BuildParsed();
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00008CA2 File Offset: 0x00006EA2
		public static AppStartUp ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00008CB5 File Offset: 0x00006EB5
		public static AppStartUp ParseFrom(Stream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00008CC7 File Offset: 0x00006EC7
		public static AppStartUp ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00008CDA File Offset: 0x00006EDA
		public static AppStartUp ParseDelimitedFrom(Stream input)
		{
			return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00008CEC File Offset: 0x00006EEC
		public static AppStartUp ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00008CFF File Offset: 0x00006EFF
		public static AppStartUp ParseFrom(ICodedInputStream input)
		{
			return CreateBuilder().MergeFrom(input).BuildParsed();
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00008D11 File Offset: 0x00006F11
		public static AppStartUp ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
		{
			return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00008D24 File Offset: 0x00006F24
		private AppStartUp MakeReadOnly()
		{
			return this;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00008D27 File Offset: 0x00006F27
		public static Builder CreateBuilder()
		{
			return new Builder();
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00008D2E File Offset: 0x00006F2E
		public override Builder ToBuilder()
		{
			return CreateBuilder(this);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00008D36 File Offset: 0x00006F36
		public override Builder CreateBuilderForType()
		{
			return new Builder();
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00008D3D File Offset: 0x00006F3D
		public static Builder CreateBuilder(AppStartUp prototype)
		{
			return new Builder(prototype);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00008D48 File Offset: 0x00006F48
		static AppStartUp()
		{
			FileDescriptor descriptor = GtReq.Descriptor;
		}

        // Token: 0x040002A3 RID: 675
        private static readonly string[] _appStartUpFieldNames = new string[]
		{
			"android",
			"ios",
			"symbia"
		};

		// Token: 0x040002A4 RID: 676
		private static readonly uint[] _appStartUpFieldTags = new uint[]
		{
			10U,
			26U,
			18U
		};

		// Token: 0x040002A5 RID: 677
		public const int AndroidFieldNumber = 1;

        // Token: 0x040002A7 RID: 679
        private string android_ = "";

		// Token: 0x040002A8 RID: 680
		public const int SymbiaFieldNumber = 2;

        // Token: 0x040002AA RID: 682
        private string symbia_ = "";

		// Token: 0x040002AB RID: 683
		public const int IosFieldNumber = 3;

        // Token: 0x040002AD RID: 685
        private string ios_ = "";

		// Token: 0x040002AE RID: 686
		private int memoizedSerializedSize = -1;

		// Token: 0x02000081 RID: 129
		[DebuggerNonUserCode]
		public sealed class Builder : GeneratedBuilder<AppStartUp, Builder>
		{
            // Token: 0x1700048F RID: 1167
            // (get) Token: 0x06000BB3 RID: 2995 RVA: 0x0001BC2A File Offset: 0x00019E2A
            protected override Builder ThisBuilder => this;

            // Token: 0x06000BB4 RID: 2996 RVA: 0x0001BC2D File Offset: 0x00019E2D
            public Builder()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
			}

			// Token: 0x06000BB5 RID: 2997 RVA: 0x0001BC47 File Offset: 0x00019E47
			internal Builder(AppStartUp cloneFrom)
			{
				result = cloneFrom;
				resultIsReadOnly = true;
			}

			// Token: 0x06000BB6 RID: 2998 RVA: 0x0001BC60 File Offset: 0x00019E60
			private AppStartUp PrepareBuilder()
			{
				if (resultIsReadOnly)
				{
					AppStartUp other = result;
					result = new AppStartUp();
					resultIsReadOnly = false;
					MergeFrom(other);
				}
				return result;
			}

            // Token: 0x17000490 RID: 1168
            // (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0001BC9C File Offset: 0x00019E9C
            public override bool IsInitialized => result.IsInitialized;

            // Token: 0x17000491 RID: 1169
            // (get) Token: 0x06000BB8 RID: 3000 RVA: 0x0001BCA9 File Offset: 0x00019EA9
            protected override AppStartUp MessageBeingBuilt => PrepareBuilder();

            // Token: 0x06000BB9 RID: 3001 RVA: 0x0001BCB1 File Offset: 0x00019EB1
            public override Builder Clear()
			{
				result = DefaultInstance;
				resultIsReadOnly = true;
				return this;
			}

			// Token: 0x06000BBA RID: 3002 RVA: 0x0001BCC6 File Offset: 0x00019EC6
			public override Builder Clone()
			{
				if (resultIsReadOnly)
				{
					return new Builder(result);
				}
				return new Builder().MergeFrom(result);
			}

            // Token: 0x17000492 RID: 1170
            // (get) Token: 0x06000BBB RID: 3003 RVA: 0x0001BCEC File Offset: 0x00019EEC
            public override MessageDescriptor DescriptorForType => Descriptor;

            // Token: 0x17000493 RID: 1171
            // (get) Token: 0x06000BBC RID: 3004 RVA: 0x0001BCF3 File Offset: 0x00019EF3
            public override AppStartUp DefaultInstanceForType => DefaultInstance;

            // Token: 0x06000BBD RID: 3005 RVA: 0x0001BCFA File Offset: 0x00019EFA
            public override AppStartUp BuildPartial()
			{
				if (resultIsReadOnly)
				{
					return result;
				}
				resultIsReadOnly = true;
				return result.MakeReadOnly();
			}

			// Token: 0x06000BBE RID: 3006 RVA: 0x0001BD1D File Offset: 0x00019F1D
			public override Builder MergeFrom(IMessage other)
			{
				if (other is AppStartUp)
				{
					return MergeFrom((AppStartUp)other);
				}
				base.MergeFrom(other);
				return this;
			}

			// Token: 0x06000BBF RID: 3007 RVA: 0x0001BD40 File Offset: 0x00019F40
			public override Builder MergeFrom(AppStartUp other)
			{
				if (other == DefaultInstance)
				{
					return this;
				}
				PrepareBuilder();
				if (other.HasAndroid)
				{
					Android = other.Android;
				}
				if (other.HasSymbia)
				{
					Symbia = other.Symbia;
				}
				if (other.HasIos)
				{
					Ios = other.Ios;
				}
				MergeUnknownFields(other.UnknownFields);
				return this;
			}

			// Token: 0x06000BC0 RID: 3008 RVA: 0x0001BDA8 File Offset: 0x00019FA8
			public override Builder MergeFrom(ICodedInputStream input)
			{
				return MergeFrom(input, ExtensionRegistry.Empty);
			}

			// Token: 0x06000BC1 RID: 3009 RVA: 0x0001BDB8 File Offset: 0x00019FB8
			public override Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
			{
				PrepareBuilder();
				UnknownFieldSet.Builder builder = null;
                while (input.ReadTag(out uint num, out string text))
                {
                    if (num == 0U && text != null)
                    {
                        int num2 = Array.BinarySearch(_appStartUpFieldNames, text, StringComparer.Ordinal);
                        if (num2 < 0)
                        {
                            if (builder == null)
                            {
                                builder = UnknownFieldSet.CreateBuilder(UnknownFields);
                            }
                            ParseUnknownField(input, builder, extensionRegistry, num, text);
                            continue;
                        }
                        num = _appStartUpFieldTags[num2];
                    }
                    if (num <= 10U)
                    {
                        if (num == 0U)
                        {
                            throw InvalidProtocolBufferException.InvalidTag();
                        }
                        if (num == 10U)
                        {
                            result.HasAndroid = input.ReadString(ref result.android_);
                            continue;
                        }
                    }
                    else
                    {
                        if (num == 18U)
                        {
                            result.HasSymbia = input.ReadString(ref result.symbia_);
                            continue;
                        }
                        if (num == 26U)
                        {
                            result.HasIos = input.ReadString(ref result.ios_);
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

            // Token: 0x17000494 RID: 1172
            // (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0001BEE6 File Offset: 0x0001A0E6
            public bool HasAndroid => result.HasAndroid;

            // Token: 0x17000495 RID: 1173
            // (get) Token: 0x06000BC3 RID: 3011 RVA: 0x0001BEF3 File Offset: 0x0001A0F3
            // (set) Token: 0x06000BC4 RID: 3012 RVA: 0x0001BF00 File Offset: 0x0001A100
            public string Android
			{
				get
				{
					return result.Android;
				}
				set
				{
					SetAndroid(value);
				}
			}

			// Token: 0x06000BC5 RID: 3013 RVA: 0x0001BF0A File Offset: 0x0001A10A
			public Builder SetAndroid(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasAndroid = true;
				result.android_ = value;
				return this;
			}

			// Token: 0x06000BC6 RID: 3014 RVA: 0x0001BF37 File Offset: 0x0001A137
			public Builder ClearAndroid()
			{
				PrepareBuilder();
				result.HasAndroid = false;
				result.android_ = "";
				return this;
			}

            // Token: 0x17000496 RID: 1174
            // (get) Token: 0x06000BC7 RID: 3015 RVA: 0x0001BF5D File Offset: 0x0001A15D
            public bool HasSymbia => result.HasSymbia;

            // Token: 0x17000497 RID: 1175
            // (get) Token: 0x06000BC8 RID: 3016 RVA: 0x0001BF6A File Offset: 0x0001A16A
            // (set) Token: 0x06000BC9 RID: 3017 RVA: 0x0001BF77 File Offset: 0x0001A177
            public string Symbia
			{
				get
				{
					return result.Symbia;
				}
				set
				{
					SetSymbia(value);
				}
			}

			// Token: 0x06000BCA RID: 3018 RVA: 0x0001BF81 File Offset: 0x0001A181
			public Builder SetSymbia(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasSymbia = true;
				result.symbia_ = value;
				return this;
			}

			// Token: 0x06000BCB RID: 3019 RVA: 0x0001BFAE File Offset: 0x0001A1AE
			public Builder ClearSymbia()
			{
				PrepareBuilder();
				result.HasSymbia = false;
				result.symbia_ = "";
				return this;
			}

            // Token: 0x17000498 RID: 1176
            // (get) Token: 0x06000BCC RID: 3020 RVA: 0x0001BFD4 File Offset: 0x0001A1D4
            public bool HasIos => result.HasIos;

            // Token: 0x17000499 RID: 1177
            // (get) Token: 0x06000BCD RID: 3021 RVA: 0x0001BFE1 File Offset: 0x0001A1E1
            // (set) Token: 0x06000BCE RID: 3022 RVA: 0x0001BFEE File Offset: 0x0001A1EE
            public string Ios
			{
				get
				{
					return result.Ios;
				}
				set
				{
					SetIos(value);
				}
			}

			// Token: 0x06000BCF RID: 3023 RVA: 0x0001BFF8 File Offset: 0x0001A1F8
			public Builder SetIos(string value)
			{
				ThrowHelper.ThrowIfNull(value, "value");
				PrepareBuilder();
				result.HasIos = true;
				result.ios_ = value;
				return this;
			}

			// Token: 0x06000BD0 RID: 3024 RVA: 0x0001C025 File Offset: 0x0001A225
			public Builder ClearIos()
			{
				PrepareBuilder();
				result.HasIos = false;
				result.ios_ = "";
				return this;
			}

			// Token: 0x040003EB RID: 1003
			private bool resultIsReadOnly;

			// Token: 0x040003EC RID: 1004
			private AppStartUp result;
		}
	}
}
