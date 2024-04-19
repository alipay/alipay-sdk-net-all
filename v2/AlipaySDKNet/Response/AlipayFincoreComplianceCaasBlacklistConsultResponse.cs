using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceCaasBlacklistConsultResponse.
    /// </summary>
    public class AlipayFincoreComplianceCaasBlacklistConsultResponse : AopResponse
    {
        /// <summary>
        /// result_code + 咨询的结果code + 枚举值：ALLOW（允许，标识未在黑名单中）、NOT_ALLOW（标识在黑名单中）、UN_PROCESS（标识服务降级or未有准确结果，需要调用方兜底处理）
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }
    }
}
