using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using com.gexin.rp.sdk.dto;
using com.igetui.api.openservice.igetui.sms;
using com.igetui.api.openservice.igetui.template.notify;
using com.igetui.api.openservice.payload;

namespace com.igetui.api.openservice.igetui.template
{
	// Token: 0x0200004C RID: 76
	public class AbstractTemplate : ITemplate
	{
        // Token: 0x17000276 RID: 630
        // (get) Token: 0x060005C8 RID: 1480 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
        // (set) Token: 0x060005C9 RID: 1481 RVA: 0x0000D100 File Offset: 0x0000B300
        public string AppId { get; set; }

        // Token: 0x17000277 RID: 631
        // (get) Token: 0x060005CA RID: 1482 RVA: 0x0000D109 File Offset: 0x0000B309
        // (set) Token: 0x060005CB RID: 1483 RVA: 0x0000D111 File Offset: 0x0000B311
        public string AppKey { get; set; }

        // Token: 0x060005CC RID: 1484 RVA: 0x0000D11C File Offset: 0x0000B31C
        public Transparent getTransparent()
		{
			if (transparent == null)
			{
				Transparent.Builder builder = Transparent.CreateBuilder().SetId("").SetTemplateId(getTemplateId()).SetMessageId("").SetTaskId("").SetAction("pushmessage").AddRangeActionChain(getActionChain()).SetPushInfo(pushInfo).SetAppId(AppId).SetAppKey(AppKey).AddCondition(getDurCondition());
				if (smsInfo != null)
				{
					builder.SetSmsInfo(smsInfo);
				}
				transparent = builder.Build();
			}
			return transparent;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0000D1CB File Offset: 0x0000B3CB
		private string getDurCondition()
		{
			if (duration == null || duration.Equals(""))
			{
				return "";
			}
			return "duration=" + duration;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0000D1FD File Offset: 0x0000B3FD
		public virtual string getTransmissionContent()
		{
			return "";
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0000D204 File Offset: 0x0000B404
		public virtual string getPushType()
		{
			return "";
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0000D20B File Offset: 0x0000B40B
		public virtual List<ActionChain> getActionChain()
		{
			return null;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000D20E File Offset: 0x0000B40E
		public PushInfo getPushInfo()
		{
			return pushInfo.Build();
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0000D21B File Offset: 0x0000B41B
		protected PushInfo.Builder getPushInfoBuilder()
		{
			return pushInfo;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0000D224 File Offset: 0x0000B424
		public void setAPNInfo(Payload apn)
		{
			if (apn == null)
			{
				return;
			}
			string payload = apn.getPayload();
			if (payload == null || payload.Equals(""))
			{
				return;
			}
			int num = Encoding.UTF8.GetBytes(payload).Length;
			if (num > 2048)
			{
				throw new Exception(string.Concat(new object[]
				{
					"APN payload size overlength (",
					num,
					">",
					2048,
					")"
				}));
			}
			pushInfo.SetApnJson(payload).SetInvalidAPN(false);
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0000D2B8 File Offset: 0x0000B4B8
		public void setPushInfo(string actionLocKey, int badge, string message, string sound, string payload, string locKey, string locArgs, string launchImage)
		{
			setPushInfo(actionLocKey, badge, message, sound, payload, locKey, locArgs, launchImage, 0);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0000D2DC File Offset: 0x0000B4DC
		public void setPushInfo(string actionLocKey, int badge, string message, string sound, string payload, string locKey, string locArgs, string launchImage, int contentAvailable)
		{
			APNPayload apnpayload = new APNPayload();
			DictionaryAlertMsg dictionaryAlertMsg = new DictionaryAlertMsg();
			dictionaryAlertMsg.ActionLocKey = actionLocKey;
			dictionaryAlertMsg.Body = message;
			dictionaryAlertMsg.LocKey = locKey;
			dictionaryAlertMsg.addLocArg(locArgs);
			dictionaryAlertMsg.LaunchImage = launchImage;
			apnpayload.AlertMsg = dictionaryAlertMsg;
			apnpayload.Badge = badge;
			apnpayload.Sound = sound;
			if (string.IsNullOrEmpty(payload))
			{
				apnpayload.addCustomMsg("payload", payload);
			}
			apnpayload.ContentAvailable = contentAvailable;
			setAPNInfo(apnpayload);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0000D358 File Offset: 0x0000B558
		public void setDuration(string begin, string end)
		{
			long num = (Convert.ToDateTime(begin).Ticks - 621356256000000000L) / 10000L;
			long num2 = (Convert.ToDateTime(end).Ticks - 621356256000000000L) / 10000L;
			if (num <= 0L || num2 <= 0L)
			{
				throw new Exception("DateFormat: yyyy-MM-dd hh:mm:ss");
			}
			if (num > num2)
			{
				throw new Exception("startTime should be smaller than endTime");
			}
			duration = num + "-" + num2;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0000D3E8 File Offset: 0x0000B5E8
		public void set3rdNotifyInfo(Notify notify)
		{
			if (notify.Title == null || notify.Content == null)
			{
				throw new Exception("notify title or content cannot be null");
			}
			NotifyInfo.Builder builder = NotifyInfo.CreateBuilder().SetTitle(notify.Title).SetContent(notify.Content);
			if (typeNotNull(notify.Type))
			{
				builder.SetType(notify.Type);
				if (!string.IsNullOrEmpty(notify.Payload))
				{
					builder.SetPayload(notify.Payload);
				}
				if (!string.IsNullOrEmpty(notify.Intent))
				{
					if (notify.Intent.Length > GtConfig.getTransIntentLength())
					{
						throw new Exception("intent size overlimit " + GtConfig.getTransIntentLength());
					}
					if (!reg.IsMatch(notify.Intent))
					{
						throw new Exception("intent format error,should start with \"intent:#Intent;\",end with \";end\" ");
					}
					builder.SetIntent(notify.Intent);
				}
				if (!string.IsNullOrEmpty(notify.Url))
				{
					builder.SetUrl(notify.Url);
				}
			}
			pushInfo.SetNotifyInfo(builder.Build()).SetValidNotify(true);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0000D4FC File Offset: 0x0000B6FC
		public void setSmsInfo(sms.SmsInfo smsInfo)
		{
			if (smsInfo == null)
			{
				throw new Exception("smsInfo cannot be empty");
			}
			string smsTemplateId = smsInfo.SmsTemplateId;
			Dictionary<string, string> smsContent = smsInfo.SmsContent;
			long offlineSendtime = smsInfo.OfflineSendtime;
			long smsSendDuration = 0L;
			if (string.IsNullOrEmpty(smsTemplateId))
			{
				throw new Exception("smsTemplateId cannot be empty");
			}
			if (offlineSendtime == 0L)
			{
				throw new Exception("offlineSendtime cannot be empty");
			}
            gexin.rp.sdk.dto.SmsInfo.Builder builder = gexin.rp.sdk.dto.SmsInfo.CreateBuilder().SetSmsChecked(false).SetSmsTemplateId(smsTemplateId).SetOfflineSendtime(offlineSendtime).SetSmsSendDuration(smsSendDuration);
			if (smsInfo.IsApplink)
			{
				if (smsInfo.SmsContent != null && smsInfo.SmsContent.ContainsKey("url") && !string.IsNullOrEmpty(smsInfo.SmsContent["url"]))
				{
					throw new Exception("SmsContent cann not contains key about url");
				}
				builder.AddSmsContent(SmsContentEntry.CreateBuilder().SetKey("applinkIdentification").SetValue("1"));
				string payload = smsInfo.Payload;
				if (payload != null)
				{
					builder.AddSmsContent(SmsContentEntry.CreateBuilder().SetKey("url").SetValue(smsInfo.Url + "?n=" + payload + "&p="));
				}
				else
				{
					builder.AddSmsContent(SmsContentEntry.CreateBuilder().SetKey("url").SetValue(smsInfo.Url + "?p="));
				}
			}
			if (smsContent != null)
			{
				foreach (KeyValuePair<string, string> keyValuePair in smsContent)
				{
					if (string.IsNullOrEmpty(keyValuePair.Key) || string.IsNullOrEmpty(keyValuePair.Value))
					{
						throw new Exception("smsContent entry cannot be null");
					}
					builder.AddSmsContent(SmsContentEntry.CreateBuilder().SetKey(keyValuePair.Key).SetValue(keyValuePair.Value));
				}
			}
			this.smsInfo = builder.Build();
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		private bool typeNotNull(NotifyInfo.Types.Type type)
		{
			bool result = false;
			foreach (object obj in Enum.GetValues(typeof(NotifyInfo.Types.Type)))
			{
				if (((NotifyInfo.Types.Type)obj).Equals(type))
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0000D758 File Offset: 0x0000B958
		protected virtual int getTemplateId()
		{
			return -1;
		}

        // Token: 0x04000339 RID: 825
        private PushInfo.Builder pushInfo = PushInfo.CreateBuilder().SetInvalidAPN(true).SetInvalidMPN(true);

		// Token: 0x0400033A RID: 826
		private gexin.rp.sdk.dto.SmsInfo smsInfo;

		// Token: 0x0400033B RID: 827
		private string duration;

		// Token: 0x0400033C RID: 828
		private Transparent transparent;

		// Token: 0x0400033D RID: 829
		private Regex reg = new Regex("^(intent:#Intent;).*(;end)$");
	}
}
