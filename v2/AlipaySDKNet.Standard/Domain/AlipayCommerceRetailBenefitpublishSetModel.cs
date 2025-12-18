using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRetailBenefitpublishSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRetailBenefitpublishSetModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 操作员信息
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }
    }
}
