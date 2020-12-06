using System;

namespace com.igetui.api.openservice
{
	// Token: 0x0200003A RID: 58
	public class RequestException : ApplicationException
	{
		// Token: 0x0600054B RID: 1355 RVA: 0x0000C1EA File Offset: 0x0000A3EA
		public RequestException(string requestId, Exception e) : this(requestId, null, e)
		{
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0000C1F5 File Offset: 0x0000A3F5
		public RequestException(string requestId, string message) : this(requestId, message, null)
		{
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x0000C200 File Offset: 0x0000A400
		public RequestException(string requestId, string message, Exception e) : base(message, e)
		{
			RequestId = requestId;
		}

        // Token: 0x17000250 RID: 592
        // (get) Token: 0x0600054E RID: 1358 RVA: 0x0000C211 File Offset: 0x0000A411
        public string RequestId { get; }
    }
}
