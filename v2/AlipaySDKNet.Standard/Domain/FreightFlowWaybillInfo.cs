using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FreightFlowWaybillInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FreightFlowWaybillInfo : AopObject
    {
        /// <summary>
        /// 订单金额,单位;分
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 收货地
        /// </summary>
        [XmlElement("delivery_address")]
        public string DeliveryAddress { get; set; }

        /// <summary>
        /// 接单时间2024-06-18 15:12:36
        /// </summary>
        [XmlElement("order_accept_time")]
        public string OrderAcceptTime { get; set; }

        /// <summary>
        /// 运单完成时间2024-06-18 15:12:36
        /// </summary>
        [XmlElement("order_finish_time")]
        public string OrderFinishTime { get; set; }

        /// <summary>
        /// 下单时间2024-06-18 15:12:36
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 发货地
        /// </summary>
        [XmlElement("shipping_address")]
        public string ShippingAddress { get; set; }
    }
}
