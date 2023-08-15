using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunStaticsiteUploadurlCreateResponse.
    /// </summary>
    public class AlipayCloudCloudrunStaticsiteUploadurlCreateResponse : AopResponse
    {
        /// <summary>
        /// 文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 上传文件的URL
        /// </summary>
        [XmlElement("upload_url")]
        public string UploadUrl { get; set; }
    }
}
