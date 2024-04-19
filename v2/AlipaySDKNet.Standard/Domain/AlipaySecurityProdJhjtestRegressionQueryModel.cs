using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdJhjtestRegressionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdJhjtestRegressionQueryModel : AopObject
    {
        /// <summary>
        /// a下普通字段a
        /// </summary>
        [XmlElement("a_test_a")]
        public string ATestA { get; set; }

        /// <summary>
        /// sss
        /// </summary>
        [XmlElement("boolean_a")]
        public bool BooleanA { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("date_a")]
        public string DateA { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("domain_nest")]
        public DomainNestOther DomainNest { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("nest_pubic")]
        public PubNestPub NestPubic { get; set; }

        /// <summary>
        /// 213
        /// </summary>
        [XmlElement("number_a")]
        public long NumberA { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("only_domin")]
        public RegressionInDomian OnlyDomin { get; set; }

        /// <summary>
        /// dsds
        /// </summary>
        [XmlElement("only_pub")]
        public RegressionPublic OnlyPub { get; set; }

        /// <summary>
        /// aaa
        /// </summary>
        [XmlElement("only_public")]
        public RegressionPublic OnlyPublic { get; set; }

        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("path_para")]
        public string PathPara { get; set; }

        /// <summary>
        /// 1231
        /// </summary>
        [XmlElement("price_a")]
        public string PriceA { get; set; }

        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("query_para")]
        public string QueryPara { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("string")]
        public string String { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("string_open_id")]
        public string StringOpenId { get; set; }
    }
}
