using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoAichatFileUploadResponse.
    /// </summary>
    public class AlipayCloudCloudpromoAichatFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 文件标签
        /// </summary>
        [XmlElement("file_tag")]
        public string FileTag { get; set; }
    }
}
