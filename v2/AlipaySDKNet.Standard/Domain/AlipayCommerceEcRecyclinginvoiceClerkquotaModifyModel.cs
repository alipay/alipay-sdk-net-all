using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceClerkquotaModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceClerkquotaModifyModel : AopObject
    {
        /// <summary>
        /// 变更金额（元，正数，支持两位小数）
        /// </summary>
        [XmlElement("change_amount")]
        public string ChangeAmount { get; set; }

        /// <summary>
        /// 变更类型
        /// </summary>
        [XmlElement("change_type")]
        public string ChangeType { get; set; }

        /// <summary>
        /// 企业（商户）营业员ID
        /// </summary>
        [XmlElement("company_clerk_id")]
        public string CompanyClerkId { get; set; }

        /// <summary>
        /// 额度类型，默认为年额度:YEARLY
        /// </summary>
        [XmlElement("quota_type")]
        public string QuotaType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
