using System;
using System.Text.RegularExpressions;

namespace com.igetui.api.openservice.utils
{
    // Token: 0x0200003E RID: 62
    internal class LangUtils
	{
		// Token: 0x06000559 RID: 1369 RVA: 0x0000C5DF File Offset: 0x0000A7DF
		public static bool validateDate(string date)
		{
			return date != null && REGEX.IsMatch(date) && DateTime.ParseExact(date, "yyyyMMdd", null) < DateTime.Now;
		}

		// Token: 0x04000308 RID: 776
		private static Regex REGEX = new Regex("^(?:(?!0000)[0-9]{4}(?:(?:0[1-9]|1[0-2])(?:0[1-9]|1[0-9]|2[0-8])|(?:0[13-9]|1[0-2])(?:29|30)|(?:0[13578]|1[02])31)|(?:[0-9]{2}(?:0[48]|[2468][048]|[13579][26])|(?:0[48]|[2468][048]|[13579][26])00)0229)$");
	}
}
