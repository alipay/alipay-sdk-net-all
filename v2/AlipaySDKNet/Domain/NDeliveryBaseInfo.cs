using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NDeliveryBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NDeliveryBaseInfo : AopObject
    {
        /// <summary>
        /// 推广计划开始时间，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("n_delivery_begin_time")]
        public string NDeliveryBeginTime { get; set; }

        /// <summary>
        /// 推广计划结束时间，格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("n_delivery_end_time")]
        public string NDeliveryEndTime { get; set; }

        /// <summary>
        /// 推广计划名称不会对用户进行表达，只用于商户管理使用。长度需要大于等于3，小于等于20。
        /// </summary>
        [XmlElement("n_delivery_name")]
        public string NDeliveryName { get; set; }
    }
}
