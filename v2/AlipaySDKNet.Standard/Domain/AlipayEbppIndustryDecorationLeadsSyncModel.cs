using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryDecorationLeadsSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryDecorationLeadsSyncModel : AopObject
    {
        /// <summary>
        /// 装企名称全称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 装企与客户建联情况
        /// </summary>
        [XmlElement("contact")]
        public DecorationLeadsFeedbackContact Contact { get; set; }

        /// <summary>
        /// 留资业务id，从用户留资数据中可获取
        /// </summary>
        [XmlElement("leads_biz_id")]
        public string LeadsBizId { get; set; }

        /// <summary>
        /// 装企与客户成交信息
        /// </summary>
        [XmlElement("trans_info")]
        public DecorationLeadsFeedbackTransInfo TransInfo { get; set; }
    }
}
