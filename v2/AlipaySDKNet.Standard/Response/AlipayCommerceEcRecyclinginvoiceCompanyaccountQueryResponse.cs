using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceCompanyaccountQueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceCompanyaccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 专用账户详细信息
        /// </summary>
        [XmlElement("special_account_info")]
        public SpecialAccountInfo SpecialAccountInfo { get; set; }

        /// <summary>
        /// 企业（商户）转帐账户类型
        /// </summary>
        [XmlElement("special_account_type")]
        public string SpecialAccountType { get; set; }
    }
}
