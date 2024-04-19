using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainDefinSaasPaymentPayResponse.
    /// </summary>
    public class AnttechBlockchainDefinSaasPaymentPayResponse : AopResponse
    {
        /// <summary>
        /// 资金流模型
        /// </summary>
        [XmlElement("fund_mode")]
        public string FundMode { get; set; }

        /// <summary>
        /// 交易单状态。PAYING(支付处理中);PAY_SUCCESS(支付成功);PAY_FAIL(支付失败); CAPTURING(请款中);CAPTURE_SUCCESS(请款成功);CAPTURE_FAIL(请款失败); REFUNDING(退款中);REFUND_SUCCESS(退款成功);REFUND_FAIL(退款失败); CLOSING(关单中);CLOSE_SUCCESS(关单成功);CLOSE_FAIL(关单失败);
        /// </summary>
        [XmlElement("order_state")]
        public string OrderState { get; set; }

        /// <summary>
        /// 外部业务平台原始交易号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 收款方账号
        /// </summary>
        [XmlElement("payee_account")]
        public AccountDTO PayeeAccount { get; set; }

        /// <summary>
        /// 银行或其他支付服务提供方支付结果描述
        /// </summary>
        [XmlElement("payment_error_message")]
        public string PaymentErrorMessage { get; set; }

        /// <summary>
        /// 会员所属业务平台在智能科技的会员ID
        /// </summary>
        [XmlElement("platform_member_id")]
        public string PlatformMemberId { get; set; }

        /// <summary>
        /// 支付提交状态 支付处理中: INIT（一般为提交银行超时导致） 支付提交成功: SUBMIT_SUCCESS 支付提交失败: SUBMIT_FAIL
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }
    }
}
