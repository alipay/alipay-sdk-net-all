using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenBudget Data Structure.
    /// </summary>
    [Serializable]
    public class OpenBudget : AopObject
    {
        /// <summary>
        /// 警告接收人
        /// </summary>
        [XmlArray("alert_users")]
        [XmlArrayItem("string")]
        public List<string> AlertUsers { get; set; }

        /// <summary>
        /// 预算库ID
        /// </summary>
        [XmlElement("budget_id")]
        public string BudgetId { get; set; }

        /// <summary>
        /// 预算模式
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 监控的业务号
        /// </summary>
        [XmlElement("monitor_biz_id")]
        public string MonitorBizId { get; set; }

        /// <summary>
        /// 监控模板标识
        /// </summary>
        [XmlElement("monitor_template_code")]
        public string MonitorTemplateCode { get; set; }

        /// <summary>
        /// 监控告警触发条件的计算项标识
        /// </summary>
        [XmlElement("monitor_trigger_code")]
        public string MonitorTriggerCode { get; set; }

        /// <summary>
        /// 告警阈值
        /// </summary>
        [XmlArray("thresholds")]
        [XmlArrayItem("number")]
        public List<long> Thresholds { get; set; }

        /// <summary>
        /// 预算值
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
