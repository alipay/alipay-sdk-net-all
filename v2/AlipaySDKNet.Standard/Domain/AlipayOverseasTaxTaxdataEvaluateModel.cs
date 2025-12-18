using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTaxTaxdataEvaluateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTaxTaxdataEvaluateModel : AopObject
    {
        /// <summary>
        /// 评估类型，可选值： BY_PHONE   手机号 BY_USER_ID  用户uid BY_CODE  码值 BY_UNIFIED_ID  统一Id
        /// </summary>
        [XmlElement("evaluation_type")]
        public string EvaluationType { get; set; }

        /// <summary>
        /// 实际退给用户的退税金额
        /// </summary>
        [XmlElement("final_refund_amount")]
        public string FinalRefundAmount { get; set; }

        /// <summary>
        /// 实际退给用户的币种(仅支持CNY )
        /// </summary>
        [XmlElement("final_refund_currency")]
        public string FinalRefundCurrency { get; set; }

        /// <summary>
        /// 手机号或者支付宝uid
        /// </summary>
        [XmlElement("payment_method_id")]
        public string PaymentMethodId { get; set; }

        /// <summary>
        /// 退税金额，数值，最多两位小数，例如人民币，单位为元 Example:1400.00
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退税币种
        /// </summary>
        [XmlElement("refund_currency")]
        public string RefundCurrency { get; set; }
    }
}
