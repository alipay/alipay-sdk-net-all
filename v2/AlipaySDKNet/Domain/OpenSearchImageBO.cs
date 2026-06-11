using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenSearchImageBO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenSearchImageBO : AopObject
    {
        /// <summary>
        /// 图片资源的唯一ID，用于资源有问题的时候，快速定位资源
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 原始文档路径
        /// </summary>
        [XmlElement("doc_url")]
        public string DocUrl { get; set; }

        /// <summary>
        /// 多模态理解，对图片进行描述
        /// </summary>
        [XmlElement("generated_desc")]
        public string GeneratedDesc { get; set; }

        /// <summary>
        /// 图片高度,单位px
        /// </summary>
        [XmlElement("pic_height")]
        public string PicHeight { get; set; }

        /// <summary>
        /// 图片存储到蚂蚁cnd的地址
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 图片宽度,单位px
        /// </summary>
        [XmlElement("pic_width")]
        public string PicWidth { get; set; }

        /// <summary>
        /// 排序使用的相关性分，取值0-1
        /// </summary>
        [XmlElement("sort_values")]
        public string SortValues { get; set; }

        /// <summary>
        /// 图片的title，完全基于爬虫能力选择，无固定长度
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
