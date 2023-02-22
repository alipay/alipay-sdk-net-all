using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMessageTemplateApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMessageTemplateApplyModel : AopObject
    {
        /// <summary>
        /// 消息关键词列表，需要传入2到5个关键词，关键词内容需要与对应母板关键词对应。注意需传入json数组格式，[{"name":"第一个关键词"},{"name":"第二个关键词"}]
        /// </summary>
        [XmlArray("keyword_list")]
        [XmlArrayItem("msg_apply_keyword")]
        public List<MsgApplyKeyword> KeywordList { get; set; }

        /// <summary>
        /// 消息母板code
        /// </summary>
        [XmlElement("lib_code")]
        public string LibCode { get; set; }

        /// <summary>
        /// 订阅规则，分为一次性订阅和长期性订阅
        /// </summary>
        [XmlElement("scene_rule")]
        public string SceneRule { get; set; }
    }
}
