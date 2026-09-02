using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceClerkquotarecordQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceClerkquotarecordQueryModel : AopObject
    {
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
        /// 变更结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 页码，默认 1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页条数，默认 20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 变更起始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }
    }
}
