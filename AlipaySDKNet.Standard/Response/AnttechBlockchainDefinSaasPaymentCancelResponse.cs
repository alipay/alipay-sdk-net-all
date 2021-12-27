using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinSaasPaymentCancelResponse.
    /// </summary>
    public class AnttechBlockchainDefinSaasPaymentCancelResponse : AopResponse
    {
        /// <summary>
        /// 可用金额，单位为元。可用金额=总金额-已请款金额-已撤销金额。精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("available_amount")]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 支付币种三位字母编码。（编码规则遵循https://zh.wikipedia.org/wiki/ISO_4217）
        /// </summary>
        [XmlElement("available_currency")]
        public string AvailableCurrency { get; set; }

        /// <summary>
        /// 描述资金流的模型，通常资金流分为：SALE 销售模；AUTH_CAPTURE 预授权模式；
        /// </summary>
        [XmlElement("fund_mode")]
        public string FundMode { get; set; }

        /// <summary>
        /// 交易状态。PAYING(支付处理中);PAY_SUCCESS(支付成功);PAY_FAIL(支付失败); CAPTURING(请款中);CAPTURE_SUCCESS(请款成功);CAPTURE_FAIL(请款失败); REFUNDING(退款中);REFUND_SUCCESS(退款成功);REFUND_FAIL(退款失败); CLOSING(关单中);CLOSE_SUCCESS(关单成功);CLOSE_FAIL(关单失败);
        /// </summary>
        [XmlElement("order_state")]
        public string OrderState { get; set; }

        /// <summary>
        /// 外部业务平台原始交易号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 外部请求ID
        /// </summary>
        [XmlElement("out_request_id")]
        public string OutRequestId { get; set; }
    }
}
