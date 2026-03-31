using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceCompanyclerkBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceCompanyclerkBatchqueryModel : AopObject
    {
        /// <summary>
        /// 员工手机号
        /// </summary>
        [XmlElement("clerk_phone")]
        public string ClerkPhone { get; set; }

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

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页显示数据的条数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
