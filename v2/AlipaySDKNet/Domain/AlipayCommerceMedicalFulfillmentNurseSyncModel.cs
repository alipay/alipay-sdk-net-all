using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalFulfillmentNurseSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalFulfillmentNurseSyncModel : AopObject
    {
        /// <summary>
        /// 预计出报告结束时间，示例：2026-06-25 12:30
        /// </summary>
        [XmlElement("expected_report_end_time")]
        public string ExpectedReportEndTime { get; set; }

        /// <summary>
        /// 预计出报告开始时间，示例：2026-06-25 12:00
        /// </summary>
        [XmlElement("expected_report_start_time")]
        public string ExpectedReportStartTime { get; set; }

        /// <summary>
        /// 履约单ID
        /// </summary>
        [XmlElement("fulfillment_id")]
        public string FulfillmentId { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 护士ID
        /// </summary>
        [XmlElement("nurse_id")]
        public string NurseId { get; set; }

        /// <summary>
        /// 护士姓名
        /// </summary>
        [XmlElement("nurse_name")]
        public string NurseName { get; set; }

        /// <summary>
        /// 护士状态
        /// </summary>
        [XmlElement("nurse_status")]
        public string NurseStatus { get; set; }

        /// <summary>
        /// 护士状态描述
        /// </summary>
        [XmlElement("nurse_status_desc")]
        public string NurseStatusDesc { get; set; }

        /// <summary>
        /// 护士状态变更时间
        /// </summary>
        [XmlElement("nurse_status_time")]
        public string NurseStatusTime { get; set; }

        /// <summary>
        /// isv履约单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// SAAS订单ID
        /// </summary>
        [XmlElement("trade_order_id")]
        public string TradeOrderId { get; set; }

        /// <summary>
        /// 履约类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 预约码，示例：5566
        /// </summary>
        [XmlElement("verify_code")]
        public string VerifyCode { get; set; }
    }
}
