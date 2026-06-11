using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LifeServiceTailPaymentOrder Data Structure.
    /// </summary>
    [Serializable]
    public class LifeServiceTailPaymentOrder : AopObject
    {
        /// <summary>
        /// 取消原因
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 原始预约单id
        /// </summary>
        [XmlElement("main_booking_order_id")]
        public string MainBookingOrderId { get; set; }

        /// <summary>
        /// 原始订单id
        /// </summary>
        [XmlElement("main_order_id")]
        public string MainOrderId { get; set; }

        /// <summary>
        /// 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("order_success_time")]
        public string OrderSuccessTime { get; set; }

        /// <summary>
        /// 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("pay_invalid_time")]
        public string PayInvalidTime { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [XmlElement("service_desc")]
        public string ServiceDesc { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("service_programs")]
        [XmlArrayItem("life_service_tail_payment_service_program")]
        public List<LifeServiceTailPaymentServiceProgram> ServicePrograms { get; set; }

        /// <summary>
        /// 尾款id
        /// </summary>
        [XmlElement("tail_payment_id")]
        public string TailPaymentId { get; set; }

        /// <summary>
        /// 尾款单id
        /// </summary>
        [XmlElement("tail_payment_order_id")]
        public string TailPaymentOrderId { get; set; }

        /// <summary>
        /// 尾款单金额，单位：元
        /// </summary>
        [XmlElement("tail_payment_order_price_yuan")]
        public string TailPaymentOrderPriceYuan { get; set; }

        /// <summary>
        /// 尾款单状态
        /// </summary>
        [XmlElement("tail_payment_order_status")]
        public string TailPaymentOrderStatus { get; set; }
    }
}
