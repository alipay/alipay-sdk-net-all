using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RateInfo : AopObject
    {
        /// <summary>
        /// 税率描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }
    }
}
