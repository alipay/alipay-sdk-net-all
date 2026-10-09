using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingImagedirectoryModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingImagedirectoryModifyModel : AopObject
    {
        /// <summary>
        /// 需修改的目录id。
        /// </summary>
        [XmlElement("image_directory_id")]
        public string ImageDirectoryId { get; set; }

        /// <summary>
        /// 修改后的目录名。仅在需要修改目录名称时传入，如果不修改则此字段不传。
        /// </summary>
        [XmlElement("image_directory_name")]
        public string ImageDirectoryName { get; set; }

        /// <summary>
        /// 修改后的父目录id。仅在需要修改归属父目录id时传入，如果不修改则此字段不传。
        /// </summary>
        [XmlElement("parent_directory_id")]
        public string ParentDirectoryId { get; set; }
    }
}
