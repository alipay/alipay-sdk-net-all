using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeSettleConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeSettleConfirmModel : AopObject
    {
        /// <summary>
        /// 确认结算请求流水号，开发者自行生成并保证唯一性，作为业务幂等性控制
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 描述结算信息，json格式。
        /// </summary>
        [XmlElement("settle_info")]
        public SettleInfo SettleInfo { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
