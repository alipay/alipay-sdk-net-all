using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankEcnyFileUploadResponse.
    /// </summary>
    public class MybankEcnyFileUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
