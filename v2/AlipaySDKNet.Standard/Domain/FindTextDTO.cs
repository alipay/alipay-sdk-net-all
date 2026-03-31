using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FindTextDTO Data Structure.
    /// </summary>
    [Serializable]
    public class FindTextDTO : AopObject
    {
        /// <summary>
        /// 文案内容列表
        /// </summary>
        [XmlArray("language_list")]
        [XmlArrayItem("text_language_d_t_o")]
        public List<TextLanguageDTO> LanguageList { get; set; }

        /// <summary>
        /// 文案key
        /// </summary>
        [XmlElement("text_key")]
        public string TextKey { get; set; }
    }
}
