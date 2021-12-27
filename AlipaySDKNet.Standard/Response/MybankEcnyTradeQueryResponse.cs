using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankEcnyTradeQueryResponse.
    /// </summary>
    public class MybankEcnyTradeQueryResponse : AopResponse
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
        /// 调用方订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 交易的订单金额，单位为元，两位小数。该参数的值为支付时传入的total_amount
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 运营机构交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易状态：WAIT_BUYER_PAY（交易创建，等待买家付款）、TRADE_CLOSED（未付款交易超时关闭，或支付完成后全额退款）、TRADE_SUCCESS（交易支付成功）、TRADE_FINISHED（交易结束，不可退款）
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
