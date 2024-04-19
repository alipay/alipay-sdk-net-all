using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingImagedirectoryListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingImagedirectoryListQueryModel : AopObject
    {
        /// <summary>
        /// 目录id。
        /// </summary>
        [XmlElement("image_directory_id")]
        public string ImageDirectoryId { get; set; }

        /// <summary>
        /// 目录名，支持模糊检索。
        /// </summary>
        [XmlElement("image_directory_name")]
        public string ImageDirectoryName { get; set; }

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

        /// <summary>
        /// 父目录ID，查询一级目录时填"0"，查询全部目录的时候不填。
        /// </summary>
        [XmlElement("parent_directory_id")]
        public string ParentDirectoryId { get; set; }
    }
}
