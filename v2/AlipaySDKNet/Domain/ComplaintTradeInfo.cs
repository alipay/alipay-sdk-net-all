using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ComplaintTradeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ComplaintTradeInfo : AopObject
    {
        /// <summary>
        /// 交易单金额（单位：人民币元）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 投诉主表id
        /// </summary>
        [XmlElement("complaint_record_id")]
        public string ComplaintRecordId { get; set; }

        /// <summary>
        /// 退款时间
        /// </summary>
        [XmlElement("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        [XmlElement("gmt_trade")]
        public string GmtTrade { get; set; }

        /// <summary>
        /// 交易信息表主键id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_no")]
        public string OutNo { get; set; }

        /// <summary>
        /// 交易投诉状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易投诉状态描述
        /// </summary>
        [XmlElement("status_description")]
        public string StatusDescription { get; set; }

        /// <summary>
        /// 支付宝交易单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
