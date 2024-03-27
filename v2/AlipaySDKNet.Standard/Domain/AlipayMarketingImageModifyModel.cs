using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingImageModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingImageModifyModel : AopObject
    {
        /// <summary>
        /// 修改后图片新文件名。仅在需要修改文件名时传入，如果不修改则此字段不传。
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 修改后新目录id。仅在需要修改图片归属目录归属关系时传入。如果不修改则此字段不传。
        /// </summary>
        [XmlElement("image_directory_id")]
        public string ImageDirectoryId { get; set; }

        /// <summary>
        /// 需要修改的图索引id。
        /// </summary>
        [XmlElement("image_index_id")]
        public string ImageIndexId { get; set; }
    }
}
