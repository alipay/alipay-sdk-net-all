using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BizExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BizExtInfo : AopObject
    {
        /// <summary>
        /// key-value
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }
    }
}
