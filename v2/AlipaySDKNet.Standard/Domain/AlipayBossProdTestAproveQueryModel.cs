using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossProdTestAproveQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossProdTestAproveQueryModel : AopObject
    {
        /// <summary>
        /// test
        /// </summary>
        [XmlElement("complex_a")]
        public PublicComplex ComplexA { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("complex_b")]
        public PublicComplex ComplexB { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("platform_a")]
        public string PlatformA { get; set; }

        /// <summary>
        /// 秒速
        /// </summary>
        [XmlElement("platform_complex_a")]
        public Apitestjhj PlatformComplexA { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_open_id")]
        public string TestOpenId { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [XmlElement("test_uid")]
        public string TestUid { get; set; }
    }
}
