using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SymptomPartInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SymptomPartInfo : AopObject
    {
        /// <summary>
        /// 症状标志图片
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
        /// 子症状列表
        /// </summary>
        [XmlArray("sub_parts")]
        [XmlArrayItem("symptom_sub_part")]
        public List<SymptomSubPart> SubParts { get; set; }

        /// <summary>
        /// 症状列表
        /// </summary>
        [XmlArray("symptoms")]
        [XmlArrayItem("string")]
        public List<string> Symptoms { get; set; }
    }
}
