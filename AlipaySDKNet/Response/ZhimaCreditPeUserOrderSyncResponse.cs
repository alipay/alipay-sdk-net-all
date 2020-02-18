using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeUserOrderSyncResponse.
    /// </summary>
    public class ZhimaCreditPeUserOrderSyncResponse : AopResponse
    {
        /// <summary>
        /// 外部请求幂等号，即接口入参的out_request_no，接口处理完之后回传
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 业务处理是否成功标记，成功返回true，其他情况下返回false
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
