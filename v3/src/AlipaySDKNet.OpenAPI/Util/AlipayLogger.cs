using System;
using log4net;

namespace AlipaySDKNet.OpenAPI.Util
{
    public class AlipayLogger
    {
        private static readonly ILog errlog = LogManager.GetLogger("sdk.biz.error");

        private static readonly ILog infolog = LogManager.GetLogger("sdk.biz.info");
        
        private static readonly ILog warnlog = LogManager.GetLogger("sdk.biz.info");

        private static bool needEnableLogger = true;

        public static bool NeedEnableLogger
        {
            set => needEnableLogger = value;
        }

        public static void logBizError(string message, Exception ex)
        {
            if (!needEnableLogger)
            {
                return;
            }

            errlog.Error(message, ex);
        }
        
        public static void logBizWarn(string message, Exception ex)
        {
            if (!needEnableLogger)
            {
                return;
            }

            warnlog.Warn(message, ex);
        }

        public static void logBizInfo(string url, string body, string method, string contentType, string requestId)
        {
            if (!needEnableLogger)
            {
                return;
            }

            string logStr = "url:" + url + "^_^"
                            + "method:" + method + "^_^"
                            + "requestId:" + requestId + "^_^"
                            + "contentType:" + contentType + "^_^"
                            + (string.Equals("multipart/form-data", contentType) ? "body[data]:" : "body:") + body;
            infolog.Info(logStr);
        }

        public static void logBizResponseInfo(int statusCode, string responseBody, string traceId)
        {
            if (!needEnableLogger)
            {
                return;
            }

            string logStr = "HTTP response code:" + statusCode + "^_^"
                            + "HTTP response body:" + responseBody + "^_^"
                            + "traceId:" + traceId;
            infolog.Info(logStr);
        }
    }
}