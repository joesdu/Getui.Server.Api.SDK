using System;

namespace GetuiServerApiSDK.utils
{
    public interface ILog
	{
		void info(params object[] values);

		void debug(params object[] values);

		void error(Exception e, params object[] values);
		void slow(params object[] values);
	}
}
