using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentOrderDeliveryInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentOrderDeliveryInfoDTO : AopObject
    {
        /// <summary>
        /// 配送结束时间
        /// </summary>
        [XmlElement("delivery_end_time")]
        public string DeliveryEndTime { get; set; }

        /// <summary>
        /// 配送开始时间
        /// </summary>
        [XmlElement("delivery_start_time")]
        public string DeliveryStartTime { get; set; }

        /// <summary>
        /// 订单履约类型
        /// </summary>
        [XmlElement("delivery_type")]
        public string DeliveryType { get; set; }

        /// <summary>
        /// 自提门店信息
        /// </summary>
        [XmlElement("shop_info")]
        public RentPickupShopInfoDTO ShopInfo { get; set; }
    }
}
