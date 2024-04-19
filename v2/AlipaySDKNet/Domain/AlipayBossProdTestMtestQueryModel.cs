using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdTestMtestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdTestMtestQueryModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_string")]
        public string TestString { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_string_open_id")]
        public string TestStringOpenId { get; set; }
    }
}
