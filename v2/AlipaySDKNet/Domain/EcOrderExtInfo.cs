using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcOrderExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcOrderExtInfo : AopObject
    {
        /// <summary>
        /// 键值
        /// </summary>
        [XmlElement("ext_key")]
        public string ExtKey { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [XmlElement("ext_value")]
        public string ExtValue { get; set; }
    }
}
