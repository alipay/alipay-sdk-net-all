using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseUnsignResponse.
    /// </summary>
    public class AlipayCommerceEcEnterpriseUnsignResponse : AopResponse
    {
        /// <summary>
        /// 入参传的共同账户id，出参也会返回共同账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 解约链接
        /// </summary>
        [XmlElement("unsign_url")]
        public string UnsignUrl { get; set; }
    }
}
