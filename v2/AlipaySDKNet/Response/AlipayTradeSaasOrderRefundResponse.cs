using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeSaasOrderRefundResponse.
    /// </summary>
    public class AlipayTradeSaasOrderRefundResponse : AopResponse
    {
        /// <summary>
        /// 本次退款是否发生资金变化。Y表示发生资金变化，N表示未发生资金变化。
        /// </summary>
        [XmlElement("fund_change")]
        public string FundChange { get; set; }

        /// <summary>
        /// 退款成功时间，格式为yyyy-MM-dd HH:mm:ss。按query_options返回。
        /// </summary>
        [XmlElement("gmt_refund_pay")]
        public string GmtRefundPay { get; set; }

        /// <summary>
        /// 商户退款请求号。请求传入时返回。
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号。
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("refund_detail_item_list")]
        [XmlArrayItem("saas_trade_fund_bill")]
        public List<SaasTradeFundBill> RefundDetailItemList { get; set; }

        /// <summary>
        /// 本次退款金额，单位为元。
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 下游支付渠道交易号。
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
