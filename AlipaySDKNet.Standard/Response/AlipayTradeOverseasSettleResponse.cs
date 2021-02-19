using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeOverseasSettleResponse.
    /// </summary>
    public class AlipayTradeOverseasSettleResponse : AopResponse
    {
        /// <summary>
        /// 本笔跨境结算使用的汇率，精度 8 位小数
        /// </summary>
        [XmlElement("exchange_rate")]
        public string ExchangeRate { get; set; }

        /// <summary>
        /// 本次跨境结算的实际结算外币金额
        /// </summary>
        [XmlElement("foreign_settle_amount")]
        public string ForeignSettleAmount { get; set; }

        /// <summary>
        /// 本笔跨境结算实际结算的外币币种
        /// </summary>
        [XmlElement("foreign_settle_currency")]
        public string ForeignSettleCurrency { get; set; }

        /// <summary>
        /// 请求流水号，开发者自行生成并保证唯一性，作为业务幂等性控制
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 本次跨境结算的实际结算人民币金额
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
