using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryFatigue Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryFatigue : AopObject
    {
        /// <summary>
        /// 用户动作，点击/曝光
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 展位内容疲劳度
        /// </summary>
        [XmlElement("content_fatigue")]
        public DeliveryFatigueContent ContentFatigue { get; set; }

        /// <summary>
        /// 展位创意疲劳度
        /// </summary>
        [XmlElement("creativity_fatigue")]
        public CreativityFatigue CreativityFatigue { get; set; }

        /// <summary>
        /// 展位代码
        /// </summary>
        [XmlElement("position_code")]
        public string PositionCode { get; set; }

        /// <summary>
        /// 展位内容埋点信息
        /// </summary>
        [XmlElement("scm")]
        public string Scm { get; set; }
    }
}
