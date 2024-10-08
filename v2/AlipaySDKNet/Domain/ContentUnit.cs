using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContentUnit Data Structure.
    /// </summary>
    [Serializable]
    public class ContentUnit : AopObject
    {
        /// <summary>
        /// 单次推送的内容
        /// </summary>
        [XmlElement("content")]
        public StreamContent Content { get; set; }

        /// <summary>
        /// 内容id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// text-文本 steam-流式 template-卡片
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 多条内容的排序序号
        /// </summary>
        [XmlElement("index_id")]
        public long IndexId { get; set; }
    }
}
