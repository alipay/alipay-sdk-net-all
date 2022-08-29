using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseCreateResponse.
    /// </summary>
    public class AlipayCommerceEcEnterpriseCreateResponse : AopResponse
    {
        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 资金代付签约链接
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
