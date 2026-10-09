using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchKnowledgeStatusQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchKnowledgeStatusQueryModel : AopObject
    {
        /// <summary>
        /// 文件id
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
