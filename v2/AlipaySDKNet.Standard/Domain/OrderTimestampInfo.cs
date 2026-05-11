using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OrderTimestampInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderTimestampInfo : AopObject
    {
        /// <summary>
        /// 订单取消时间
        /// </summary>
        [XmlElement("order_cancel_time")]
        public string OrderCancelTime { get; set; }

        /// <summary>
        /// 订单关闭时间
        /// </summary>
        [XmlElement("order_close_time")]
        public string OrderCloseTime { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单发货时间
        /// </summary>
        [XmlElement("order_deliver_time")]
        public string OrderDeliverTime { get; set; }

        /// <summary>
        /// 订单完成时间
        /// </summary>
        [XmlElement("order_finish_time")]
        public string OrderFinishTime { get; set; }

        /// <summary>
        /// 订单最后更新时间
        /// </summary>
        [XmlElement("order_last_update_time")]
        public string OrderLastUpdateTime { get; set; }

        /// <summary>
        /// 订单支付时间
        /// </summary>
        [XmlElement("order_pay_time")]
        public string OrderPayTime { get; set; }

        /// <summary>
        /// 订单收货时间
        /// </summary>
        [XmlElement("order_receive_time")]
        public string OrderReceiveTime { get; set; }
    }
}
