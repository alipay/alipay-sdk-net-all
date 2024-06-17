using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryFatigueInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryFatigueInfo : AopObject
    {
        /// <summary>
        /// 内容疲劳度
        /// </summary>
        [XmlElement("content_fatigue")]
        public DeliveryFatigueContent ContentFatigue { get; set; }

        /// <summary>
        /// 展位内容埋点配置信息,无任何用户信息
        /// </summary>
        [XmlElement("scm")]
        public string Scm { get; set; }

        /// <summary>
        /// 策略组疲劳度
        /// </summary>
        [XmlArray("strategy_group_fatigue")]
        [XmlArrayItem("strategy_group_fatigue")]
        public List<StrategyGroupFatigue> StrategyGroupFatigue { get; set; }

        /// <summary>
        /// 展位和创意疲劳度
        /// </summary>
        [XmlElement("ucdp_fatigue_info")]
        public string UcdpFatigueInfo { get; set; }
    }
}
