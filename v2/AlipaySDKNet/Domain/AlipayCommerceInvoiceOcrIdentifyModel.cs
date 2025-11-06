using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceInvoiceOcrIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceInvoiceOcrIdentifyModel : AopObject
    {
        /// <summary>
        /// 文件类型
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 文件下载链接，要求公网可访问
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
