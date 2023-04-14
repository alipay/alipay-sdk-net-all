using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AgmComponentInstanceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class AgmComponentInstanceDTO : AopObject
    {
        /// <summary>
        /// 组件唯一标识
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 组件名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 模板编码
        /// </summary>
        [XmlElement("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 组件具体填写结果
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
