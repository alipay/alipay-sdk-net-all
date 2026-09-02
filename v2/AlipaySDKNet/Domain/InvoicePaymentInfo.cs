using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoicePaymentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoicePaymentInfo : AopObject
    {
        /// <summary>
        /// 业务订单单据金额，以元为单位精确到分
        /// </summary>
        [XmlElement("biz_order_amount")]
        public string BizOrderAmount { get; set; }

        /// <summary>
        /// 业务单号；ALIPAY_SAAS_BIZ_ORDER 时为支付宝 SaaS 业务单号，NON_ALIPAY_SAAS_BIZ_ORDER 时为外部业务单号，平台不解析外部单号
        /// </summary>
        [XmlElement("biz_order_no")]
        public string BizOrderNo { get; set; }

        /// <summary>
        /// 业务单号类型：ALIPAY_SAAS_BIZ_ORDER 、NON_ALIPAY_SAAS_BIZ_ORDER
        /// </summary>
        [XmlElement("biz_order_type")]
        public string BizOrderType { get; set; }

        /// <summary>
        /// 订单支付金额，以元为单位精确到分
        /// </summary>
        [XmlElement("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 实际支付订单号/渠道交易号
        /// </summary>
        [XmlElement("payment_order_no")]
        public string PaymentOrderNo { get; set; }

        /// <summary>
        /// 实际支付渠道类型；与 payment_order_no 成对传入，不替代业务单号类型
        /// </summary>
        [XmlElement("payment_order_type")]
        public string PaymentOrderType { get; set; }
    }
}
