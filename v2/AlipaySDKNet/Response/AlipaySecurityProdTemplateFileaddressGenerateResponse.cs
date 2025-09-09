using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTemplateFileaddressGenerateResponse.
    /// </summary>
    public class AlipaySecurityProdTemplateFileaddressGenerateResponse : AopResponse
    {
        /// <summary>
        /// 复制后的文件url
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
