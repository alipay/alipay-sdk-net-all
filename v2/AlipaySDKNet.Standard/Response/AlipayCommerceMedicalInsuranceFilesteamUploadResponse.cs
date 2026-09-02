using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceFilesteamUploadResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceFilesteamUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件url
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
