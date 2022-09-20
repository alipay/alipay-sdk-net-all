using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantIndirectCollectionAnalysisChannelTradeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantIndirectCollectionAnalysisChannelTradeInfo : AopObject
    {
        /// <summary>
        /// 交易金额，非实际到账金额
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付渠道( ALIPAY-支付宝/WECHAT_PAY-微信支付/UNION_PAY-银联支付/OTHER-其他付款方式)
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 交易笔数
        /// </summary>
        [XmlElement("trade_count")]
        public long TradeCount { get; set; }
    }
}
