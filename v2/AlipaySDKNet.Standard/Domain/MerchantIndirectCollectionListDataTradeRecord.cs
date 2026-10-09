using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantIndirectCollectionListDataTradeRecord Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantIndirectCollectionListDataTradeRecord : AopObject
    {
        /// <summary>
        /// 交易金额（小数点后两位，单位元）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 交易订单号 (银行侧)
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 付款渠道 ALIPAY 支付宝 WECHAT_PAY 微信支付 UNION_PAY 银联支付 OTHER 其他付款方式
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 交易状态 SUCCESS/FAIL/FEFUND
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 交易时间(按照时间倒排)
        /// </summary>
        [XmlElement("trade_time")]
        public string TradeTime { get; set; }
    }
}
