using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractOpenApiAttachDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ContractOpenApiAttachDTO : AopObject
    {
        /// <summary>
        /// 文件地址
        /// </summary>
        [XmlElement("file_location")]
        public string FileLocation { get; set; }

        /// <summary>
        /// 合同文件
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件版本
        /// </summary>
        [XmlElement("file_version")]
        public string FileVersion { get; set; }

        /// <summary>
        /// 合同PDF文件
        /// </summary>
        [XmlElement("pdf_file_location")]
        public string PdfFileLocation { get; set; }
    }
}
