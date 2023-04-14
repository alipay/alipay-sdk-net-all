using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeBusinessOrderQueryResponse.
    /// </summary>
    public class MybankPaymentTradeBusinessOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务场景 固定场景中分配
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 币种，默认CNY
        /// </summary>
        [XmlElement("currency_value")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// 网商订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单状态 INIT 初始化 CLOSED 交易关闭 PAYED 支付完成 SETTLED 结算分账完成 FINISH 交易完成
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 下单的外部平台的单据号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 已支付金额
        /// </summary>
        [XmlElement("pay_amt")]
        public string PayAmt { get; set; }

        /// <summary>
        /// 签约的产品码(固定值)
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 售中退款金额
        /// </summary>
        [XmlElement("refund_amt")]
        public string RefundAmt { get; set; }

        /// <summary>
        /// 外部平台是否需要原单重试，失败时有值
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }

        /// <summary>
        /// 结算金额
        /// </summary>
        [XmlElement("settle_amt")]
        public string SettleAmt { get; set; }

        /// <summary>
        /// 金额，单位元
        /// </summary>
        [XmlElement("trade_amt")]
        public string TradeAmt { get; set; }
    }
}
