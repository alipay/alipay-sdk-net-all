using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsInfoDTO : AopObject
    {
        /// <summary>
        /// 配送时间,格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("delivery_time")]
        public string DeliveryTime { get; set; }

        /// <summary>
        /// 物流类型
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }
    }
}
