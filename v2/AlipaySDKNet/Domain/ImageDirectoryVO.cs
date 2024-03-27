using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ImageDirectoryVO Data Structure.
    /// </summary>
    [Serializable]
    public class ImageDirectoryVO : AopObject
    {
        /// <summary>
        /// 目录创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 目录id
        /// </summary>
        [XmlElement("image_directory_id")]
        public string ImageDirectoryId { get; set; }

        /// <summary>
        /// 目录名
        /// </summary>
        [XmlElement("image_directory_name")]
        public string ImageDirectoryName { get; set; }

        /// <summary>
        /// 目录更新时间
        /// </summary>
        [XmlElement("modify_time")]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 父目录id
        /// </summary>
        [XmlElement("parent_directory_id")]
        public string ParentDirectoryId { get; set; }
    }
}
