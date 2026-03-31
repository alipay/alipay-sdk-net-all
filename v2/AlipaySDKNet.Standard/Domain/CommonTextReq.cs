using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommonTextReq Data Structure.
    /// </summary>
    [Serializable]
    public class CommonTextReq : AopObject
    {
        /// <summary>
        /// 是一个List<Body>
        /// </summary>
        [XmlArray("language_list")]
        [XmlArrayItem("text_language_req")]
        public List<TextLanguageReq> LanguageList { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("note")]
        public string Note { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("string")]
        public List<string> TagList { get; set; }

        /// <summary>
        /// 文案 key
        /// </summary>
        [XmlElement("text_key")]
        public string TextKey { get; set; }
    }
}
