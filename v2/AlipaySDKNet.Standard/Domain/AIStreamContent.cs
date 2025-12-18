using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AIStreamContent Data Structure.
    /// </summary>
    [Serializable]
    public class AIStreamContent : AopObject
    {
        /// <summary>
        /// 卡片类型
        /// </summary>
        [XmlElement("content_type")]
        public string ContentType { get; set; }

        /// <summary>
        /// 是否还有下文
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 顺序
        /// </summary>
        [XmlElement("index")]
        public long Index { get; set; }

        /// <summary>
        /// 内部业务信息
        /// </summary>
        [XmlElement("inner_biz_content")]
        public string InnerBizContent { get; set; }

        /// <summary>
        /// 卡片唯一ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 文本
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
