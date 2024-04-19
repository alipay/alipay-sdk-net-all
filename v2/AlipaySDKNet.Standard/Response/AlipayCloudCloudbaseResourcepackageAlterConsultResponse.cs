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
        /// 支付方向  - RECEIVABLE  - REFUNDABLE  - CURR_SPEC_HAS_PAY  - WAIT_DOWN_STARTED  - CURR_SPEC_CANT_DOWN
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
