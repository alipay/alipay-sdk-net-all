using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryPositionContentVO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryPositionContentVO : AopObject
    {
        /// <summary>
        /// 展位召回内容的疲劳度相关配置
        /// </summary>
        [XmlElement("content_fatigue")]
        public DeliveryFatigueContent ContentFatigue { get; set; }

        /// <summary>
        /// 创意对应的疲劳度配置信息
        /// </summary>
        [XmlElement("creativity_fatigue")]
        public CreativityFatigue CreativityFatigue { get; set; }

        /// <summary>
        /// 展位图片url
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 展位跳转链接
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 展位内容埋点配置信息,无任何用户信息
        /// </summary>
        [XmlElement("scm")]
        public string Scm { get; set; }
    }
}
