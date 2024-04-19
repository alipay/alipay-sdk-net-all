using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankEcnyTradePayResponse.
    /// </summary>
    public class MybankEcnyTradePayResponse : AopResponse
    {
        /// <summary>
        /// 买家钱包ID，支付成功时必填
        /// </summary>
        [XmlElement("buyer_wallet_id")]
        public string BuyerWalletId { get; set; }

        /// <summary>
        /// 买家钱包名称，支付成功时必填
        /// </summary>
        [XmlElement("buyer_wallet_name")]
        public string BuyerWalletName { get; set; }

        /// <summary>
        /// 交易支付时间，支付成功时必填
        /// </summary>
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 调用方订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 运营机构交易号，支付成功时必填
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
