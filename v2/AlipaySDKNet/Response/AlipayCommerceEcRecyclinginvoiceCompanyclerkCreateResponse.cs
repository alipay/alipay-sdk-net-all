using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceCompanyclerkCreateResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceCompanyclerkCreateResponse : AopResponse
    {
        /// <summary>
        /// 企业（商户）营业员ID
        /// </summary>
        [XmlElement("company_clerk_id")]
        public string CompanyClerkId { get; set; }

        /// <summary>
        /// 外部营业员ID
        /// </summary>
        [XmlElement("out_clerk_id")]
        public string OutClerkId { get; set; }
    }
}
