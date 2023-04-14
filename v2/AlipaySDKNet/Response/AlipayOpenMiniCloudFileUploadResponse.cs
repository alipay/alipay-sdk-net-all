using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniCloudFileUploadResponse.
    /// </summary>
    public class AlipayOpenMiniCloudFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件访问地址
        /// </summary>
        [XmlElement("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
