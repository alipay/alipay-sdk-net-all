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
        /// 文件tag，文件存入oss后生成的tag值。用户可基于该值判断本次上传的文件和上次上传的文件是否一致。
        /// </summary>
        [XmlElement("file_tag")]
        public string FileTag { get; set; }
    }
}
