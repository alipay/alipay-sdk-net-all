using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryDetailPositionContentVO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryDetailPositionContentVO : AopObject
    {
        /// <summary>
        /// 疲劳度信息：展位&创意疲劳度、策略组疲劳度、内容疲劳度
        /// </summary>
        [XmlElement("fatigue_model")]
        public DeliveryFatigueInfo FatigueModel { get; set; }

        /// <summary>
        /// 埋点信息
        /// </summary>
        [XmlElement("scm_model")]
        public string ScmModel { get; set; }

        /// <summary>
        /// 卡片数据
        /// </summary>
        [XmlElement("view_model")]
        public string ViewModel { get; set; }
    }
}
