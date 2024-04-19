using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingImagedirectoryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingImagedirectoryCreateModel : AopObject
    {
        /// <summary>
        /// 新增目录名。
        /// </summary>
        [XmlElement("image_directory_name")]
        public string ImageDirectoryName { get; set; }

        /// <summary>
        /// 新增目录归属父目录id。如果新增目录需要归属到根目录，则该字段填"0"。
        /// </summary>
        [XmlElement("parent_directory_id")]
        public string ParentDirectoryId { get; set; }
    }
}
