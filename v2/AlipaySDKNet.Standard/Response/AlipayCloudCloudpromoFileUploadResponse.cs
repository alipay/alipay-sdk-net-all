using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoFileUploadResponse.
    /// </summary>
    public class AlipayCloudCloudpromoFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 是否安全审核通过
        /// </summary>
        [XmlElement("safed")]
        public bool Safed { get; set; }
    }
}
