using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace com.igetui.api.openservice.utils
{
    // Token: 0x0200003C RID: 60
    public static class ApnsUtils
	{
		// Token: 0x06000554 RID: 1364 RVA: 0x0000C408 File Offset: 0x0000A608
		public static int validatePayloadLength(string locKey, string locArgs, string message, string actionLocKey, string launchImage, string badge, string sound, string payload, int contentAvailable)
		{
			string s = processPayload(locKey, locArgs, message, actionLocKey, launchImage, badge, sound, payload, contentAvailable);
			int result;
			try
			{
				result = Encoding.UTF8.GetBytes(s).Length;
			}
			catch (Exception innerException)
			{
				throw new Exception("payload json get bytese error", innerException);
			}
			return result;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000C458 File Offset: 0x0000A658
		public static bool validatePayload(string locKey, string locArgs, string message, string actionLocKey, string launchImage, string badge, string sound, string payload, int contentAvailable)
		{
			return validatePayloadLength(locKey, locArgs, message, actionLocKey, launchImage, badge, sound, payload, contentAvailable) <= 256;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000C484 File Offset: 0x0000A684
		private static string processPayload(string locKey, string locArgs, string message, string actionLocKey, string launchImage, string badge, string sound, string payload, int contentAvailable)
		{
			bool flag = false;
            Payload payload2 = new Payload();
			if (locKey != null && locKey.Length > 0)
			{
				payload2.AlertLocKey = locKey;
				if (locArgs != null && locArgs.Length > 0)
				{
					payload2.AlertLocArgs = locArgs.Split(',', StringSplitOptions.None);
				}
				flag = true;
			}
			if (message != null && message.Length > 0)
			{
				payload2.AlertBody = message;
				flag = true;
			}
			if (actionLocKey != null && actionLocKey.Length > 0)
			{
				payload2.AlertActionLocKey = actionLocKey;
			}
			if (launchImage != null && launchImage.Length > 0)
			{
				payload2.AlertLaunchImage = launchImage;
			}
			int num = -1;
			try
			{
				num = int.Parse(badge);
			}
			catch (Exception innerException)
			{
				throw new Exception("unBindAlias失败 {0}", innerException);
			}
			if (num >= 0)
			{
				payload2.Badge = num;
				flag = true;
			}
			if (!string.IsNullOrEmpty(sound))
			{
				payload2.Sound = sound;
			}
			else
			{
				payload2.Sound = "default";
			}
			if (!string.IsNullOrEmpty(payload))
			{
				payload2.addParam("payload", payload);
			}
			if (contentAvailable == 1)
			{
				payload2.ContentAvailable = 1;
			}
			if (!flag)
			{
				throw new Exception("one of the params(locKey,message,badge) must not be null or contentAvailable must be 1");
			}
			string text = payload2.ToString();
			if (text == null)
			{
				throw new Exception("payload json is null");
			}
			return text;
		}

		// Token: 0x02000086 RID: 134
		public class Payload
		{
            // Token: 0x170004C8 RID: 1224
            // (get) Token: 0x06000C52 RID: 3154 RVA: 0x0001D1E5 File Offset: 0x0001B3E5
            // (set) Token: 0x06000C53 RID: 3155 RVA: 0x0001D1ED File Offset: 0x0001B3ED
            public Dictionary<string, object> Paramss { get; set; }

            // Token: 0x170004C9 RID: 1225
            // (get) Token: 0x06000C54 RID: 3156 RVA: 0x0001D1F6 File Offset: 0x0001B3F6
            // (set) Token: 0x06000C55 RID: 3157 RVA: 0x0001D1FE File Offset: 0x0001B3FE
            public string Alert { get; set; }

            // Token: 0x170004CA RID: 1226
            // (get) Token: 0x06000C56 RID: 3158 RVA: 0x0001D207 File Offset: 0x0001B407
            // (set) Token: 0x06000C57 RID: 3159 RVA: 0x0001D20F File Offset: 0x0001B40F
            public int Badge { get; set; }

            // Token: 0x170004CB RID: 1227
            // (get) Token: 0x06000C58 RID: 3160 RVA: 0x0001D218 File Offset: 0x0001B418
            // (set) Token: 0x06000C59 RID: 3161 RVA: 0x0001D220 File Offset: 0x0001B420
            public string Sound { get; set; } = "";

            // Token: 0x170004CC RID: 1228
            // (get) Token: 0x06000C5A RID: 3162 RVA: 0x0001D229 File Offset: 0x0001B429
            // (set) Token: 0x06000C5B RID: 3163 RVA: 0x0001D231 File Offset: 0x0001B431
            public string AlertBody { get; set; }

            // Token: 0x170004CD RID: 1229
            // (get) Token: 0x06000C5C RID: 3164 RVA: 0x0001D23A File Offset: 0x0001B43A
            // (set) Token: 0x06000C5D RID: 3165 RVA: 0x0001D242 File Offset: 0x0001B442
            public string AlertActionLocKey { get; set; }

            // Token: 0x170004CE RID: 1230
            // (get) Token: 0x06000C5E RID: 3166 RVA: 0x0001D24B File Offset: 0x0001B44B
            // (set) Token: 0x06000C5F RID: 3167 RVA: 0x0001D253 File Offset: 0x0001B453
            public string AlertLocKey { get; set; }

            // Token: 0x170004CF RID: 1231
            // (get) Token: 0x06000C60 RID: 3168 RVA: 0x0001D25C File Offset: 0x0001B45C
            // (set) Token: 0x06000C61 RID: 3169 RVA: 0x0001D264 File Offset: 0x0001B464
            public string[] AlertLocArgs { get; set; }

            // Token: 0x170004D0 RID: 1232
            // (get) Token: 0x06000C62 RID: 3170 RVA: 0x0001D26D File Offset: 0x0001B46D
            // (set) Token: 0x06000C63 RID: 3171 RVA: 0x0001D275 File Offset: 0x0001B475
            public string AlertLaunchImage { get; set; }

            // Token: 0x170004D1 RID: 1233
            // (get) Token: 0x06000C64 RID: 3172 RVA: 0x0001D27E File Offset: 0x0001B47E
            // (set) Token: 0x06000C65 RID: 3173 RVA: 0x0001D286 File Offset: 0x0001B486
            public int ContentAvailable { get; set; }

            // Token: 0x06000C66 RID: 3174 RVA: 0x0001D28F File Offset: 0x0001B48F
            public void addParam(string key, object obj)
			{
				if (Paramss == null)
				{
					Paramss = new Dictionary<string, object>();
				}
				if (APS.Equals(key.ToLower()))
				{
					throw new Exception("the key can't be aps");
				}
				Paramss.Add(key, obj);
			}

			// Token: 0x06000C67 RID: 3175 RVA: 0x0001D2D0 File Offset: 0x0001B4D0
			public override string ToString()
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
				if (Alert != null)
				{
					dictionary2.Add("alert", Alert);
				}
				else if (AlertBody != null || AlertLocKey != null)
				{
					Dictionary<string, object> dictionary3 = new Dictionary<string, object>();
					putIntoJson("body", AlertBody, dictionary3);
					putIntoJson("action-loc-key", AlertActionLocKey, dictionary3);
					putIntoJson("loc-key", AlertLocKey, dictionary3);
					putIntoJson("launch-image", AlertLaunchImage, dictionary3);
					if (AlertLocArgs != null)
					{
						List<string> list = new List<string>();
						foreach (string item in AlertLocArgs)
						{
							list.Add(item);
						}
						dictionary3.Add("loc-args", list);
					}
					dictionary2.Add("alert", dictionary3);
				}
				dictionary2.Add("badge", Badge);
				if (!"com.gexin.ios.silence".Equals(Sound))
				{
					putIntoJson("sound", Sound, dictionary2);
				}
				if (ContentAvailable == 1)
				{
					dictionary2.Add("content-available", ContentAvailable);
				}
				dictionary.Add(APS, dictionary2);
				if (Paramss != null)
				{
					foreach (KeyValuePair<string, object> keyValuePair in Paramss)
					{
						dictionary.Add(keyValuePair.Key, keyValuePair.Value);
					}
				}
				string result;
				try
				{
					result = JsonConvert.SerializeObject(dictionary);
				}
				catch (Exception innerException)
				{
					throw new Exception("build apn payload json error", innerException);
				}
				return result;
			}

			// Token: 0x06000C68 RID: 3176 RVA: 0x0001D4A4 File Offset: 0x0001B6A4
			private void putIntoJson(string key, string value, Dictionary<string, object> obj)
			{
				if (value != null)
				{
					obj.Add(key, value);
				}
			}

			// Token: 0x040003F5 RID: 1013
			private static readonly string APS = "aps";
        }
    }
}
