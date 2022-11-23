using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskFinishInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RiskFinishInfo : AopObject
    {
        /// <summary>
        /// 结案选中的标签列表 code 选中的标签code label 选中的标签 path 选中标签的全路径
        /// </summary>
        [XmlArray("finish_label")]
        [XmlArrayItem("risk_finish_label")]
        public List<RiskFinishLabel> FinishLabel { get; set; }

        /// <summary>
        /// 任务结案类型
        /// </summary>
        [XmlElement("finish_type")]
        public string FinishType { get; set; }

        /// <summary>
        /// 主站审理平台任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
