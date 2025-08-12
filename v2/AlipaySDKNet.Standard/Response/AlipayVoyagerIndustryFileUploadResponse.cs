using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayVoyagerIndustryFileUploadResponse.
    /// </summary>
    public class AlipayVoyagerIndustryFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件上传成功后的链接
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
