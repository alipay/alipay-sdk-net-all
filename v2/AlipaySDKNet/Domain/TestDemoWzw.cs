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
        /// 88
        /// </summary>
        [XmlElement("aaopen_id")]
        public string AaopenId { get; set; }

        /// <summary>
        /// 88
        /// </summary>
        [XmlElement("aauids")]
        public string Aauids { get; set; }

        /// <summary>
        /// 88
        /// </summary>
        [XmlElement("id_type")]
        public string IdType { get; set; }

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
