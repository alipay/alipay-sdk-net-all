using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditCreditriskJhjtestProdCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditCreditriskJhjtestProdCreateModel : AopObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("a_openid")]
        public string AOpenid { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("b_openid")]
        public string BOpenid { get; set; }

        /// <summary>
        /// 1111
        /// </summary>
        [XmlElement("complex")]
        public PublicTestProd Complex { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_a")]
        public string TestA { get; set; }

        /// <summary>
        /// 11111 当前字段已废弃(1111)
        /// </summary>
        [XmlElement("test_b")]
        public string TestB { get; set; }
    }
}
