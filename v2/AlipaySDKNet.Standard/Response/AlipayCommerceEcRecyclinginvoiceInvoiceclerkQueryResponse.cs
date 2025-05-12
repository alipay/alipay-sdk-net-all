using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceInvoiceclerkQueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceInvoiceclerkQueryResponse : AopResponse
    {
        /// <summary>
        /// 员工信息列表
        /// </summary>
        [XmlElement("clerk_info_list")]
        public ClerkInfo ClerkInfoList { get; set; }
    }
}
