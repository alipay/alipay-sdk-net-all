using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalFileSteamUploadResponse.
    /// </summary>
    public class AlipayCommerceMedicalFileSteamUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件访问url
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
