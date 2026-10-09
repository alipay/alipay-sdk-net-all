using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryNucleicacidCodeVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryNucleicacidCodeVerifyModel : AopObject
    {
        /// <summary>
        /// 核酸码值。对该码值进行核验，得知该码值的有效性
        /// </summary>
        [XmlElement("nucleic_acid_code")]
        public string NucleicAcidCode { get; set; }
    }
}
