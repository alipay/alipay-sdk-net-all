using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffLogisticsoutstockSyncResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffLogisticsoutstockSyncResponse : AopResponse
    {
        /// <summary>
        /// 报错编码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 报错描述  =
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 本次调用的requestId
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 调用是否成功（true/false）
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
