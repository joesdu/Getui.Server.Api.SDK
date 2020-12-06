using System;
using System.Collections.Generic;

namespace com.igetui.api.openservice.payload
{
    // Token: 0x02000043 RID: 67
    public class DictionaryAlertMsg : AlertMsg
	{
        // Token: 0x1700025A RID: 602
        // (get) Token: 0x0600057D RID: 1405 RVA: 0x0000CBF2 File Offset: 0x0000ADF2
        // (set) Token: 0x0600057E RID: 1406 RVA: 0x0000CBFA File Offset: 0x0000ADFA
        public string Title { get; set; }

        // Token: 0x1700025B RID: 603
        // (get) Token: 0x0600057F RID: 1407 RVA: 0x0000CC03 File Offset: 0x0000AE03
        // (set) Token: 0x06000580 RID: 1408 RVA: 0x0000CC0B File Offset: 0x0000AE0B
        public string Body { get; set; }

        // Token: 0x1700025C RID: 604
        // (get) Token: 0x06000581 RID: 1409 RVA: 0x0000CC14 File Offset: 0x0000AE14
        // (set) Token: 0x06000582 RID: 1410 RVA: 0x0000CC1C File Offset: 0x0000AE1C
        public string TitleLocKey { get; set; }

        // Token: 0x1700025D RID: 605
        // (get) Token: 0x06000583 RID: 1411 RVA: 0x0000CC25 File Offset: 0x0000AE25
        // (set) Token: 0x06000584 RID: 1412 RVA: 0x0000CC2D File Offset: 0x0000AE2D
        public List<string> TitleLocArgs { get; set; } = new List<string>();

        // Token: 0x06000585 RID: 1413 RVA: 0x0000CC36 File Offset: 0x0000AE36
        public void addTitleLocArg(string titleLocArg)
		{
			if (!string.IsNullOrEmpty(titleLocArg))
			{
				TitleLocArgs.Add(titleLocArg);
			}
		}

        // Token: 0x1700025E RID: 606
        // (get) Token: 0x06000586 RID: 1414 RVA: 0x0000CC4C File Offset: 0x0000AE4C
        // (set) Token: 0x06000587 RID: 1415 RVA: 0x0000CC54 File Offset: 0x0000AE54
        public string ActionLocKey { get; set; }

        // Token: 0x1700025F RID: 607
        // (get) Token: 0x06000588 RID: 1416 RVA: 0x0000CC5D File Offset: 0x0000AE5D
        // (set) Token: 0x06000589 RID: 1417 RVA: 0x0000CC65 File Offset: 0x0000AE65
        public string LocKey { get; set; }

        // Token: 0x17000260 RID: 608
        // (get) Token: 0x0600058A RID: 1418 RVA: 0x0000CC6E File Offset: 0x0000AE6E
        // (set) Token: 0x0600058B RID: 1419 RVA: 0x0000CC76 File Offset: 0x0000AE76
        public List<string> LocArgs { get; set; } = new List<string>();

        // Token: 0x0600058C RID: 1420 RVA: 0x0000CC7F File Offset: 0x0000AE7F
        public void addLocArg(string locArg)
		{
			if (!string.IsNullOrEmpty(locArg))
			{
				LocArgs.Add(locArg);
			}
		}

        // Token: 0x17000261 RID: 609
        // (get) Token: 0x0600058D RID: 1421 RVA: 0x0000CC95 File Offset: 0x0000AE95
        // (set) Token: 0x0600058E RID: 1422 RVA: 0x0000CC9D File Offset: 0x0000AE9D
        public string LaunchImage { get; set; }

        // Token: 0x0600058F RID: 1423 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
        public object getAlertMsg()
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			if (isNotEmpty(Title))
			{
				dictionary.Add("title", Title);
			}
			if (isNotEmpty(Body))
			{
				dictionary.Add("body", Body);
			}
			if (isNotEmpty(TitleLocKey))
			{
				dictionary.Add("title-loc-key", TitleLocKey);
			}
			if (isNotEmpty(TitleLocArgs))
			{
				dictionary.Add("title-loc-args", TitleLocArgs);
			}
			if (isNotEmpty(ActionLocKey))
			{
				dictionary.Add("action-loc-key", ActionLocKey);
			}
			if (isNotEmpty(LocKey))
			{
				dictionary.Add("loc-key", LocKey);
			}
			if (isNotEmpty(LocArgs))
			{
				dictionary.Add("loc-args", LocArgs);
			}
			if (isNotEmpty(LaunchImage))
			{
				dictionary.Add("launch-image", LaunchImage);
			}
			return dictionary;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0000CDAC File Offset: 0x0000AFAC
		private static bool isNotEmpty(object item)
		{
			return item != null && ((item is string && (string)item != "") || (item is Array && ((Array)item).Length > 0) || (item is List<string> && ((List<string>)item).Count > 0) || (item is Dictionary<string, object> && ((Dictionary<string, object>)item).Count > 0));
		}
    }
}
