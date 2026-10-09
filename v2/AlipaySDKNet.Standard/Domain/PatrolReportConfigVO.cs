using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PatrolReportConfigVO Data Structure.
    /// </summary>
    [Serializable]
    public class PatrolReportConfigVO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("report_config")]
        [XmlArrayItem("report_config")]
        public List<ReportConfig> ReportConfig { get; set; }

        /// <summary>
        /// 报事配置开关 true|false
        /// </summary>
        [XmlElement("report_switch")]
        public bool ReportSwitch { get; set; }
    }
}
