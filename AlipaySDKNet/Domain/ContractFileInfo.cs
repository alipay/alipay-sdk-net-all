using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractFileInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ContractFileInfo : AopObject
    {
        /// <summary>
        /// 合同文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 合同文件url
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
