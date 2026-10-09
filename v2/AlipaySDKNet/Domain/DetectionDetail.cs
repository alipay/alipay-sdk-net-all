using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DetectionDetail Data Structure.
    /// </summary>
    [Serializable]
    public class DetectionDetail : AopObject
    {
        /// <summary>
        /// AI 面试监考检测的业务结论，仅命中时返回、未命中为空（取值见枚举表，属报告内容数据）
        /// </summary>
        [XmlElement("cheating_status")]
        public string CheatingStatus { get; set; }

        /// <summary>
        /// 检测状态
        /// </summary>
        [XmlElement("detection_status")]
        public string DetectionStatus { get; set; }

        /// <summary>
        /// 手势/动作类型
        /// </summary>
        [XmlElement("gesture_type")]
        public string GestureType { get; set; }
    }
}
