using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportEtccardBindConsultResponse.
    /// </summary>
    public class AlipayCommerceTransportEtccardBindConsultResponse : AopResponse
    {
        /// <summary>
        /// 资格校验结果
        /// </summary>
        [XmlElement("check_result")]
        public string CheckResult { get; set; }

        /// <summary>
        /// 资格校验完成后返回认证token
        /// </summary>
        [XmlElement("consult_token")]
        public string ConsultToken { get; set; }
    }
}
