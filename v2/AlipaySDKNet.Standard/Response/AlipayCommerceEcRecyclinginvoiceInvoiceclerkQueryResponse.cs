using System;
using System.Xml.Serialization;
using System.Collections.Generic;
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

        /// <summary>
        /// 员工信息列表
        /// </summary>
        [XmlArray("clerk_list")]
        [XmlArrayItem("clerk_info")]
        public List<ClerkInfo> ClerkList { get; set; }
    }
}
