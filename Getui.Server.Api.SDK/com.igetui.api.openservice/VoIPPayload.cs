using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace com.igetui.api.openservice
{
	// Token: 0x02000039 RID: 57
	public class VoIPPayload : Payload
	{
		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x0000C180 File Offset: 0x0000A380
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x0000C188 File Offset: 0x0000A388
		public string voIPPayload { get; set; }

		// Token: 0x06000549 RID: 1353 RVA: 0x0000C194 File Offset: 0x0000A394
		public string getPayload()
		{
			string voIPPayload = this.voIPPayload;
			if (string.IsNullOrEmpty(voIPPayload))
			{
				throw new Exception("payload cannot be empty");
			}
			return JsonConvert.SerializeObject(new Dictionary<string, object>
			{
				{
					"payload",
					voIPPayload
				},
				{
					"isVoIP",
					1
				}
			});
		}
	}
}
