using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionInremitOrder Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionInremitOrder : AopObject
    {
        /// <summary>
        /// 支付宝生成的单据号
        /// </summary>
        [XmlElement("alipay_payment_id")]
        public string AlipayPaymentId { get; set; }

        /// <summary>
        /// 商户自己的交易单号
        /// </summary>
        [XmlElement("isv_payment_id")]
        public string IsvPaymentId { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_created")]
        public string OrderCreated { get; set; }

        /// <summary>
        /// 订单最新修改时间
        /// </summary>
        [XmlElement("order_modified")]
        public string OrderModified { get; set; }

        /// <summary>
        /// TO_PAY
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 订单状态说明
        /// </summary>
        [XmlElement("order_status_desc")]
        public string OrderStatusDesc { get; set; }

        /// <summary>
        /// 订单金额和币种
        /// </summary>
        [XmlElement("payment_amount")]
        public Money PaymentAmount { get; set; }

        /// <summary>
        /// ISV内部缴费项编号
        /// </summary>
        [XmlElement("payment_item_code")]
        public string PaymentItemCode { get; set; }

        /// <summary>
        /// 学校在支付宝的商户ID号
        /// </summary>
        [XmlElement("school_pid")]
        public string SchoolPid { get; set; }

        /// <summary>
        /// 学生学号
        /// </summary>
        [XmlElement("student_id")]
        public string StudentId { get; set; }
    }
}
