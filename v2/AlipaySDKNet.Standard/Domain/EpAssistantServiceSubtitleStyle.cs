using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpAssistantServiceSubtitleStyle Data Structure.
    /// </summary>
    [Serializable]
    public class EpAssistantServiceSubtitleStyle : AopObject
    {
        /// <summary>
        /// 副标题文本颜色编码
        /// </summary>
        [XmlElement("color")]
        public string Color { get; set; }

        /// <summary>
        /// CSS属性字体的粗细程度
        /// </summary>
        [XmlElement("font_weight")]
        public string FontWeight { get; set; }
    }
}
