using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskEmployeeMultiheadCheckResponse.
    /// </summary>
    public class AlipaySecurityRiskEmployeeMultiheadCheckResponse : AopResponse
    {
        /// <summary>
        /// 受理核验token
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
