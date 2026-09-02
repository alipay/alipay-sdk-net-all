using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExternalItemLabel Data Structure.
    /// </summary>
    [Serializable]
    public class ExternalItemLabel : AopObject
    {
        /// <summary>
        /// 标签ID
        /// </summary>
        [XmlElement("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 标签值
        /// </summary>
        [XmlElement("label_value")]
        public string LabelValue { get; set; }
    }
}
