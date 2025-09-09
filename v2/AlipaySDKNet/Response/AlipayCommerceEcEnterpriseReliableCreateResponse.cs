using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcEnterpriseReliableCreateResponse.
    /// </summary>
    public class AlipayCommerceEcEnterpriseReliableCreateResponse : AopResponse
    {
        /// <summary>
        /// 因公付共同账户ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 企业码企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }
    }
}
