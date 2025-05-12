using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceCompanyclerkQueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceCompanyclerkQueryResponse : AopResponse
    {
        /// <summary>
        /// 员工名称
        /// </summary>
        [XmlElement("clerk_name")]
        public string ClerkName { get; set; }

        /// <summary>
        /// 员工手机号
        /// </summary>
        [XmlElement("clerk_phone")]
        public long ClerkPhone { get; set; }

        /// <summary>
        /// 员工角色
        /// </summary>
        [XmlElement("clerk_role")]
        public string ClerkRole { get; set; }

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
