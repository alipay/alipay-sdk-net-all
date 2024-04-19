using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnergyExtRequest Data Structure.
    /// </summary>
    [Serializable]
    public class EnergyExtRequest : AopObject
    {
        /// <summary>
        /// 扩展信息的key信息
        /// </summary>
        [XmlElement("ext_key")]
        public string ExtKey { get; set; }

        /// <summary>
        /// 扩展信息的value信息
        /// </summary>
        [XmlElement("ext_value")]
        public string ExtValue { get; set; }
    }
}
