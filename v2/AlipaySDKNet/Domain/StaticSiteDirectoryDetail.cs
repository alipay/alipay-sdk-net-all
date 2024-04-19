using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StaticSiteDirectoryDetail Data Structure.
    /// </summary>
    [Serializable]
    public class StaticSiteDirectoryDetail : AopObject
    {
        /// <summary>
        /// 文件夹ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件夹名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 上次更新时间
        /// </summary>
        [XmlElement("last_modified")]
        public string LastModified { get; set; }
    }
}
