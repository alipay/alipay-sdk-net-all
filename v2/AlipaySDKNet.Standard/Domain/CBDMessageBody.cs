using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CBDMessageBody Data Structure.
    /// </summary>
    [Serializable]
    public class CBDMessageBody : AopObject
    {
        /// <summary>
        /// 消息模板编号
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 消息体内容，对应消息模板编号
        /// </summary>
        [XmlElement("template_data")]
        public string TemplateData { get; set; }
    }
}
