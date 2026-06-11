using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardTailpaymentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardTailpaymentCreateModel : AopObject
    {
        /// <summary>
        /// 预约品必填； 非预约品，不用填
        /// </summary>
        [XmlElement("main_booking_order_id")]
        public string MainBookingOrderId { get; set; }

        /// <summary>
        /// 原始订单id
        /// </summary>
        [XmlElement("main_order_id")]
        public string MainOrderId { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 单位：小时，默认为24小时
        /// </summary>
        [XmlElement("pay_invalid_hours")]
        public long PayInvalidHours { get; set; }

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
        /// 单位：元
        /// </summary>
        [XmlElement("tail_payment_order_price_yuan")]
        public string TailPaymentOrderPriceYuan { get; set; }
    }
}
