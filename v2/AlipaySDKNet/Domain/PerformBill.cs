using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PerformBill Data Structure.
    /// </summary>
    [Serializable]
    public class PerformBill : AopObject
    {
        /// <summary>
        /// [{"name":"未分账","value":"I"},{"name":"分账中","value":"P"},{"name":"分账成功","value":"S"},{"name":"分账关闭","value":"C"}]
        /// </summary>
        [XmlElement("alloc_status")]
        public string AllocStatus { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// [{"name":"未销账","value":"I"},{"name":"销账处理中","value":"P"},{"name":"已销账","value":"S"},{"name":"已关闭","value":"C"}]
        /// </summary>
        [XmlElement("chargeoff_status")]
        public string ChargeoffStatus { get; set; }

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
        /// 商户订单号
        /// </summary>
        [XmlElement("out_no")]
        public string OutNo { get; set; }

        /// <summary>
        /// 实际支付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// [{"name":"未结算","value":"I"},{"name":"结算中","value":"P"},{"name":"结算成功","value":"S"},{"name":"结算关闭","value":"C"}]
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// [{"name":"等待付款","value":"I"},{"name":"付款失败","value":"N"},{"name":"处理中","value":"P"},{"name":"单据关闭","value":"C"},{"name":"退款中","value":"T"},{"name":"全额退款","value":"F"},{"name":"成功","value":"S"},{"name":"部分退款","value":"H"}]
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
