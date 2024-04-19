using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityJhjtestRegtoantApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityJhjtestRegtoantApplyModel : AopObject
    {
        /// <summary>
        /// a下普通字段a
        /// </summary>
        [XmlElement("a_open_id")]
        public string AOpenId { get; set; }

        /// <summary>
        /// a下普通字段a
        /// </summary>
        [XmlElement("a_test_a")]
        public string ATestA { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("boolean_a")]
        public bool BooleanA { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("comp_a")]
        public RegressionInDomian CompA { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("comp_nest")]
        public PubNestPub CompNest { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("comp_pub")]
        public RegressionPublic CompPub { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("date_a")]
        public string DateA { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("number_a")]
        public long NumberA { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("string_a")]
        public string StringA { get; set; }
    }
}
