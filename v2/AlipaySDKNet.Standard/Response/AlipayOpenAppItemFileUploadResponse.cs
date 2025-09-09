using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppItemFileUploadResponse.
    /// </summary>
    public class AlipayOpenAppItemFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件可访问地址
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
