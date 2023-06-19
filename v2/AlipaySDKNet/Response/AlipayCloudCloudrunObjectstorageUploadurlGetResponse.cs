using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudrunObjectstorageUploadurlGetResponse.
    /// </summary>
    public class AlipayCloudCloudrunObjectstorageUploadurlGetResponse : AopResponse
    {
        /// <summary>
        /// 文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件上传地址
        /// </summary>
        [XmlElement("upload_url")]
        public string UploadUrl { get; set; }
    }
}
