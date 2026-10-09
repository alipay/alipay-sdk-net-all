using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JhjTestNew Data Structure.
    /// </summary>
    [Serializable]
    public class JhjTestNew : AopObject
    {
        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("aaa")]
        public string Aaa { get; set; }
    }
}
