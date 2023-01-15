using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TestDemoWzw Data Structure.
    /// </summary>
    [Serializable]
    public class TestDemoWzw : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("oid_open_id")]
        public string OidOpenId { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
