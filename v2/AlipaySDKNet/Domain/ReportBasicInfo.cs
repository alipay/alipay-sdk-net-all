using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ReportBasicInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ReportBasicInfo : AopObject
    {
        /// <summary>
        /// 出险时间
        /// </summary>
        [XmlElement("accident_date")]
        public string AccidentDate { get; set; }

        /// <summary>
        /// 投保请求的交易流水号
        /// </summary>
        [XmlElement("apply_trade_no")]
        public string ApplyTradeNo { get; set; }

        /// <summary>
        /// 索赔金额
        /// </summary>
        [XmlElement("estimate_amount")]
        public string EstimateAmount { get; set; }

        /// <summary>
        /// 申请理赔的保单号
        /// </summary>
        [XmlElement("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 关联业务订单号（理赔唯一标识/LP订单号）
        /// </summary>
        [XmlElement("related_order_no")]
        public string RelatedOrderNo { get; set; }

        /// <summary>
        /// 报案时间
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 报案唯一标识，申请理赔所关联的订单号，如一个订单会存在多次理赔，请用唯一标识
        /// </summary>
        [XmlElement("report_unique_key")]
        public string ReportUniqueKey { get; set; }

        /// <summary>
        /// 报案人联系方式
        /// </summary>
        [XmlElement("reporter_contact_info")]
        public string ReporterContactInfo { get; set; }

        /// <summary>
        /// 申请报案人的名称
        /// </summary>
        [XmlElement("reporter_name")]
        public string ReporterName { get; set; }

        /// <summary>
        /// 工单号
        /// </summary>
        [XmlElement("ticket_no")]
        public string TicketNo { get; set; }
    }
}
