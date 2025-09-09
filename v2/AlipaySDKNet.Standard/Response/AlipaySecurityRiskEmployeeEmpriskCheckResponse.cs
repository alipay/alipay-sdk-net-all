using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskEmployeeEmpriskCheckResponse.
    /// </summary>
    public class AlipaySecurityRiskEmployeeEmpriskCheckResponse : AopResponse
    {
        /// <summary>
        /// 受理凭证token
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
