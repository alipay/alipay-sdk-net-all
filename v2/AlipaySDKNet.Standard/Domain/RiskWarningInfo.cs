using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskWarningInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RiskWarningInfo : AopObject
    {
        /// <summary>
        /// 当前状态描述
        /// </summary>
        [XmlElement("current_status")]
        public string CurrentStatus { get; set; }

        /// <summary>
        /// 风险等级描述
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// source服务商名称
        /// </summary>
        [XmlElement("source_name")]
        public string SourceName { get; set; }

        /// <summary>
        /// source服务商pid
        /// </summary>
        [XmlElement("source_pid")]
        public string SourcePid { get; set; }
    }
}
