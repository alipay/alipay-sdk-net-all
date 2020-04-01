using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCreditFinanceRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCreditFinanceRefundModel : AopObject
    {
        /// <summary>
        /// 本次需要退款的金额，单位为元；精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 币种,CNY
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 扩展参数，json结构体，例用前需要与支付宝工程师确认
        /// </summary>
        [XmlElement("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 退款备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部退款请求号，用于控制幂等
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 收款人信息
        /// </summary>
        [XmlElement("payee_info")]
        public CreditFinancePayAccountInfo PayeeInfo { get; set; }

        /// <summary>
        /// 本次需要进行金融处理的交易对应的交易的买家userId
        /// </summary>
        [XmlElement("trade_buyer_id")]
        public string TradeBuyerId { get; set; }

        /// <summary>
        /// 需要进行金融处理的交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
