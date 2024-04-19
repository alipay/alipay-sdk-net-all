using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotContentSyncResponse.
    /// </summary>
    public class AlipayOpenIotContentSyncResponse : AopResponse
    {
        /// <summary>
        /// 错误说明，错误情况会包含通用错误码中不包含的场景错误信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 同步结果码，根据不同场景可能有所不同
        /// </summary>
        [XmlElement("sync_result_code")]
        public string SyncResultCode { get; set; }

        /// <summary>
        /// 内容同步埋点，内部应用与外部调用的串联埋点
        /// </summary>
        [XmlElement("sync_token")]
        public string SyncToken { get; set; }
    }
}
