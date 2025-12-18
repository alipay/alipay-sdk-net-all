using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRetailBenefitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRetailBenefitQueryModel : AopObject
    {
        /// <summary>
        /// 活动id，如果为空将忽略该过滤条件
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称pattern,如果为空将忽略该过滤条件
        /// </summary>
        [XmlElement("activity_name_pattern")]
        public string ActivityNamePattern { get; set; }

        /// <summary>
        /// 活动来源
        /// </summary>
        [XmlElement("activity_source")]
        public string ActivitySource { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 页码,默认1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小,默认10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 活动status, 如果为空将忽略该过滤条件
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
