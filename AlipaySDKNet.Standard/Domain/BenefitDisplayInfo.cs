using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitDisplayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitDisplayInfo : AopObject
    {
        /// <summary>
        /// 权益描述
        /// </summary>
        [XmlElement("benefit_description")]
        public string BenefitDescription { get; set; }

        /// <summary>
        /// 权益icon
        /// </summary>
        [XmlElement("benefit_icon_url")]
        public string BenefitIconUrl { get; set; }

        /// <summary>
        /// 权益名称
        /// </summary>
        [XmlElement("benefit_name")]
        public string BenefitName { get; set; }

        /// <summary>
        /// 透传信息
        /// </summary>
        [XmlElement("pass_through_info")]
        public string PassThroughInfo { get; set; }
    }
}
