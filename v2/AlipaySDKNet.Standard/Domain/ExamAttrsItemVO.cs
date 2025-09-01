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
        /// 属性Key
        /// </summary>
        [XmlElement("attr_key")]
        public string AttrKey { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [XmlElement("attr_value")]
        public string AttrValue { get; set; }
    }
}
