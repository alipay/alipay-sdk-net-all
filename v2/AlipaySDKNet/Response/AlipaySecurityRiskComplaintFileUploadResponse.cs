using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskComplaintFileUploadResponse.
    /// </summary>
    public class AlipaySecurityRiskComplaintFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 本次上传的文件生成的key
        /// </summary>
        [XmlElement("file_key")]
        public string FileKey { get; set; }

        /// <summary>
        /// 本次上传的文件名
        /// </summary>
        [XmlElement("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 本次上传的文件生成的url
        /// </summary>
        [XmlElement("file_url")]
        public string FileUrl { get; set; }
    }
}
