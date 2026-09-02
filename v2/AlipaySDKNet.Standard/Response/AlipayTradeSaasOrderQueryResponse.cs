using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSaasOrderQueryResponse.
    /// </summary>
    public class AlipayTradeSaasOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 银行转账实际付款账号。仅在银行转账支付成功且渠道返回该信息时返回。
        /// </summary>
        [XmlElement("buyer_bank_account")]
        public string BuyerBankAccount { get; set; }

        /// <summary>
        /// 银行转账实际付款银行名称。仅在银行转账支付成功且渠道返回该信息时返回。
        /// </summary>
        [XmlElement("buyer_bank_name")]
        public string BuyerBankName { get; set; }

        /// <summary>
        /// 银行转账实际付款户名。仅在银行转账支付成功且渠道返回该信息时返回。
        /// </summary>
        [XmlElement("buyer_name")]
        public string BuyerName { get; set; }

        /// <summary>
        /// 买家实付金额，单位为元。
        /// </summary>
        [XmlElement("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 首次真实关单原因。仅在交易真实关闭且已记录关单原因时返回。
        /// </summary>
        [XmlElement("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 商户订单备注。创建收款单时传入则原样返回。
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// SaaS交易订单号。单号已形成时返回。
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户订单号。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商户创建收款单时传入的透传参数。
        /// </summary>
        [XmlElement("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 实际支付渠道。尚未形成支付渠道时不返回。
        /// </summary>
        [XmlElement("pay_channel")]
        public string PayChannel { get; set; }

        /// <summary>
        /// 商户实收金额，单位为元。
        /// </summary>
        [XmlElement("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 支付成功时间，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("send_pay_date")]
        public string SendPayDate { get; set; }

        /// <summary>
        /// 订单标题。
        /// </summary>
        [XmlElement("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单总金额，单位为元。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 下游支付渠道交易号。尚未形成真实渠道交易号或多渠道无法唯一表达时不返回。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易状态。WAIT_BUYER_PAY表示等待买家付款，TRADE_SUCCESS表示支付成功，TRADE_CLOSED表示交易关闭。
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
