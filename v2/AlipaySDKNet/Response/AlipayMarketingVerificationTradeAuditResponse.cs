using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingVerificationTradeAuditResponse.
    /// </summary>
    public class AlipayMarketingVerificationTradeAuditResponse : AopResponse
    {
        /// <summary>
        /// 审计单id,写操作接口返回
        /// </summary>
        [XmlElement("operation_id")]
        public string OperationId { get; set; }

        /// <summary>
        /// 操作流水号，对应一次提交请求
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
