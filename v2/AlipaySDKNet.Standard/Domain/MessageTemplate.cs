using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MessageTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class MessageTemplate : AopObject
    {
        /// <summary>
        /// 消息主体
        /// </summary>
        [XmlElement("context")]
        public MessageContext Context { get; set; }

        /// <summary>
        /// 消息模板ID
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
