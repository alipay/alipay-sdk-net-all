using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryPerformOrderQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryPerformOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单金额(订单原价，金额分)
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 销账状态
        /// </summary>
        [XmlElement("chargeoff_status")]
        public string ChargeoffStatus { get; set; }

        /// <summary>
        /// 销账完结时间
        /// </summary>
        [XmlElement("gmt_chargeoff_finish")]
        public string GmtChargeoffFinish { get; set; }

        /// <summary>
        /// 销账发起时间
        /// </summary>
        [XmlElement("gmt_chargeoff_start")]
        public string GmtChargeoffStart { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 退款时间
        /// </summary>
        [XmlElement("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 实时结算时间
        /// </summary>
        [XmlElement("gmt_settle")]
        public string GmtSettle { get; set; }

        /// <summary>
        /// 机构code
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 主机构code
        /// </summary>
        [XmlElement("inst_group")]
        public string InstGroup { get; set; }

        /// <summary>
        /// 外部商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 外部唯一订单号
        /// </summary>
        [XmlElement("out_no")]
        public string OutNo { get; set; }

        /// <summary>
        /// 实际支付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 结算状态
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
