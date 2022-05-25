using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HitDialogue Data Structure.
    /// </summary>
    [Serializable]
    public class HitDialogue : AopObject
    {
        /// <summary>
        /// 命中结果高亮
        /// </summary>
        [XmlArray("key_words")]
        [XmlArrayItem("dialogue_key_word")]
        public List<DialogueKeyWord> KeyWords { get; set; }

        /// <summary>
        /// 对话句子唯一标识
        /// </summary>
        [XmlElement("pid")]
        public long Pid { get; set; }
    }
}
