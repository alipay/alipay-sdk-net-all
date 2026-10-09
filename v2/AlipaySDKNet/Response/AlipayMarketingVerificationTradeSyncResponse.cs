using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingVerificationTradeSyncResponse.
    /// </summary>
    public class AlipayMarketingVerificationTradeSyncResponse : AopResponse
    {
        /// <summary>
        /// 交易信息id,写操作接口返回
        /// </summary>
        [XmlElement("operation_id")]
        public string OperationId { get; set; }

        /// <summary>
        /// 请求流水号，对应每次同步请求
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
