using System;
using System.Collections.Generic;

namespace com.igetui.api.openservice.igetui
{
	// Token: 0x02000046 RID: 70
	public class AppConditions
	{
		// Token: 0x060005A8 RID: 1448 RVA: 0x0000CF1C File Offset: 0x0000B11C
		public AppConditions addCondition(string key, List<string> values, int optType)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("key", key);
			dictionary.Add("values", values);
			dictionary.Add("optType", optType);
			condition.Add(dictionary);
			return this;
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0000CF68 File Offset: 0x0000B168
		public AppConditions addCondition(string key, List<string> values, OptType optType)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			dictionary.Add("key", key);
			dictionary.Add("values", values);
			dictionary.Add("optType", optType);
			condition.Add(dictionary);
			return this;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0000CFB1 File Offset: 0x0000B1B1
		public AppConditions addCondition(string key, List<string> values)
		{
			return addCondition(key, values, 0);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0000CFBC File Offset: 0x0000B1BC
		public List<Dictionary<string, object>> getCondition()
		{
			return condition;
		}

		// Token: 0x04000329 RID: 809
		public static string PHONE_TYPE = "phoneType";

		// Token: 0x0400032A RID: 810
		public static string REGION = "region";

		// Token: 0x0400032B RID: 811
		public static string TAG = "tag";

		// Token: 0x0400032C RID: 812
		private List<Dictionary<string, object>> condition = new List<Dictionary<string, object>>();

		// Token: 0x02000087 RID: 135
		public enum OptType
		{
			// Token: 0x04000401 RID: 1025
			or,
			// Token: 0x04000402 RID: 1026
			and,
			// Token: 0x04000403 RID: 1027
			not
		}
	}
}
