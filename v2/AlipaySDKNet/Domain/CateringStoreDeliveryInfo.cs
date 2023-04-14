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
        /// 门店配送范围（单位：公里），数值型，精确至小数点两位。
        /// </summary>
        [XmlElement("delivery_area")]
        public string DeliveryArea { get; set; }

        /// <summary>
        /// 配送费用。精确到小数点后1位。
        /// </summary>
        [XmlElement("delivery_fee")]
        public string DeliveryFee { get; set; }

        /// <summary>
        /// 起送金额。精确到小数点后1位。
        /// </summary>
        [XmlElement("delivery_threshold")]
        public string DeliveryThreshold { get; set; }
    }
}
