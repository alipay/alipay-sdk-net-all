using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskAuthenticationQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskAuthenticationQueryResponse : AopResponse
    {
        /// <summary>
        /// 身份安全业务相关查询业务信息
        /// </summary>
        [XmlElement("biz_result")]
        public string BizResult { get; set; }
    }
}
