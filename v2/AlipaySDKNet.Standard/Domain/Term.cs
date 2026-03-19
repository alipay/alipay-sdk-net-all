using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Term Data Structure.
    /// </summary>
    [Serializable]
    public class Term : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("faculty_list")]
        [XmlArrayItem("faculty")]
        public List<Faculty> FacultyList { get; set; }

        /// <summary>
        /// 词条拼音
        /// </summary>
        [XmlElement("pinyin")]
        public string Pinyin { get; set; }

        /// <summary>
        /// 词条同义词
        /// </summary>
        [XmlElement("synonyms")]
        public string Synonyms { get; set; }

        /// <summary>
        /// 词条ID
        /// </summary>
        [XmlElement("term_id")]
        public string TermId { get; set; }

        /// <summary>
        /// 词条名称
        /// </summary>
        [XmlElement("term_name")]
        public string TermName { get; set; }

        /// <summary>
        /// 词条类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
