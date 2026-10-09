using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerSettlementApplyResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerSettlementApplyResponse : AopResponse
    {
        /// <summary>
        /// 收单机构渠道码，该字段不返回默认为ALIPAY
        /// </summary>
        [XmlElement("aquirer")]
        public string Aquirer { get; set; }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        [XmlElement("biz_ext_info")]
        public string BizExtInfo { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id（收单为支付宝必返回）
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 交易支付使用的资金渠道（收单为支付宝必返回）
        /// </summary>
        [XmlArray("fund_bill_list")]
        [XmlArrayItem("fund_bill")]
        public List<FundBill> FundBillList { get; set; }

        /// <summary>
        /// 如果收单渠道支付宝（默认）：交易支付时间  如果收单渠道为第三方：为渠道处理成功的时间，具体业务语义由渠道定义。
        /// </summary>
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 应用维度的用户Id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付金额（收单为支付宝必返回）
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 如果收单渠道为支付宝（默认）：  "I":"待支付";  "PI":"支付中";  "S":"支付成功";  "F":"支付失败";  "RI":"退款中";  "R":"已退款".  如果收单渠道为第三方：  "IN_PROCESSING":"受理中";   "PROCESS_SUCCESS":"处理成功";   "PROCESS_FAIL":"处理失败";
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 收单机构交易流水号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
