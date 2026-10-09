using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MsgTemplateContentVO Data Structure.
    /// </summary>
    [Serializable]
    public class MsgTemplateContentVO : AopObject
    {
        /// <summary>
        /// 消息卡片跳转地址
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 消息卡片上关键词展示信息，包括关键词对应的名称和关键词具体的内容
        /// </summary>
        [XmlArray("keyword_list")]
        [XmlArrayItem("keyword_v_o")]
        public List<KeywordVO> KeywordList { get; set; }

        /// <summary>
        /// 消息模板标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
