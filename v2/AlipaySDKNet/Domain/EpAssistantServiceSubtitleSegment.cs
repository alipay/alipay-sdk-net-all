using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpAssistantServiceSubtitleSegment Data Structure.
    /// </summary>
    [Serializable]
    public class EpAssistantServiceSubtitleSegment : AopObject
    {
        /// <summary>
        /// 分段文本对应的样式，示例：{"color": "#FF6B35", "fontWeight": "bold"} ，没有样式时此字段可能为null
        /// </summary>
        [XmlElement("style")]
        public EpAssistantServiceSubtitleStyle Style { get; set; }

        /// <summary>
        /// 服务卡片副标题分段文本，如果整段文本中有需要特殊格式的，会将文本切割，每段文本关联独立展示样式style
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
