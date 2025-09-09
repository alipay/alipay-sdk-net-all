using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EpContactBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EpContactBaseInfo : AopObject
    {
        /// <summary>
        /// 联系方式可信度
        /// </summary>
        [XmlElement("confidence_level")]
        public string ConfidenceLevel { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [XmlElement("contact_number")]
        public string ContactNumber { get; set; }
    }
}
