using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LabelValue Data Structure.
    /// </summary>
    [Serializable]
    public class LabelValue : AopObject
    {
        /// <summary>
        /// keyvalue对的key
        /// </summary>
        [XmlElement("label")]
        public string Label { get; set; }

        /// <summary>
        /// keyvalue对的value值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
