using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneFinresearchKnowledgeStatusQueryResponse.
    /// </summary>
    public class AntfortuneFinresearchKnowledgeStatusQueryResponse : AopResponse
    {
        /// <summary>
        /// 文件处理状态
        /// </summary>
        [XmlElement("upload_status")]
        public string UploadStatus { get; set; }
    }
}
