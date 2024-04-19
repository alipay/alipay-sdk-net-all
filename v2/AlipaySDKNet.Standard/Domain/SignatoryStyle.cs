using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SignatoryStyle Data Structure.
    /// </summary>
    [Serializable]
    public class SignatoryStyle : AopObject
    {
        /// <summary>
        /// 字体对应，默认且目前仅支持1（宋体）。
        /// </summary>
        [XmlElement("font")]
        public long Font { get; set; }

        /// <summary>
        /// 字体大小，非必填，默认12。
        /// </summary>
        [XmlElement("font_size")]
        public long FontSize { get; set; }

        /// <summary>
        /// 组件高度，非必填，有默认值。
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 文本颜色，非必填，默认#000000
        /// </summary>
        [XmlElement("text_color")]
        public string TextColor { get; set; }

        /// <summary>
        /// 组件宽度，非必填，可使用默认值。
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }
    }
}
