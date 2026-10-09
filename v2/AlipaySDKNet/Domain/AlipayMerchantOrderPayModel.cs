using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantOrderPayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantOrderPayModel : AopObject
    {
        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 相关支付渠道
        /// </summary>
        [XmlElement("payment_biz_type")]
        public string PaymentBizType { get; set; }

        /// <summary>
        /// 如果使用支付宝支付就传入支付宝支付单号
        /// </summary>
        [XmlElement("related_payment_no")]
        public string RelatedPaymentNo { get; set; }
    }
}
