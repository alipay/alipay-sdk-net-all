using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceCompanyclerkModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceCompanyclerkModifyModel : AopObject
    {
        /// <summary>
        /// 员工名称
        /// </summary>
        [XmlElement("clerk_name")]
        public string ClerkName { get; set; }

        /// <summary>
        /// 开票人身份标识
        /// </summary>
        [XmlElement("clerk_no")]
        public string ClerkNo { get; set; }

        /// <summary>
        /// 修改员工权限（全量更新）
        /// </summary>
        [XmlArray("clerk_permit_list")]
        [XmlArrayItem("string")]
        public List<string> ClerkPermitList { get; set; }

        /// <summary>
        /// 员工手机号
        /// </summary>
        [XmlElement("clerk_phone")]
        public string ClerkPhone { get; set; }

        /// <summary>
        /// 企业（商户）营业员ID
        /// </summary>
        [XmlElement("company_clerk_id")]
        public string CompanyClerkId { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
