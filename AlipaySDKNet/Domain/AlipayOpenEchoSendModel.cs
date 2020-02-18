using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenEchoSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenEchoSendModel : AopObject
    {
        /// <summary>
        /// city
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
