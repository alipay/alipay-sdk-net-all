using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryVO Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryVO : AopObject
    {
        /// <summary>
        /// App配送范围code
        /// </summary>
        [XmlElement("app_delivery_code")]
        public string AppDeliveryCode { get; set; }

        /// <summary>
        /// 配送范围坐标点
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
        public string DeliveryRadius { get; set; }

        /// <summary>
        /// 配送生效范围
        /// </summary>
        [XmlElement("delivery_time")]
        public EffectivePeriodDTO DeliveryTime { get; set; }

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
        /// 来源系统(OPENAPI-接口创建；SAAS-商家端)
        /// </summary>
        [XmlElement("source_system")]
        public string SourceSystem { get; set; }

        /// <summary>
        /// 起送价，单位：元
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
        /// 时段加价规则启用状态
        /// </summary>
        [XmlElement("time_markup_state")]
        public long TimeMarkupState { get; set; }

        /// <summary>
        /// 时段名称
        /// </summary>
        [XmlElement("times_name")]
        public string TimesName { get; set; }

        /// <summary>
        /// 1:常规时段，只能1个，默认00:00~24:00；2:特殊时段，可以多个，特殊时段间不能有重合
        /// </summary>
        [XmlElement("times_type")]
        public long TimesType { get; set; }
    }
}
