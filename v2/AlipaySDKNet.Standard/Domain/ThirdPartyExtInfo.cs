using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ThirdPartyExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ThirdPartyExtInfo : AopObject
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
