using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseLayerVersionUploadResponse.
    /// </summary>
    public class AlipayCloudCloudbaseLayerVersionUploadResponse : AopResponse
    {
        /// <summary>
        /// 上传id
        /// </summary>
        [XmlElement("upload_id")]
        public string UploadId { get; set; }

        /// <summary>
        /// 文件当前保存路径
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
