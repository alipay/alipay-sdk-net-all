using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FeedbackSuboption Data Structure.
    /// </summary>
    [Serializable]
    public class FeedbackSuboption : AopObject
    {
        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 名称值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
