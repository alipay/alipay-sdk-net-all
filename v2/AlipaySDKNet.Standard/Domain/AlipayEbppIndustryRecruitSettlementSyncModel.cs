using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryRecruitSettlementSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryRecruitSettlementSyncModel : AopObject
    {
        /// <summary>
        /// 实际工时；当前结算单对应的实际工时，（单位：小时），例如：8小时 
        /// </summary>
        [XmlElement("attendance_time")]
        public string AttendanceTime { get; set; }

        /// <summary>
        /// 结算详情URL，C端的钱包URL
        /// </summary>
        [XmlElement("client_settlement_url")]
        public string ClientSettlementUrl { get; set; }

        /// <summary>
        /// 岗位薪资；单位：元，精确到分，例如：80.00元
        /// </summary>
        [XmlElement("job_salary")]
        public string JobSalary { get; set; }

        /// <summary>
        /// 岗位薪资单位；单位：元/小时、元/天、 元/周、元/月、 元/件
        /// </summary>
        [XmlElement("job_salary_type")]
        public string JobSalaryType { get; set; }

        /// <summary>
        /// 报名订单ID
        /// </summary>
        [XmlElement("out_apply_id")]
        public string OutApplyId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("out_attendance_ids")]
        [XmlArrayItem("string")]
        public List<string> OutAttendanceIds { get; set; }

        /// <summary>
        /// 外部岗位id
        /// </summary>
        [XmlElement("out_job_id")]
        public string OutJobId { get; set; }

        /// <summary>
        /// 结算ID；ISV侧结算ID，当前报名ID的结算ID，记录待结算账单信息
        /// </summary>
        [XmlElement("out_settlement_id")]
        public string OutSettlementId { get; set; }

        /// <summary>
        /// 外部用户id
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }

        /// <summary>
        /// 调整后工时：（单位：小时）
        /// </summary>
        [XmlElement("real_attendance_time")]
        public string RealAttendanceTime { get; set; }

        /// <summary>
        /// 调整后薪资，单位：元，精确到分，例如：300.00元
        /// </summary>
        [XmlElement("real_settle_amount")]
        public string RealSettleAmount { get; set; }

        /// <summary>
        /// 待结算信息URL，B端的待结算信息URL
        /// </summary>
        [XmlElement("server_settlement_url")]
        public string ServerSettlementUrl { get; set; }

        /// <summary>
        /// 应结算薪资；当前结算单，按照实际工时对应结算的薪资，单位：元，精确到分，例如：300.00元
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 结算状态枚举：待雇主结算、雇主已结算
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 结算信息来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
