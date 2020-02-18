using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdPlanCertifyResponse.
    /// </summary>
    public class AlipayCommerceTransportAdPlanCertifyResponse : AopResponse
    {
        /// <summary>
        /// 返回结果  true: 成功  false: 失败
        /// </summary>
        [XmlElement("audit_result")]
        public bool AuditResult { get; set; }

        /// <summary>
        /// BIZ_ERROR中业务错误对应的文案描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
