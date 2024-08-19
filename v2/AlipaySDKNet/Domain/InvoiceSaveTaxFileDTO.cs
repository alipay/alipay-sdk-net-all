using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceSaveTaxFileDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceSaveTaxFileDTO : AopObject
    {
        /// <summary>
        /// 采购报税文件名称
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 采购报税文件大小
        /// </summary>
        [XmlElement("file_size")]
        public long FileSize { get; set; }

        /// <summary>
        /// 采购报税文件资源ID
        /// </summary>
        [XmlElement("resource_id")]
        public string ResourceId { get; set; }
    }
}
