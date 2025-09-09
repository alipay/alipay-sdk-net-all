using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdJhjtestSupportauthtokenModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdJhjtestSupportauthtokenModifyModel : AopObject
    {
        /// <summary>
        /// 2313
        /// </summary>
        [XmlElement("aaa")]
        public string Aaa { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("com_a")]
        public PublicTestProd ComA { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("is_aasda")]
        public string IsAasda { get; set; }
    }
}
