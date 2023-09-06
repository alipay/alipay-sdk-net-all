using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateInstanceDownloadResponse.
    /// </summary>
    public class AlipayFincoreComplianceTemplateInstanceDownloadResponse : AopResponse
    {
        /// <summary>
        /// 下载链接
        /// </summary>
        [XmlElement("down_url")]
        public string DownUrl { get; set; }
    }
}
