using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RemindTextInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RemindTextInfo : AopObject
    {
        /// <summary>
        /// 是否包含特殊样式（0：不包含 1：包含）
        /// </summary>
        [XmlElement("has_special_text")]
        public long HasSpecialText { get; set; }

        /// <summary>
        /// 长度 单位：个数
        /// </summary>
        [XmlElement("length")]
        public long Length { get; set; }

        /// <summary>
        /// 开始索引位置
        /// </summary>
        [XmlElement("start_index")]
        public long StartIndex { get; set; }

        /// <summary>
        /// 弹窗文案
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
