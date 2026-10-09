using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationBenefitSingleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationBenefitSingleQueryModel : AopObject
    {
        /// <summary>
        /// 外部权益id，由商家自行指定，需要确保在该商家权益内能保证区分出唯一权益内容。在内券权益中，该值传内券活动ID（activityId）
        /// </summary>
        [XmlElement("out_benefit_id")]
        public string OutBenefitId { get; set; }

        /// <summary>
        /// 卡包模板id
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
