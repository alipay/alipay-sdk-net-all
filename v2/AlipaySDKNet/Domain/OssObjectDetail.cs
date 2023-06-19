using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OssObjectDetail Data Structure.
    /// </summary>
    [Serializable]
    public class OssObjectDetail : AopObject
    {
        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [XmlElement("size")]
        public long Size { get; set; }

        /// <summary>
        /// 文件状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
