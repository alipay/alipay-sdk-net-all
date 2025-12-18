using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExamAttrsItemVO Data Structure.
    /// </summary>
    [Serializable]
    public class ExamAttrsItemVO : AopObject
    {
        /// <summary>
        /// 属性desc
        /// </summary>
        [XmlElement("attr_desc")]
        public string AttrDesc { get; set; }

        /// <summary>
        /// 属性key
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 属性value
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }
    }
}
