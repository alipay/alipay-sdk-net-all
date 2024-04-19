using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AosSearchItem Data Structure.
    /// </summary>
    [Serializable]
    public class AosSearchItem : AopObject
    {
        /// <summary>
        /// 业务主键
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 元数据信息
        /// </summary>
        [XmlElement("meta")]
        public string Meta { get; set; }

        /// <summary>
        /// 埋点参数
        /// </summary>
        [XmlElement("sequence")]
        public string Sequence { get; set; }

        /// <summary>
        /// 摘要值
        /// </summary>
        [XmlElement("snippet")]
        public string Snippet { get; set; }

        /// <summary>
        /// 搜索的展示的内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 数据类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 跳转链接地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
