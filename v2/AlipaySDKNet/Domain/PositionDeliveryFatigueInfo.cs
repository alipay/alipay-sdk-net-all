using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PositionDeliveryFatigueInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PositionDeliveryFatigueInfo : AopObject
    {
        /// <summary>
        /// 展位对应的疲劳度信息
        /// </summary>
        [XmlArray("fatigue_model_info")]
        [XmlArrayItem("delivery_fatigue_info")]
        public List<DeliveryFatigueInfo> FatigueModelInfo { get; set; }

        /// <summary>
        /// 展位code
        /// </summary>
        [XmlElement("position_code")]
        public string PositionCode { get; set; }
    }
}
