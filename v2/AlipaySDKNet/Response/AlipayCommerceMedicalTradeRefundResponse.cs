using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalTradeRefundResponse.
    /// </summary>
    public class AlipayCommerceMedicalTradeRefundResponse : AopResponse
    {
        /// <summary>
        /// 支付宝交易单号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 银行编码
        /// </summary>
        [XmlElement("bank_id")]
        public string BankId { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 银行订单ID
        /// </summary>
        [XmlElement("bank_order_id")]
        public string BankOrderId { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 本次自费退款请求对应的退款金额，单位是元
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 本次退款失败原因
        /// </summary>
        [XmlElement("refund_msg")]
        public string RefundMsg { get; set; }

        /// <summary>
        /// 本次退款对应的退款请求流水号
        /// </summary>
        [XmlElement("refund_request_no")]
        public string RefundRequestNo { get; set; }

        /// <summary>
        /// 自费退款状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款成功时间
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 蚂蚁逸康平台交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
