using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ArchiveFiles Data Structure.
    /// </summary>
    [Serializable]
    public class ArchiveFiles : AopObject
    {
        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 海图可以下载的甄零文件地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
