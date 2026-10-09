using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SavePatrolReportConfigVO Data Structure.
    /// </summary>
    [Serializable]
    public class SavePatrolReportConfigVO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("report_config")]
        [XmlArrayItem("report_config_v_o")]
        public List<ReportConfigVO> ReportConfig { get; set; }

        /// <summary>
        /// 报事配置开关 true|false
        /// </summary>
        [XmlElement("report_switch")]
        public bool ReportSwitch { get; set; }
    }
}
