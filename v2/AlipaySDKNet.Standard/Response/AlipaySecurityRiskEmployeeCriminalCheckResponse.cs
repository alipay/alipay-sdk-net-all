using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskEmployeeCriminalCheckResponse.
    /// </summary>
    public class AlipaySecurityRiskEmployeeCriminalCheckResponse : AopResponse
    {
        /// <summary>
        /// 风险核验受理token
        /// </summary>
        [XmlElement("accept_no")]
        public string AcceptNo { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
