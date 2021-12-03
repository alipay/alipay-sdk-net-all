using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenFileUploadResponse.
    /// </summary>
    public class AlipayOpenFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件id，用于提供后后续业务调用使用
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
