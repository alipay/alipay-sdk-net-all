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
        /// 否 物流类型, POST 平邮, EXPRESS 其他快递, VIRTUAL 虚拟物品, EMS EMS, DIRECT 无需物流。
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }
    }
}
