using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSaasRefundorderQueryResponse.
    /// </summary>
    public class AlipayTradeSaasRefundorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 退款成功时间，格式为yyyy-MM-dd HH:mm:ss。按query_options返回。
        /// </summary>
        [XmlElement("gmt_refund_pay")]
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 商户退款请求号。原退款请求传入时返回。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 退款金额，单位为元。
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("refund_detail_item_list")]
        [XmlArrayItem("saas_trade_fund_bill")]
        public List<SaasTradeFundBill> RefundDetailItemList { get; set; }

        /// <summary>
        /// 退款原因。
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款状态。
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 本次商户实际退回金额，单位为元。
        /// </summary>
        [XmlElement("send_back_fee")]
        public string SendBackFee { get; set; }

        /// <summary>
        /// 原订单金额，单位为元。
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 下游支付渠道交易号。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
