using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppMessagetemplateSubscribeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppMessagetemplateSubscribeQueryModel : AopObject
    {
        /// <summary>
        /// 消息模板id，可以填写多个，最多不超过3个。模板id需要保持同一个应用主体，并且展示在同一个订阅组件中的模板id
        /// </summary>
        [XmlArray("template_id_list")]
        [XmlArrayItem("string")]
        public List<string> TemplateIdList { get; set; }

        /// <summary>
        /// 订阅消息模板的用户的userid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
