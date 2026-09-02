using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceClerkquotaModifyResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceClerkquotaModifyResponse : AopResponse
    {
        /// <summary>
        /// 额度流水ID
        /// </summary>
        [XmlElement("clerk_quota_id")]
        public string ClerkQuotaId { get; set; }
    }
}
