using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OssDirectoryDetail Data Structure.
    /// </summary>
    [Serializable]
    public class OssDirectoryDetail : AopObject
    {
        /// <summary>
        /// 文件夹ACL
        /// </summary>
        [XmlElement("acl")]
        public string Acl { get; set; }

        /// <summary>
        /// 文件夹ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件夹上次更新时间
        /// </summary>
        [XmlElement("last_modified")]
        public string LastModified { get; set; }
    }
}
