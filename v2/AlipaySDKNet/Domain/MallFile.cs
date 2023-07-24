using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MallFile Data Structure.
    /// </summary>
    [Serializable]
    public class MallFile : AopObject
    {
        /// <summary>
        /// file_md_5，用于下pr单
        /// </summary>
        [XmlElement("file_md_5")]
        public string FileMd5 { get; set; }

        /// <summary>
        /// file_name，用于下pr单
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// file_url，用于下pr单
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
