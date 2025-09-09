using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskEmployeeGambleCheckResponse.
    /// </summary>
    public class AlipaySecurityRiskEmployeeGambleCheckResponse : AopResponse
    {
        /// <summary>
        /// 核验token
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
