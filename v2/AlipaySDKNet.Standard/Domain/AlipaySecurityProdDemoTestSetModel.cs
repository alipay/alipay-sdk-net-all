using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdDemoTestSetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdDemoTestSetModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_date")]
        public string TestDate { get; set; }

        /// <summary>
        /// 1 当前字段已废弃(1111111111111111)
        /// </summary>
        [XmlElement("test_number")]
        public string TestNumber { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_price")]
        public string TestPrice { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_string")]
        public string TestString { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_string_open_id")]
        public string TestStringOpenId { get; set; }
    }
}
