using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityBenefit Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityBenefit : AopObject
    {
        /// <summary>
        /// 整体以{"key":[value1, value2]}的结构传参，通过K-V的形式传递，需要与开发人员指定规则code。
        /// </summary>
        [XmlElement("benefit_rule")]
        public string BenefitRule { get; set; }

        /// <summary>
        /// 为支付宝内券的活动id（activityId）
        /// </summary>
        [XmlElement("out_benefit_id")]
        public string OutBenefitId { get; set; }

        /// <summary>
        /// 权益的优先级，需要指定在1-20之间，优先级的值越小，权益展示越靠前
        /// </summary>
        [XmlElement("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// ENABLE("已生效"),      DISABLE("未生效");
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
