using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DocInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DocInfo : AopObject
    {
        /// <summary>
        /// 合同文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 合同下载地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
