using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageAlterConsultResponse.
    /// </summary>
    public class AlipayCloudCloudbaseResourcepackageAlterConsultResponse : AopResponse
    {
        /// <summary>
        /// 变配类型  - ALTERATION_UP  - ALTERATION_DOWN
        /// </summary>
        [XmlElement("alter_type")]
        public string AlterType { get; set; }

        /// <summary>
        /// 币种  - CNY  - USD  - EUR
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 支付方向  - RECEIVABLE(应收) - REFUNDABLE(应退) - CURR_SPEC_HAS_PAY(当前规格已购) - WAIT_DOWN_STARTED(降配待生效) - CURR_SPEC_CANT_DOWN(当前规格无法降配,剩余生效周期不足一个月)
        /// </summary>
        [XmlElement("original_payment_direction")]
        public string OriginalPaymentDirection { get; set; }

        /// <summary>
        /// 原价差额(分)
        /// </summary>
        [XmlElement("original_total_amount")]
        public string OriginalTotalAmount { get; set; }

        /// <summary>
        /// 支付方向  - RECEIVABLE  - REFUNDABLE  - CURR_SPEC_HAS_PAY  - WAIT_DOWN_STARTED  - CURR_SPEC_CANT_DOWN  - INSTANCE_IS_BEING_AMORTIZED
        /// </summary>
        [XmlElement("payment_direction")]
        public string PaymentDirection { get; set; }

        /// <summary>
        /// 差额价(分)
        /// </summary>
        [XmlElement("trade_total_amount")]
        public string TradeTotalAmount { get; set; }
    }
}
