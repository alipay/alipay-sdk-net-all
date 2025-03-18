using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenSearchDocBO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenSearchDocBO : AopObject
    {
        /// <summary>
        /// 短摘要
        /// </summary>
        [XmlElement("abstract_extract")]
        public string AbstractExtract { get; set; }

        /// <summary>
        /// 渠道来源网站
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 搜索的原文内容
        /// </summary>
        [XmlElement("doc")]
        public string Doc { get; set; }

        /// <summary>
        /// 搜索的内容摘要
        /// </summary>
        [XmlElement("doc_abstract")]
        public string DocAbstract { get; set; }

        /// <summary>
        /// 文档ID
        /// </summary>
        [XmlElement("doc_id")]
        public string DocId { get; set; }

        /// <summary>
        /// 原文链接地址
        /// </summary>
        [XmlElement("doc_url")]
        public string DocUrl { get; set; }

        /// <summary>
        /// 从正文抽取，默认采纳阈值>=0.1，分值0-1分
        /// </summary>
        [XmlElement("model_abstract_score")]
        public string ModelAbstractScore { get; set; }

        /// <summary>
        /// 配图合集
        /// </summary>
        [XmlElement("pic_afts_url_list")]
        public string PicAftsUrlList { get; set; }

        /// <summary>
        /// 图片对应的oss地址
        /// </summary>
        [XmlElement("pic_oss_path")]
        public string PicOssPath { get; set; }

        /// <summary>
        /// 发布时间戳
        /// </summary>
        [XmlElement("publish_timestamp")]
        public string PublishTimestamp { get; set; }

        /// <summary>
        /// 相关性打分，十分制
        /// </summary>
        [XmlElement("rel_score")]
        public string RelScore { get; set; }

        /// <summary>
        /// 评分,0-1分
        /// </summary>
        [XmlElement("scale_score")]
        public string ScaleScore { get; set; }

        /// <summary>
        /// 来源信息
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 文档标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 目前均为文本：text
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
