using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InfoSecAnalyzeSyncResult Data Structure.
    /// </summary>
    [Serializable]
    public class InfoSecAnalyzeSyncResult : AopObject
    {
        /// <summary>
        /// 数据ID
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 风险识别标签内容
        /// </summary>
        [XmlArray("detect_check_labels")]
        [XmlArrayItem("detect_check_label")]
        public List<DetectCheckLabel> DetectCheckLabels { get; set; }

        /// <summary>
        /// 处置建议
        /// </summary>
        [XmlElement("suggestion")]
        public string Suggestion { get; set; }

        /// <summary>
        /// 检测任务ID
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
