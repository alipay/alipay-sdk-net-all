using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BenefitInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BenefitInfoDTO : AopObject
    {
        /// <summary>
        /// 商户侧权益描述
        /// </summary>
        [XmlElement("benefit_desc")]
        public string BenefitDesc { get; set; }

        /// <summary>
        /// 商户侧权益ID
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 商户侧权益图片链接
        /// </summary>
        [XmlElement("benefit_img")]
        public string BenefitImg { get; set; }

        /// <summary>
        /// 商户侧权益名称
        /// </summary>
        [XmlElement("benefit_name")]
        public string BenefitName { get; set; }

        /// <summary>
        /// 权益状态 ※需要用户手动领取时设置“未领取”
        /// </summary>
        [XmlElement("benefit_status")]
        public string BenefitStatus { get; set; }
    }
}
