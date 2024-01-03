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
        [XmlElement("complex")]
        public PublicTestProd Complex { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("test_a")]
        public string TestA { get; set; }
    }
}
