using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SymptomSubPart Data Structure.
    /// </summary>
    [Serializable]
    public class SymptomSubPart : AopObject
    {
        /// <summary>
        /// 标志
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 顺序
        /// </summary>
        [XmlElement("order")]
        public long Order { get; set; }

        /// <summary>
        /// 症状
        /// </summary>
        [XmlArray("symptoms")]
        [XmlArrayItem("string")]
        public List<string> Symptoms { get; set; }
    }
}
