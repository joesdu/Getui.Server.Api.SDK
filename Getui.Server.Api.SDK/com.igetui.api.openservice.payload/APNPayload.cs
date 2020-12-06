using GetuiServerApiSDK.payload;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace com.igetui.api.openservice.payload
{
    // Token: 0x02000040 RID: 64
    public class APNPayload : Payload
	{
        // Token: 0x17000251 RID: 593
        // (get) Token: 0x0600055E RID: 1374 RVA: 0x0000C649 File Offset: 0x0000A849
        // (set) Token: 0x0600055F RID: 1375 RVA: 0x0000C651 File Offset: 0x0000A851
        public int VoicePlayType { get; set; }

        // Token: 0x17000252 RID: 594
        // (get) Token: 0x06000560 RID: 1376 RVA: 0x0000C65A File Offset: 0x0000A85A
        // (set) Token: 0x06000561 RID: 1377 RVA: 0x0000C662 File Offset: 0x0000A862
        public string VoicePlayMessage { get; set; }

        // Token: 0x06000562 RID: 1378 RVA: 0x0000C66B File Offset: 0x0000A86B
        public string getApnsCollapseId()
		{
			return apnsCollapseId;
		}

        // Token: 0x17000253 RID: 595
        // (get) Token: 0x06000563 RID: 1379 RVA: 0x0000C673 File Offset: 0x0000A873
        // (set) Token: 0x06000564 RID: 1380 RVA: 0x0000C67B File Offset: 0x0000A87B
        public Dictionary<string, object> CustomMsg { get; set; } = new Dictionary<string, object>();

        // Token: 0x06000565 RID: 1381 RVA: 0x0000C684 File Offset: 0x0000A884
        public void addCustomMsg(string key, object value)
		{
			if (!string.IsNullOrEmpty(key) && value != null)
			{
				CustomMsg.Add(key, value);
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0000C69E File Offset: 0x0000A89E
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x0000C6A6 File Offset: 0x0000A8A6
		public int Badge
        {
            get => badge;
            set
            {
                if (value > 0)
                {
                    badge = value;
                }
            }
        }

        // Token: 0x17000255 RID: 597
        // (get) Token: 0x06000568 RID: 1384 RVA: 0x0000C6B3 File Offset: 0x0000A8B3
        // (set) Token: 0x06000569 RID: 1385 RVA: 0x0000C6BB File Offset: 0x0000A8BB
        public string Sound
        {
            get => sound;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    sound = "default";
                    return;
                }
                sound = value;
            }
        }

        // Token: 0x17000256 RID: 598
        // (get) Token: 0x0600056A RID: 1386 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
        // (set) Token: 0x0600056B RID: 1387 RVA: 0x0000C6E0 File Offset: 0x0000A8E0
        public int ContentAvailable
        {
            get => contentAvailable;
            set
            {
                if (value > 0)
                {
                    contentAvailable = value;
                }
            }
        }

        // Token: 0x17000257 RID: 599
        // (get) Token: 0x0600056C RID: 1388 RVA: 0x0000C6ED File Offset: 0x0000A8ED
        // (set) Token: 0x0600056D RID: 1389 RVA: 0x0000C6F5 File Offset: 0x0000A8F5
        public string Category { get; set; }

        // Token: 0x17000258 RID: 600
        // (get) Token: 0x0600056E RID: 1390 RVA: 0x0000C6FE File Offset: 0x0000A8FE
        // (set) Token: 0x0600056F RID: 1391 RVA: 0x0000C706 File Offset: 0x0000A906
        public AlertMsg AlertMsg { get; set; }

        // Token: 0x17000259 RID: 601
        // (get) Token: 0x06000570 RID: 1392 RVA: 0x0000C70F File Offset: 0x0000A90F
        // (set) Token: 0x06000571 RID: 1393 RVA: 0x0000C717 File Offset: 0x0000A917
        public List<MultiMedia> MultiMedias { get; set; } = new List<MultiMedia>();

        // Token: 0x06000572 RID: 1394 RVA: 0x0000C720 File Offset: 0x0000A920
        public string getAutoBadge()
		{
			return autoBadge;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0000C728 File Offset: 0x0000A928
		public APNPayload setAutoBadge(string autoBadge)
		{
			Match match = Regex.Match(autoBadge, "^(-|\\+)?\\d+$");
			if (autoBadge == null || !match.Success)
			{
				throw new Exception("autoBadge invalid");
			}
			this.autoBadge = autoBadge;
			return this;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0000C760 File Offset: 0x0000A960
		public string getPayload()
		{
			string result;
			try
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				if (AlertMsg != null && isNotEmpty(AlertMsg.getAlertMsg()))
				{
					dictionary.Add("alert", AlertMsg.getAlertMsg());
				}
				if (autoBadge != null)
				{
					dictionary.Add("autoBadge", autoBadge);
				}
				else if (badge >= 0)
				{
					dictionary.Add("badge", badge);
				}
				if ("com.gexin.ios.silence" != sound)
				{
					dictionary.Add("sound", sound);
				}
				if (!isNotEmpty(dictionary))
				{
					throw new Exception("format error");
				}
				if (contentAvailable > 0)
				{
					dictionary.Add("content-available", contentAvailable);
				}
				if (isNotEmpty(Category))
				{
					dictionary.Add("category", Category);
				}
				Dictionary<string, object> dictionary2 = new Dictionary<string, object>();
				foreach (KeyValuePair<string, object> keyValuePair in CustomMsg)
				{
					dictionary2.Add(keyValuePair.Key, keyValuePair.Value);
				}
				dictionary2.Add("aps", dictionary);
				if (apnsCollapseId != null)
				{
					dictionary2.Add("apns-collapse-id", apnsCollapseId);
				}
				if (MultiMedias != null && MultiMedias.Count > 0)
				{
					dictionary2.Add("_grinfo_", checkMultiMedias());
				}
				if (VoicePlayType == 1)
				{
					dictionary2.Add("_gvp_t_", 1);
				}
				else if (VoicePlayType == 2 && string.IsNullOrEmpty(VoicePlayMessage))
				{
					dictionary2.Add("_gvp_t_", 2);
					dictionary2.Add("_gvp_m_", VoicePlayMessage);
				}
				result = JsonConvert.SerializeObject(dictionary2);
			}
			catch (Exception innerException)
			{
				throw new Exception("create apn payload error", innerException);
			}
			return result;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0000C988 File Offset: 0x0000AB88
		public void setApnsCollapseId(string apnsCollapseId)
		{
			if (!string.IsNullOrEmpty(apnsCollapseId))
			{
				this.apnsCollapseId = apnsCollapseId;
			}
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0000C99C File Offset: 0x0000AB9C
		private List<MultiMedia> checkMultiMedias()
		{
			if (MultiMedias.Count > 3)
			{
				throw new Exception("MultiMedias size overlimit");
			}
			bool flag = false;
			HashSet<string> hashSet = new HashSet<string>();
			foreach (MultiMedia multiMedia in MultiMedias)
			{
				if (multiMedia.rid == null)
				{
					flag = true;
				}
				else
				{
					hashSet.Add(multiMedia.rid);
				}
				bool flag2 = false;
				foreach (object obj in Enum.GetValues(typeof(MultiMedia.MediaType)))
				{
					if (((MultiMedia.MediaType)obj).Equals(multiMedia.type))
					{
						flag2 = true;
					}
				}
				if (!flag2 || multiMedia.url == null)
				{
					throw new Exception("MultiMedia resType and resUrl can't be null");
				}
			}
			if (hashSet.Count != MultiMedias.Count)
			{
				flag = true;
			}
			int num = 0;
			if (flag)
			{
				foreach (MultiMedia multiMedia2 in MultiMedias)
				{
					multiMedia2.rid = "grid-" + num++;
				}
			}
			return MultiMedias;
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0000CB2C File Offset: 0x0000AD2C
		private static bool isNotEmpty(object item)
		{
			return item != null && ((item is string && (string)item != "") || (item is Array && ((Array)item).Length > 0) || (item is List<string> && ((List<string>)item).Count > 0) || (item is Dictionary<string, object> && ((Dictionary<string, object>)item).Count > 0));
		}

		// Token: 0x04000309 RID: 777
		public const string APN_SOUND_SILENCE = "com.gexin.ios.silence";

		// Token: 0x0400030A RID: 778
		public const int PAYLOAD_MAX_BYTES = 2048;

        // Token: 0x0400030D RID: 781
        private string apnsCollapseId;

        // Token: 0x04000310 RID: 784
        private int badge = -1;

		// Token: 0x04000311 RID: 785
		private string sound = "default";

		// Token: 0x04000312 RID: 786
		private int contentAvailable;

        // Token: 0x04000314 RID: 788
        private string autoBadge;
    }
}
