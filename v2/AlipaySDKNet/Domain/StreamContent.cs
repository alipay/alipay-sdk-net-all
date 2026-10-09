using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StreamContent Data Structure.
    /// </summary>
    [Serializable]
    public class StreamContent : AopObject
    {
        /// <summary>
        /// 代表当前流式类型推送内容状态标识
        /// </summary>
        [XmlElement("reply_cmd")]
        public string ReplyCmd { get; set; }

        /// <summary>
        /// 标识为增量还是全量返回流式文本
        /// </summary>
        [XmlElement("stream_type")]
        public string StreamType { get; set; }

        /// <summary>
        /// 卡片模版code
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 卡片值
        /// </summary>
        [XmlElement("template_data")]
        public string TemplateData { get; set; }

        /// <summary>
        /// 单次推送的流式文本内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
