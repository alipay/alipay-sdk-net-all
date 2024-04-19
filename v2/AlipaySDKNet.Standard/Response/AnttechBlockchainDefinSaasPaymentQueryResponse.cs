using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinSaasPaymentQueryResponse.
    /// </summary>
    public class AnttechBlockchainDefinSaasPaymentQueryResponse : AopResponse
    {
        /// <summary>
        /// 描述资金流的模型，通常资金流分为：SALE 销售模；AUTH_CAPTURE 预授权模式；
        /// </summary>
        [XmlElement("fund_mode")]
        public string FundMode { get; set; }

        /// <summary>
        /// 交易状态。INIT(初始创建);PAYING(支付处理中);PAY_SUCCESS(支付成功);PAY_FAIL(支付失败); CAPTURING(请款中);CAPTURE_SUCCESS(请款成功);CAPTURE_FAIL(请款失败); REFUNDING(退款中);REFUND_SUCCESS(退款成功);REFUND_FAIL(退款失败); CLOSING(关单中);CLOSE_SUCCESS(关单成功);CLOSE_FAIL(关单失败);PART_PROCESSING(部分处理中);PART_SUCCESS(部分请款部分退款)
        /// </summary>
        [XmlElement("order_state")]
        public string OrderState { get; set; }

        /// <summary>
        /// 外部业务平台原始交易号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 收款方在外部业务平台的用户ID；收单场景表示卖家，纯资金场景表示收款方
        /// </summary>
        [XmlElement("out_payee_id")]
        public string OutPayeeId { get; set; }

        /// <summary>
        /// 付款方在外部业务平台的用户ID
        /// </summary>
        [XmlElement("out_payer_id")]
        public string OutPayerId { get; set; }

        /// <summary>
        /// 银行或其他支付服务提供方结果码
        /// </summary>
        [XmlElement("payment_result_code")]
        public string PaymentResultCode { get; set; }

        /// <summary>
        /// 银行或其他支付服务提供方支付结果描述
        /// </summary>
        [XmlElement("payment_result_message")]
        public string PaymentResultMessage { get; set; }

        /// <summary>
        /// 会员所属业务平台在智能科技的会员ID
        /// </summary>
        [XmlElement("platform_member_id")]
        public string PlatformMemberId { get; set; }
    }
}
