using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditPayafteruseCreditbizorderOrderModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditPayafteruseCreditbizorderOrderModel : AopObject
    {
        /// <summary>
        /// 只有当传递了order_amount时，该参数才有意义； 1）该参数不传时，默认为ORDER_AMOUNT。 2）传ORDER_AMOUNT时，表示order_amount传入的金额为后付金额，在发起扣款时，最大扣款支付金额为order_amount传入的值； 3）传RISK_AMOUNT时，表示ORDER_AMOUNT传入的金额为风险预估金额，在发起扣款时，最大扣款支付金额为商户签约时约定的上限额度。
        /// </summary>
        [XmlElement("amount_type")]
        public string AmountType { get; set; }

        /// <summary>
        /// 订单描述
        /// </summary>
        [XmlElement("body")]
        public string Body { get; set; }

        /// <summary>
        /// 芝麻外部类目
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 芝麻开通协议号
        /// </summary>
        [XmlElement("credit_agreement_id")]
        public string CreditAgreementId { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 订单金额，该金额为当前订单扣款的累计最大额度。例如，下单时传递10.00，则扣款时最大支付金额为10元。若该参数不传，则默认使用商户签约时约定的上限额度。芝麻速办业务场景（极速回收、极速返利、极速退款等）商户请求时，order_amount必传，且amount_type类型需传递ORDER_AMOUNT。
        /// </summary>
        [XmlElement("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 商户外部订单号，保证不重复
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 产品码，不传默认为CREDIT_PAY_AFTER_USE
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 订单标题。 注意：不可使用特殊字符，如 /，=，& 等。
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }
    }
}
