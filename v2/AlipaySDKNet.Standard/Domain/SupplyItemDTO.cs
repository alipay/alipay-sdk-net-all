using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SupplyItemDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SupplyItemDTO : AopObject
    {
        /// <summary>
        /// 是否为兜底供给
        /// </summary>
        [XmlElement("default_supply")]
        public bool DefaultSupply { get; set; }

        /// <summary>
        /// 供给实例ID
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 投放计划ID
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 样式类型
        /// </summary>
        [XmlElement("style_type")]
        public string StyleType { get; set; }

        /// <summary>
        /// 供给ID
        /// </summary>
        [XmlElement("supply_id")]
        public string SupplyId { get; set; }

        /// <summary>
        /// 供给名称
        /// </summary>
        [XmlElement("supply_name")]
        public string SupplyName { get; set; }

        /// <summary>
        /// 供给类型
        /// </summary>
        [XmlElement("supply_type")]
        public string SupplyType { get; set; }
    }
}
