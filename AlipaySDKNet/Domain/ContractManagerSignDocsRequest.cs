using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ContractManagerSignDocsRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ContractManagerSignDocsRequest : AopObject
    {
        /// <summary>
        /// 签署文件fileId
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 签署文档文件
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 签署文档总页数
        /// </summary>
        [XmlElement("total_page")]
        public string TotalPage { get; set; }
    }
}
