using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryPerformOrderCreateResponse.
    /// </summary>
    public class AlipayEbppIndustryPerformOrderCreateResponse : AopResponse
    {
        /// <summary>
        /// 分账状态
        /// </summary>
        [XmlElement("alloc_status")]
        public string AllocStatus { get; set; }

        /// <summary>
        /// 账单金额(订单原价，单位元)
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 业务受理平台业务28位订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 销账状态
        /// </summary>
        [XmlElement("chargeoff_status")]
        public string ChargeoffStatus { get; set; }

        /// <summary>
        /// 创单类型
        /// </summary>
        [XmlElement("create_type")]
        public string CreateType { get; set; }

        /// <summary>
        /// 分账完成时间
        /// </summary>
        [XmlElement("gmt_alloc")]
        public string GmtAlloc { get; set; }

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
        /// 订单创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 支付成功时间
        /// </summary>
        [XmlElement("gmt_pay")]
        public string GmtPay { get; set; }

        /// <summary>
        /// 退款成功时间
        /// </summary>
        [XmlElement("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 实时结算成功时间
        /// </summary>
        [XmlElement("gmt_settle")]
        public string GmtSettle { get; set; }

        /// <summary>
        /// 行业业务受理平台分配的机构编码
        /// </summary>
        [XmlElement("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 行业业务受理平台分配的父机构编码
        /// </summary>
        [XmlElement("inst_group")]
        public string InstGroup { get; set; }

        /// <summary>
        /// 商户订单号。 订单支付时传入的商户订单号，商家自定义且保证商家系统中唯一。
        /// </summary>
        [XmlElement("out_no")]
        public string OutNo { get; set; }

        /// <summary>
        /// 行业业务受理平台分配的业务服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 实时结算状态
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝交易订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 行业业务受理平台分配的商户服务唯一编码
        /// </summary>
        [XmlElement("unique_code")]
        public string UniqueCode { get; set; }
    }
}
