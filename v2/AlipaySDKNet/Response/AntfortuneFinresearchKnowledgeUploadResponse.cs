using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchKnowledgeUploadResponse.
    /// </summary>
    public class AntfortuneFinresearchKnowledgeUploadResponse : AopResponse
    {
        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
