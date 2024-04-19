using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingImageListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingImageListQueryModel : AopObject
    {
        /// <summary>
        /// 图文件名，支持模糊检索。
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 图片所归属的目录id。
        /// </summary>
        [XmlElement("image_directory_id")]
        public string ImageDirectoryId { get; set; }

        /// <summary>
        /// 图片空间中图片索引id。
        /// </summary>
        [XmlElement("image_index_id")]
        public string ImageIndexId { get; set; }

        /// <summary>
        /// 页码。
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 单页条数。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
