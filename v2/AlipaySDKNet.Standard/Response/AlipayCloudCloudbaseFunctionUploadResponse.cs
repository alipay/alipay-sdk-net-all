using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudbaseFunctionUploadResponse.
    /// </summary>
    public class AlipayCloudCloudbaseFunctionUploadResponse : AopResponse
    {
        /// <summary>
        /// 部署任务id
        /// </summary>
        [XmlElement("upload_id")]
        public string UploadId { get; set; }

        /// <summary>
        /// 上传使用的url链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
