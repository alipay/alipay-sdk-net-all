using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QuotaControlHistoryRecord Data Structure.
    /// </summary>
    [Serializable]
    public class QuotaControlHistoryRecord : AopObject
    {
        /// <summary>
        /// 额度指标  - Function_Counts  - Function_Resource_Usage  - Function_Data  - Database_Storage  - Read_Counts  - Write_Counts  - Oss_Capacity  - Oss_Data  - Oss_Download  - Oss_Upload  - Oss_Reverse_Data  - Staticsite_Capacity  - Staticsite_Data
        /// </summary>
        [XmlElement("fee_item_code")]
        public string FeeItemCode { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 阈值（比例）
        /// </summary>
        [XmlElement("threshold")]
        public long Threshold { get; set; }

        /// <summary>
        /// 触发值
        /// </summary>
        [XmlElement("trigger_value")]
        public string TriggerValue { get; set; }
    }
}
