using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RegressionPublic Data Structure.
    /// </summary>
    [Serializable]
    public class RegressionPublic : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a_open_id")]
        public string AOpenId { get; set; }

        /// <summary>
        /// a下普通字段a
        /// </summary>
        [XmlElement("a_test_a")]
        public bool ATestA { get; set; }

        /// <summary>
        /// sdfs
        /// </summary>
        [XmlElement("b")]
        public long B { get; set; }

        /// <summary>
        /// 1999-11-11
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("input_a")]
        public string InputA { get; set; }
    }
}
