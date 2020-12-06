using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using com.igetui.api.openservice.igetui;
using com.igetui.api.openservice.utils;
using GetuiServerApiSDK.utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace com.igetui.api.openservice
{
	// Token: 0x0200002F RID: 47
	public class IGtPush : IIGtPush, IIGtQuery, IGtAPN
	{
        // Token: 0x1700024E RID: 590
        // (get) Token: 0x060004D1 RID: 1233 RVA: 0x0000A1A3 File Offset: 0x000083A3
        // (set) Token: 0x060004D2 RID: 1234 RVA: 0x0000A1AB File Offset: 0x000083AB
        public string AuthToken { get; set; }

        // Token: 0x060004D3 RID: 1235 RVA: 0x0000A1B4 File Offset: 0x000083B4
        public IGtPush(string domainUrl, string appKey, string masterSecret)
		{
			_IGtPush(domainUrl, appKey, masterSecret, false, null);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0000A1C7 File Offset: 0x000083C7
		public IGtPush(string appKey, string masterSecret, bool useSSL)
		{
			_IGtPush(null, appKey, masterSecret, useSSL, null);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0000A1DA File Offset: 0x000083DA
		public IGtPush(string domainUrl, string appKey, string masterSecret, ILog log)
		{
			_IGtPush(domainUrl, appKey, masterSecret, false, log);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0000A1EE File Offset: 0x000083EE
		public IGtPush(string appKey, string masterSecret, bool useSSL, ILog log)
		{
			_IGtPush(null, appKey, masterSecret, useSSL, log);
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0000A202 File Offset: 0x00008402
		public void writeinfolog(ILog log, params object[] values)
		{
			if (log != null)
			{
				log.info(values);
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0000A20E File Offset: 0x0000840E
		public void writedebuglog(ILog log, params object[] values)
		{
			if (log != null)
			{
				log.debug(values);
			}
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0000A21A File Offset: 0x0000841A
		public void writeerrorlog(ILog log, Exception e, params object[] values)
		{
			if (log != null)
			{
				log.error(e, values);
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0000A227 File Offset: 0x00008427
		public void writeslowlog(ILog log, params object[] values)
		{
			if (log != null)
			{
				log.slow(values);
			}
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0000A234 File Offset: 0x00008434
		private void _IGtPush(string domainUrl, string appKey, string masterSecret, bool useSSL, ILog log)
		{
			this.appKey = appKey;
			this.masterSecret = masterSecret;
			this.log = log;
			HttpProxy httpProxy = new HttpProxy(new IGtHttpProxy());
			this.httpProxy = httpProxy;
			int defaultConnectionLimit = ServicePointManager.DefaultConnectionLimit;
			writeslowlog(log, new object[]
			{
				"DefaultConnectionLimit:" + defaultConnectionLimit
			});
			if (defaultConnectionLimit < 100)
			{
				ServicePointManager.DefaultConnectionLimit = 1024;
				writeinfolog(log, new object[]
				{
					"change to:" + ServicePointManager.DefaultConnectionLimit
				});
			}
			if (domainUrl == null || domainUrl.Trim().Length == 0)
			{
				domailUrlList = GtConfig.getDefaultDomainUrl(useSSL);
			}
			else
			{
				domailUrlList = new List<string>
				{
					domainUrl
				};
			}
			initOSDomain(null);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0000A2FC File Offset: 0x000084FC
		private void initOSDomain(List<string> hosts)
		{
			if (hosts == null || hosts.Count == 0)
			{
				if (!appkeyUrlList.ContainsKey(appKey))
				{
					object obj = thisLock;
					lock (obj)
					{
						if (!appkeyUrlList.ContainsKey(appKey))
						{
							hosts = getOSPushDomainUrlList(domailUrlList, appKey);
							if (hosts != null && hosts.Count > 0)
							{
                                appkeyUrlList.Add(appKey, hosts);
							}
						}
					}
				}
				if (appkeyUrlList.ContainsKey(appKey))
				{
					hosts = appkeyUrlList[appKey];
				}
			}
			if (hosts == null || hosts.Count == 0)
			{
				throw new Exception("Get Push Host Error");
			}
			dynamicGetFastest(hosts);
			if (hosts.Count > 1)
			{
				new Timer(new TimerCallback(dynamicGetFastest), hosts, 600000, 600000);
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0000A40C File Offset: 0x0000860C
		private List<string> getOSPushDomainUrlList(List<string> hosts, string AppKey)
		{
			List<string> list = null;
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"getOSPushDomailUrlListAction"
				},
				{
					"appkey",
					AppKey
				}
			};
			Exception innerException = null;
			foreach (string text in hosts)
			{
				try
				{
					Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(httpPostJSON(text, postData, false));
					if (dictionary != null && "ok".Equals(dictionary["result"]))
					{
						list = CastToList((JArray)dictionary["osList"]);
						if (list != null && list.Count > 0)
						{
							break;
						}
					}
				}
				catch (Exception ex)
				{
					writeerrorlog(log, ex, new object[]
					{
						"get hosts error: :" + text
					});
					innerException = ex;
				}
			}
			if (list == null || list.Count <= 0)
			{
				throw new Exception("Can not get hosts from " + hosts, innerException);
			}
			return list;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0000A52C File Offset: 0x0000872C
		private List<string> CastToList(JArray a)
		{
			List<string> list = new List<string>();
			foreach (object obj in a)
			{
				if (obj is JToken)
				{
					list.Add(obj.ToString());
				}
			}
			return list;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0000A588 File Offset: 0x00008788
		public void dynamicGetFastest(object hostsObj)
		{
			List<string> hosts = appkeyUrlList[appKey];
			ApiUrlRespectUtil.setProxy(httpProxy);
			host = ApiUrlRespectUtil.getFastest(appKey, hosts);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0000A5C8 File Offset: 0x000087C8
		public bool connect()
		{
			DateTime now = DateTime.Now;
			long num = ConvertDateTimeInt(now);
			Dictionary<string, string> param = new Dictionary<string, string>
			{
				{
					"appkey",
					appKey
				},
				{
					"timeStamp",
					string.Concat(num) ?? ""
				},
				{
					"masterSecret",
					masterSecret
				}
			};
			string md5SignValue = getMD5SignValue(param);
			Dictionary<string, object> dictionary = new Dictionary<string, object>
			{
				{
					"action",
					"connect"
				},
				{
					"appkey",
					appKey
				},
				{
					"timeStamp",
					num
				},
				{
					"sign",
					md5SignValue
				},
				{
					"version",
					GtConfig.getSDKVersion()
				}
			};
			JsonConvert.SerializeObject(dictionary);
			string text = httpPost(host, dictionary, false);
			Dictionary<string, object> dictionary2 = JsonConvert.DeserializeObject<Dictionary<string, object>>(text);
			if (text.IndexOf("success") > -1)
			{
				AuthToken = (string)dictionary2["authtoken"];
				return true;
			}
			throw new Exception("appKey or masterSecret is auth failed.");
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0000A6D6 File Offset: 0x000088D6
		public IBatch getBatch()
		{
			return new BatchImpl(appKey, this);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0000A6E4 File Offset: 0x000088E4
		public string pushMessageToSingle(SingleMessage message, Target target)
		{
			return pushMessageToSingle(message, target, null);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0000A6F0 File Offset: 0x000088F0
		public string pushMessageToSingle(SingleMessage message, Target target, string requestId)
		{
			message.Data.getTransparent();
			if (string.IsNullOrEmpty(requestId))
			{
				requestId = Guid.NewGuid().ToString();
			}
			writedebuglog(log, new object[]
			{
				"--------pushMessageToSingle------------"
			});
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"requestId",
					requestId
				},
				{
					"action",
					"pushMessageToSingleAction"
				},
				{
					"appkey",
					appKey
				},
				{
					"appId",
					target.appId
				},
				{
					"alias",
					target.alias
				},
				{
					"clientId",
					target.clientId
				},
				{
					"isOffline",
					message.IsOffline
				},
				{
					"offlineExpireTime",
					message.OfflineExpireTime
				},
				{
					"pushNetWorkType",
					message.PushNetWorkType
				},
				{
					"transmissionContent",
					message.Data.getTransmissionContent()
				},
				{
					"type",
					2
				},
				{
					"pushType",
					message.Data.getPushType()
				},
				{
					"clientData",
					Convert.ToBase64String(message.Data.getTransparent().ToByteArray())
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0000A84C File Offset: 0x00008A4C
		public string pushAPNMessageToSingle(string appId, string deviceToken, SingleMessage message)
		{
			if (deviceToken == null || deviceToken.Length != 64)
			{
				throw new Exception("deviceToken " + deviceToken + " length must be 64");
			}
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"apnPushToSingleAction"
				},
				{
					"appId",
					appId
				},
				{
					"appkey",
					appKey
				},
				{
					"DT",
					deviceToken
				},
				{
					"PI",
					Convert.ToBase64String(message.Data.getPushInfo().ToByteArray())
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0000A8E4 File Offset: 0x00008AE4
		public string pushMessageToApp(AppMessage message, string taskGroupName)
		{
			writedebuglog(log, new object[]
			{
				"\n--------pushMessageToApp------------"
			});
			string contentId = getContentId(message, taskGroupName);
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"pushMessageToAppAction"
				},
				{
					"appkey",
					appKey
				},
				{
					"contentId",
					contentId
				},
				{
					"type",
					2
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0000A95F File Offset: 0x00008B5F
		public string pushMessageToApp(AppMessage message)
		{
			return pushMessageToApp(message, null);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0000A96C File Offset: 0x00008B6C
		public string pushMessageToList(string contentId, List<Target> targetList)
		{
			bool flag = GtConfig.isPushListAsync();
			bool flag2 = GtConfig.isPushListNeedAliasDetails();
			bool flag3 = GtConfig.isPushListNeedDetails();
			writedebuglog(log, new object[]
			{
				"\n--------pushMessageToList------------"
			});
			Dictionary<string, object> dictionary = new Dictionary<string, object>
			{
				{
					"action",
					"pushMessageToListAction"
				},
				{
					"appkey",
					appKey
				},
				{
					"contentId",
					contentId
				},
				{
					"needDetails",
					flag3
				},
				{
					"needAliasDetails",
					flag2
				},
				{
					"async",
					flag
				}
			};
			int num = (flag && !flag3) ? GtConfig.getAsyncListLimit() : GtConfig.getSyncListLimit();
			if (targetList.Count > num)
			{
				return string.Concat(new object[]
				{
					"target size:",
					targetList.Count,
					" beyond the limit:",
					num
				});
			}
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			string value = "";
			foreach (Target target in targetList)
			{
				string clientId = target.clientId;
				string alias = target.alias;
				if (!string.IsNullOrWhiteSpace(clientId))
				{
					list.Add(clientId);
				}
				else if (!string.IsNullOrWhiteSpace(alias))
				{
					list2.Add(alias);
				}
				if (string.IsNullOrWhiteSpace(value))
				{
					value = target.appId;
				}
			}
			dictionary.Add("appId", value);
			dictionary.Add("clientIdList", list);
			dictionary.Add("aliasList", list2);
			dictionary.Add("type", 2);
			return httpPostJSON(host, dictionary, true);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0000AB40 File Offset: 0x00008D40
		public string pushAPNMessageToList(string appId, string contentId, List<string> deviceTokenlist)
		{
			foreach (string text in deviceTokenlist)
			{
				if (text == null || text.Length != 64)
				{
					throw new Exception("deviceToken length must be 64");
				}
			}
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"apnPushToListAction"
				},
				{
					"appkey",
					appKey
				},
				{
					"appId",
					appId
				},
				{
					"contentId",
					contentId
				},
				{
					"DTL",
					deviceTokenlist
				},
				{
					"needDetails",
					GtConfig.isPushListNeedDetails()
				},
				{
					"async",
					GtConfig.isPushListAsync()
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0000AC1C File Offset: 0x00008E1C
		public void pushMessageToList(ListMessage message, IListProvider listProvider, IPushEventListener listener)
		{
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0000AC20 File Offset: 0x00008E20
		public void close()
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"close"
				},
				{
					"appkey",
					appKey
				},
				{
					"version",
					GtConfig.getSDKVersion()
				},
				{
					"authToken",
					AuthToken
				}
			};
			httpPostJSON(postData);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0000AC80 File Offset: 0x00008E80
		public string getContentId(Message message, string taskGroupName)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			if (taskGroupName != null && taskGroupName.Trim() != "")
			{
				if (Encoding.UTF8.GetBytes(taskGroupName).Length > 40)
				{
					throw new Exception("TaskGroupName is OverLimit 40");
				}
				dictionary.Add("taskGroupName", taskGroupName);
			}
			dictionary.Add("action", "getContentIdAction");
			dictionary.Add("appkey", appKey);
			dictionary.Add("clientData", Convert.ToBase64String(message.Data.getTransparent().ToByteArray()));
			dictionary.Add("transmissionContent", message.Data.getTransmissionContent());
			dictionary.Add("isOffline", message.IsOffline);
			dictionary.Add("offlineExpireTime", message.OfflineExpireTime);
			dictionary.Add("pushNetWorkType", message.PushNetWorkType);
			dictionary.Add("pushType", message.Data.getPushType());
			dictionary.Add("type", 2);
			if (message is ListMessage)
			{
				dictionary.Add("contentType", 1);
			}
			if (message is AppMessage)
			{
				dictionary.Add("contentType", 2);
				AppMessage appMessage = (AppMessage)message;
				dictionary.Add("appIdList", appMessage.AppIdList);
				if (appMessage.Conditions == null)
				{
					List<string> phoneTypeList = appMessage.PhoneTypeList;
					List<string> provinceList = appMessage.ProvinceList;
					List<string> tagList = appMessage.TagList;
					dictionary.Add("phoneTypeList", phoneTypeList);
					dictionary.Add("provinceList", provinceList);
					dictionary.Add("tagList", tagList);
				}
				else
				{
					List<Dictionary<string, object>> condition = appMessage.Conditions.getCondition();
					dictionary.Add("conditions", condition);
				}
				dictionary.Add("speed", appMessage.Speed);
				string pushTime = appMessage.PushTime;
				if (!string.IsNullOrEmpty(pushTime))
				{
					dictionary.Add("pushTime", pushTime);
				}
			}
			string text = httpPostJSON(dictionary);
			Console.WriteLine("---------pushMessageToList result-----------" + text);
			ContentInfo contentInfo = JsonConvert.DeserializeObject<ContentInfo>(text);
			string result = contentInfo.result;
			if (result.IndexOf("ok") > -1)
			{
				return contentInfo.contentId;
			}
			writeinfolog(log, new object[]
			{
				"获取 contentId 失败：" + result
			});
			throw new Exception("获取 contentId 失败：" + result);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0000AEF1 File Offset: 0x000090F1
		public string getContentId(ListMessage message)
		{
			return getContentId(message, null);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0000AEFC File Offset: 0x000090FC
		public string getAPNContentId(string appId, ListMessage message)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"apnGetContentIdAction"
				},
				{
					"appkey",
					appKey
				},
				{
					"appId",
					appId
				},
				{
					"PI",
					Convert.ToBase64String(message.Data.getPushInfo().ToByteArray())
				}
			};
			ContentInfo contentInfo = JsonConvert.DeserializeObject<ContentInfo>(httpPostJSON(postData));
			string result = contentInfo.result;
			if (result.IndexOf("ok") > -1)
			{
				return contentInfo.contentId;
			}
			throw new Exception("获取 contentId 失败：" + result);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0000AF95 File Offset: 0x00009195
		public string addCidListToBlk(string appId, List<string> cidList)
		{
			return blackCidList(appId, cidList, 1);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0000AFA0 File Offset: 0x000091A0
		public string restoreCidListFromBlk(string appId, List<string> cidList)
		{
			return blackCidList(appId, cidList, 2);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000AFAC File Offset: 0x000091AC
		public string blackCidList(string appId, List<string> cidList, int optType)
		{
			int maxLenOfBlackCidList = GtConfig.getMaxLenOfBlackCidList();
			if (maxLenOfBlackCidList < cidList.Count)
			{
				Dictionary<string, object> postData = new Dictionary<string, object>
				{
					{
						"result",
						string.Concat(new object[]
						{
							"cid size:",
							cidList.Count,
							" beyond the limit:",
							maxLenOfBlackCidList
						})
					}
				};
				return httpPostJSON(postData);
			}
			Dictionary<string, object> postData2 = new Dictionary<string, object>
			{
				{
					"action",
					"blackCidAction"
				},
				{
					"appkey",
					appKey
				},
				{
					"appId",
					appId
				},
				{
					"cidList",
					cidList
				},
				{
					"optType",
					optType
				}
			};
			return httpPostJSON(postData2);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000B06C File Offset: 0x0000926C
		public bool cancelContentId(string contentId)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"cancleContentIdAction"
				},
				{
					"appkey",
					appKey
				},
				{
					"contentId",
					contentId
				}
			};
			return httpPostJSON(postData).IndexOf("ok") > -1;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0000B0C4 File Offset: 0x000092C4
		public bool stop(string contentId)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"stopTaskAction"
				},
				{
					"appkey",
					appKey
				},
				{
					"contentId",
					contentId
				}
			};
			return httpPostJSON(postData).IndexOf("ok") > -1;
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0000B11B File Offset: 0x0000931B
		public string getPushResultByTaskidList(List<string> taskIdList)
		{
			return getPushActionResultByTaskids(taskIdList, null);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000B128 File Offset: 0x00009328
		public string getPushActionResultByTaskids(List<string> taskIdList, List<string> actionIdList)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"getPushMsgResultByTaskidList"
				},
				{
					"appkey",
					appKey
				},
				{
					"taskIdList",
					taskIdList
				},
				{
					"actionIdList",
					actionIdList
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0000B17B File Offset: 0x0000937B
		public string setBadgeForCID(string badge, string appid, List<string> cidList)
		{
			return setBadge(badge, appid, new List<string>(), cidList);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000B18B File Offset: 0x0000938B
		public string setBadgeForDeviceToken(string badge, string appid, List<string> deviceTokenList)
		{
			return setBadge(badge, appid, deviceTokenList, new List<string>());
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000B19C File Offset: 0x0000939C
		public string setBadge(string badge, string appid, List<string> deviceTokenList, List<string> cidList)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"setBadgeAction"
				},
				{
					"appkey",
					appKey
				},
				{
					"badge",
					badge
				},
				{
					"appid",
					appid
				},
				{
					"deviceToken",
					deviceTokenList
				},
				{
					"cid",
					cidList
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0000B208 File Offset: 0x00009408
		public string getClientIdStatus(string appId, string clientId)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"getClientIdStatusAction"
				},
				{
					"appkey",
					appKey
				},
				{
					"appId",
					appId
				},
				{
					"clientId",
					clientId
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0000B25C File Offset: 0x0000945C
		public string setClientTag(string appId, string clientId, List<string> tags)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"setTagAction"
				},
				{
					"appkey",
					appKey
				},
				{
					"appId",
					appId
				},
				{
					"clientId",
					clientId
				},
				{
					"tagList",
					tags
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0000B2BC File Offset: 0x000094BC
		public string getLast24HoursOnlineUserStatistics(string appId)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"getLast24HoursOnlineUser"
				},
				{
					"appkey",
					appKey
				},
				{
					"appId",
					appId
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0000B304 File Offset: 0x00009504
		public string getPersonaTags(string appId)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"getPersonaTags"
				},
				{
					"appkey",
					appKey
				},
				{
					"appId",
					appId
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0000B34C File Offset: 0x0000954C
		public string getPushResultByGroupName(string appId, string groupName)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"getPushResultByGroupName"
				},
				{
					"appkey",
					appKey
				},
				{
					"appId",
					appId
				},
				{
					"groupName",
					groupName
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0000B3A0 File Offset: 0x000095A0
		public string getPushResult(string contentId)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"getPushMsgResult"
				},
				{
					"appkey",
					appKey
				},
				{
					"taskId",
					contentId
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0000B3E8 File Offset: 0x000095E8
		public string getScheduleTask(string taskId, string appId)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"getScheduleTaskAction"
				},
				{
					"appkey",
					appKey
				},
				{
					"appId",
					appId
				},
				{
					"taskId",
					taskId
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0000B43C File Offset: 0x0000963C
		public string delScheduleTask(string taskId, string appId)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"delScheduleTaskAction"
				},
				{
					"appkey",
					appKey
				},
				{
					"appId",
					appId
				},
				{
					"taskId",
					taskId
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0000B490 File Offset: 0x00009690
		public string getUserTags(string appId, string clientId)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"getUserTags"
				},
				{
					"appkey",
					appKey
				},
				{
					"appId",
					appId
				},
				{
					"clientId",
					clientId
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0000B4E4 File Offset: 0x000096E4
		public string queryAppPushDataByDate(string appId, string date)
		{
			if (!LangUtils.validateDate(date))
			{
				throw new Exception("DateError|" + date);
			}
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"queryAppPushData"
				},
				{
					"appkey",
					appKey
				},
				{
					"appId",
					appId
				},
				{
					"date",
					date
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0000B550 File Offset: 0x00009750
		public string queryAppUserDataByDate(string appId, string date)
		{
			if (!LangUtils.validateDate(date))
			{
				throw new Exception("DateError|" + date);
			}
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"queryAppUserData"
				},
				{
					"appkey",
					appKey
				},
				{
					"appId",
					appId
				},
				{
					"date",
					date
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0000B5BC File Offset: 0x000097BC
		public string bindCidPn(string appId, Dictionary<string, string> cidAndPn)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"bind_cid_pn"
				},
				{
					"appId",
					appId
				},
				{
					"appkey",
					appKey
				},
				{
					"cidpnlist",
					cidAndPn
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0000B610 File Offset: 0x00009810
		public string unbindCidPn(string appId, List<string> cid)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"unbind_cid_pn"
				},
				{
					"appId",
					appId
				},
				{
					"appkey",
					appKey
				},
				{
					"cids",
					cid
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0000B664 File Offset: 0x00009864
		public string queryCidPn(string appId, List<string> cid)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"query_cid_pn"
				},
				{
					"appId",
					appId
				},
				{
					"appkey",
					appKey
				},
				{
					"cids",
					cid
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0000B6B8 File Offset: 0x000098B8
		public string stopSendSms(string appId, string taskId)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"stop_sms"
				},
				{
					"appId",
					appId
				},
				{
					"appkey",
					appKey
				},
				{
					"taskId",
					taskId
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0000B70B File Offset: 0x0000990B
		private string httpPostJSON(Dictionary<string, object> postData)
		{
			return httpPostJSON(host, postData, false);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0000B71C File Offset: 0x0000991C
		public string queryUserCount(string appId, AppConditions conditions)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>
			{
				{
					"action",
					"queryUserCount"
				},
				{
					"appId",
					appId
				},
				{
					"appkey",
					appKey
				}
			};
			if (conditions != null)
			{
				dictionary.Add("conditions", conditions.getCondition());
			}
			return httpPostJSON(dictionary);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0000B778 File Offset: 0x00009978
		public string httpPostJSON(string url, Dictionary<string, object> postData, bool gzip)
		{
			postData.Add("version", GtConfig.getSDKVersion());
			JsonConvert.SerializeObject(postData);
			postData.Add("authToken", AuthToken);
			string text = httpPost(url, postData, gzip);
			if (!string.IsNullOrEmpty(text))
			{
				if (text.IndexOf("sign_error") > -1)
				{
					if (connect())
					{
						postData.Remove("authToken");
						postData.Add("authToken", AuthToken);
						return httpPost(url, postData, gzip);
					}
				}
				else if (text.IndexOf("domain_error") > -1)
				{
					Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(text);
                    appkeyUrlList.Add(appKey, CastToList((JArray)dictionary["osList"]));
					dynamicGetFastest(null);
					return httpPost(host, postData, gzip);
				}
				return text;
			}
			if (postData.ContainsKey("requestId"))
			{
				throw new RequestException((string)postData["requestId"], "Http request exception,address is " + url);
			}
			return text;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0000B880 File Offset: 0x00009A80
		public string getUserCountByTags(string appId, List<string> tagList)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"getUserCountByTags"
				},
				{
					"appkey",
					appKey
				},
				{
					"appId",
					appId
				},
				{
					"tagList",
					tagList
				}
			};
			int tagListLimit = GtConfig.getTagListLimit();
			if (tagListLimit < tagList.Count)
			{
				throw new Exception(string.Concat(new object[]
				{
					"tagList size:",
					tagList.Count,
					"beyond the limit",
					tagListLimit
				}));
			}
			return httpPostJSON(postData);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0000B91C File Offset: 0x00009B1C
		private string httpPost(string postUrl, Dictionary<string, object> paramData, bool gzip)
		{
			string text = (string)paramData["action"];
			string text2 = "";
			int httpTryCount = GtConfig.getHttpTryCount();
			int i = 0;
			while (i <= httpTryCount)
			{
				HttpWebResponse httpWebResponse = null;
				StreamReader streamReader = null;
				Stream stream = null;
				HttpWebRequest httpWebRequest = null;
				try
				{
					Util.SetCertificatePolicy();
					DateTime now = DateTime.Now;
					long num = ConvertDateTimeInt(now);
					httpWebRequest = (HttpWebRequest)WebRequest.Create(new Uri(postUrl));
					WebProxy webProxy = httpProxy.getWebProxy();
					if (webProxy != null)
					{
						httpWebRequest.Proxy = webProxy;
					}
					string text3 = JsonConvert.SerializeObject(paramData);
					byte[] array = Encoding.UTF8.GetBytes(text3);
					if (text != null)
					{
						httpWebRequest.Headers.Add("Gt-Action", text);
					}
					if (gzip)
					{
						httpWebRequest.Headers.Add("Content-Encoding", "gzip");
						httpWebRequest.Headers.Add("Accept-Encoding", "gzip");
						array = Zip(text3);
					}
					httpWebRequest.Method = "POST";
					httpWebRequest.ContentType = "text/html;charset=UTF-8";
					httpWebRequest.Timeout = GtConfig.getHttpConnectionTimeOut();
					httpWebRequest.ReadWriteTimeout = GtConfig.getHttpSoTimeOut();
					httpWebRequest.ContentLength = (long)array.Length;
					httpWebRequest.ProtocolVersion = HttpVersion.Version10;
					httpWebRequest.KeepAlive = true;
					stream = httpWebRequest.GetRequestStream();
					DateTime now2 = DateTime.Now;
					long num2 = ConvertDateTimeInt(now2);
					stream.Write(array, 0, array.Length);
					stream.Close();
					httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					Console.WriteLine("RESPONSE HEADER: " + httpWebResponse.Headers);
					Stream stream2 = httpWebResponse.GetResponseStream();
					if (gzip)
					{
						stream2 = new GZipStream(stream2, CompressionMode.Decompress);
					}
					streamReader = new StreamReader(stream2, Encoding.UTF8);
					text2 = streamReader.ReadToEnd();
					DateTime now3 = DateTime.Now;
					long num3 = ConvertDateTimeInt(now3);
					writedebuglog(log, new object[]
					{
						string.Concat(new object[]
						{
							"GETREQUESTSTREAM:",
							num2 - num,
							",RESPONSE: ",
							num3 - num,
							"ms, ",
							text2
						})
					});
					return text2;
				}
				catch (Exception e)
				{
					i++;
					writeerrorlog(log, e, new object[]
					{
						"HTTP 请求异常信息："
					});
				}
				finally
				{
					if (streamReader != null)
					{
						streamReader.Close();
						streamReader = null;
					}
					if (httpWebResponse != null)
					{
						httpWebResponse.Close();
						httpWebResponse = null;
					}
					if (stream != null)
					{
						stream.Close();
						stream = null;
					}
					if (httpWebRequest != null)
					{
						httpWebRequest.Abort();
						httpWebRequest = null;
					}
				}
			}
			return text2;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x0000BBD8 File Offset: 0x00009DD8
		private long ConvertDateTimeInt(DateTime time)
		{
			DateTime d = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0, 0));
			return (long)Math.Round((DateTime.Now - d).TotalMilliseconds, MidpointRounding.AwayFromZero);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x0000BC1C File Offset: 0x00009E1C
		public string getMD5SignValue(Dictionary<string, string> param)
		{
			new ArrayList().AddRange(param.Keys);
			string s = param["appkey"] + param["timeStamp"] + param["masterSecret"];
			byte[] bytes = new MD5CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(s));
			return bytearray2string(bytes);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0000BC88 File Offset: 0x00009E88
		private string bytearray2string(byte[] bytes)
		{
			string text = "";
			foreach (byte b in bytes)
			{
				text += b.ToString("x2");
			}
			return text;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0000BCC4 File Offset: 0x00009EC4
		public string bindAlias(string appId, string alias, string clientId)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"alias_bind"
				},
				{
					"appkey",
					appKey
				},
				{
					"appid",
					appId
				},
				{
					"alias",
					alias
				},
				{
					"cid",
					clientId
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0000BD24 File Offset: 0x00009F24
		public string bindAlias(string appId, List<Target> targetList)
		{
			List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
			foreach (Target target in targetList)
			{
				Dictionary<string, string> item = new Dictionary<string, string>
				{
					{
						"cid",
						target.clientId
					},
					{
						"alias",
						target.alias
					}
				};
				list.Add(item);
			}
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"alias_bind_list"
				},
				{
					"appkey",
					appKey
				},
				{
					"appid",
					appId
				},
				{
					"aliaslist",
					list
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0000BDE8 File Offset: 0x00009FE8
		public string queryClientId(string appId, string alias)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"alias_query"
				},
				{
					"appkey",
					appKey
				},
				{
					"appid",
					appId
				},
				{
					"alias",
					alias
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0000BE3C File Offset: 0x0000A03C
		public string queryAlias(string appId, string clientId)
		{
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"alias_query"
				},
				{
					"appkey",
					appKey
				},
				{
					"appid",
					appId
				},
				{
					"cid",
					clientId
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0000BE90 File Offset: 0x0000A090
		public string unBindAlias(string appId, string alias, string clientId)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>
			{
				{
					"action",
					"alias_unbind"
				},
				{
					"appkey",
					appKey
				},
				{
					"appid",
					appId
				},
				{
					"alias",
					alias
				}
			};
			if (!string.IsNullOrEmpty(clientId))
			{
				dictionary.Add("cid", clientId);
			}
			return httpPostJSON(dictionary);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0000BEF7 File Offset: 0x0000A0F7
		public string unBindAliasAll(string appId, string alias)
		{
			return unBindAlias(appId, alias, null);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0000BF04 File Offset: 0x0000A104
		public static void CopyTo(Stream src, Stream dest)
		{
			byte[] array = new byte[4096];
			int count;
			while ((count = src.Read(array, 0, array.Length)) != 0)
			{
				dest.Write(array, 0, count);
			}
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x0000BF38 File Offset: 0x0000A138
		public static byte[] Zip(string str)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(str)))
			{
				using (MemoryStream memoryStream2 = new MemoryStream())
				{
					using (GZipStream gzipStream = new GZipStream(memoryStream2, CompressionMode.Compress))
					{
                        CopyTo(memoryStream, gzipStream);
					}
					result = memoryStream2.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0000BFC0 File Offset: 0x0000A1C0
		public static string Unzip(byte[] bytes)
		{
			string @string;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				using (MemoryStream memoryStream2 = new MemoryStream())
				{
					using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
					{
                        CopyTo(gzipStream, memoryStream2);
					}
					@string = Encoding.UTF8.GetString(memoryStream2.ToArray());
				}
			}
			return @string;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0000C048 File Offset: 0x0000A248
		public string pushTagMessage(TagMessage message)
		{
			return pushTagMessage(message, null);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0000C054 File Offset: 0x0000A254
		public string pushTagMessage(TagMessage message, string requestId)
		{
			if (string.IsNullOrEmpty(requestId))
			{
				requestId = Guid.NewGuid().ToString();
			}
			Dictionary<string, object> postData = new Dictionary<string, object>
			{
				{
					"action",
					"pushMessageByTagAction"
				},
				{
					"appkey",
					appKey
				},
				{
					"clientData",
					Convert.ToBase64String(message.Data.getTransparent().ToByteArray())
				},
				{
					"transmissionContent",
					message.Data.getTransmissionContent()
				},
				{
					"isOffline",
					message.IsOffline
				},
				{
					"offlineExpireTime",
					message.OfflineExpireTime
				},
				{
					"pushNetWorkType",
					message.PushNetWorkType
				},
				{
					"appIdList",
					message.AppIdList
				},
				{
					"speed",
					message.Speed
				},
				{
					"requestId",
					requestId
				},
				{
					"tag",
					message.Tag
				}
			};
			return httpPostJSON(postData);
		}

		// Token: 0x040002F6 RID: 758
		private static object thisLock = new object();

		// Token: 0x040002F7 RID: 759
		private string appKey;

		// Token: 0x040002F8 RID: 760
		public string host;

        // Token: 0x040002FA RID: 762
        private string masterSecret;

		// Token: 0x040002FB RID: 763
		private static volatile Dictionary<string, List<string>> appkeyUrlList = new Dictionary<string, List<string>>();

		// Token: 0x040002FC RID: 764
		private List<string> domailUrlList;

		// Token: 0x040002FD RID: 765
		private HttpProxy httpProxy;

		// Token: 0x040002FE RID: 766
		private ILog log;
	}
}
