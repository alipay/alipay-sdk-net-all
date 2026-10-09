using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskFinishLabel Data Structure.
    /// </summary>
    [Serializable]
    public class RiskFinishLabel : AopObject
    {
        /// <summary>
        /// 对应审理平台结案标签的编码值
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 对应审理平台展示的标签文本
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// 当前标签对应的标签树路径,多层标签时使用|分割
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }
    }
}
