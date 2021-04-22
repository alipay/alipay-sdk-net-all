using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CateringStoreDeliveryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CateringStoreDeliveryInfo : AopObject
    {
        /// <summary>
        /// 门店配送范围（单位：公里）。外卖场景必填，其余非必填。
        /// </summary>
        [XmlElement("delivery_area")]
        public string DeliveryArea { get; set; }

        /// <summary>
        /// 配送费用
        /// </summary>
        [XmlElement("delivery_fee")]
        public string DeliveryFee { get; set; }

        /// <summary>
        /// 起送金额。外卖场景必填，其余非必填。
        /// </summary>
        [XmlElement("delivery_threshold")]
        public string DeliveryThreshold { get; set; }
    }
}
