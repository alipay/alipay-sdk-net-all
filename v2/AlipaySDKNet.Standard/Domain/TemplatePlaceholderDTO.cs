using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplatePlaceholderDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplatePlaceholderDTO : AopObject
    {
        /// <summary>
        /// 占位符的名称
        /// </summary>
        [XmlElement("placeholder_key")]
        public string PlaceholderKey { get; set; }

        /// <summary>
        /// 占位符的值
        /// </summary>
        [XmlElement("placeholder_value")]
        public string PlaceholderValue { get; set; }
    }
}
