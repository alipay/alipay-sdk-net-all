using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SyllabusStructuredModifyVO Data Structure.
    /// </summary>
    [Serializable]
    public class SyllabusStructuredModifyVO : AopObject
    {
        /// <summary>
        /// 章节
        /// </summary>
        [XmlElement("chapter")]
        public string Chapter { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("sections")]
        [XmlArrayItem("string")]
        public List<string> Sections { get; set; }
    }
}
