using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FileBaseInfoResponse Data Structure.
    /// </summary>
    [Serializable]
    public class FileBaseInfoResponse : AopObject
    {
        /// <summary>
        /// 文件绝对路径
        /// </summary>
        [XmlElement("absolute_path")]
        public string AbsolutePath { get; set; }

        /// <summary>
        /// 文件访问地址
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 是否生效,true:是，false:否
        /// </summary>
        [XmlElement("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件或目录名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件类型,目录:Directory,文件:File
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 文件父目录路径
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }
    }
}
