using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KeywordVO Data Structure.
    /// </summary>
    [Serializable]
    public class KeywordVO : AopObject
    {
        /// <summary>
        /// 关键词名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 关键词内容
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
