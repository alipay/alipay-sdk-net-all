using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeliveryBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeliveryBaseInfo : AopObject
    {
        /// <summary>
        /// 投放计划开始时间。 格式为：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("delivery_begin_time")]
        public string DeliveryBeginTime { get; set; }

        /// <summary>
        /// 投放计划结束时间。 格式为：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("delivery_end_time")]
        public string DeliveryEndTime { get; set; }

        /// <summary>
        /// 投放计划素材信息。
        /// </summary>
        [XmlElement("delivery_material")]
        public DeliveryMaterial DeliveryMaterial { get; set; }

        /// <summary>
        /// 投放计划名称。 投放计划名称不会对用户进行表达，只用于商户管理使用。长度需要大于等于3，小于20。
        /// </summary>
        [XmlElement("delivery_name")]
        public string DeliveryName { get; set; }
    }
}
