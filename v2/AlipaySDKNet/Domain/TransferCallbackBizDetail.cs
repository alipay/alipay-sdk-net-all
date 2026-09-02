using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TransferCallbackBizDetail Data Structure.
    /// </summary>
    [Serializable]
    public class TransferCallbackBizDetail : AopObject
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 支付单支付宝交易号
        /// </summary>
        [XmlElement("pay_order_trade_no")]
        public string PayOrderTradeNo { get; set; }

        /// <summary>
        /// 交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 转支付结果
        /// </summary>
        [XmlElement("transfer_pay_results")]
        public string TransferPayResults { get; set; }
    }
}
