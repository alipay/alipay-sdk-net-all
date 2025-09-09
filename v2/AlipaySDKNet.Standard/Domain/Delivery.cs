using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Delivery Data Structure.
    /// </summary>
    [Serializable]
    public class Delivery : AopObject
    {
        /// <summary>
        /// App配送范围code
        /// </summary>
        [XmlElement("app_delivery_code")]
        public string AppDeliveryCode { get; set; }

        /// <summary>
        /// 配送范围坐标集合
        /// </summary>
        [XmlArray("delivery_point_list")]
        [XmlArrayItem("delivery_point")]
        public List<DeliveryPoint> DeliveryPointList { get; set; }

        /// <summary>
        /// 该配送区域的配送费，单位：元。
        /// </summary>
        [XmlElement("delivery_price")]
        public string DeliveryPrice { get; set; }

        /// <summary>
        /// 配送半径，单位：米
        /// </summary>
        [XmlElement("delivery_radius")]
        public long DeliveryRadius { get; set; }

        /// <summary>
        /// 距离加价规则
        /// </summary>
        [XmlArray("distance_markup_rule_list")]
        [XmlArrayItem("distance_markup_rule_d_t_o")]
        public List<DistanceMarkupRuleDTO> DistanceMarkupRuleList { get; set; }

        /// <summary>
        /// 按距离加价规则启用状态（0-停用，1-启用）
        /// </summary>
        [XmlElement("distance_markup_state")]
        public long DistanceMarkupState { get; set; }

        /// <summary>
        /// 该配送区域的配送费，单位：元。
        /// </summary>
        [XmlElement("start_price")]
        public string StartPrice { get; set; }

        /// <summary>
        /// 时段加价规则
        /// </summary>
        [XmlArray("time_markup_rule_list")]
        [XmlArrayItem("time_markup_rule_d_t_o")]
        public List<TimeMarkupRuleDTO> TimeMarkupRuleList { get; set; }

        /// <summary>
        /// 按时段加价规则启用状态（0-停用，1-启用）
        /// </summary>
        [XmlElement("time_markup_state")]
        public long TimeMarkupState { get; set; }

        /// <summary>
        /// 时段名称
        /// </summary>
        [XmlElement("times_name")]
        public string TimesName { get; set; }
    }
}
