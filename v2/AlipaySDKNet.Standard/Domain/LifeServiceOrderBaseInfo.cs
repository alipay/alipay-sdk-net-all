using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceOrderBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceOrderBaseInfo : AopObject
    {
        /// <summary>
        /// 商家订单id
        /// </summary>
        [XmlElement("merchant_order_id")]
        public string MerchantOrderId { get; set; }

        /// <summary>
        /// 订单下单时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }
    }
}
