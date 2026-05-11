using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RightsResult Data Structure.
    /// </summary>
    [Serializable]
    public class RightsResult : AopObject
    {
        /// <summary>
        /// 是否有权益
        /// </summary>
        [XmlElement("rights")]
        public string Rights { get; set; }
    }
}
