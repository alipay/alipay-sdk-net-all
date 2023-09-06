using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceDataJhjtestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceDataJhjtestQueryModel : AopObject
    {
        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("input_a")]
        public string InputA { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("input_b")]
        public string InputB { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("input_c")]
        public string InputC { get; set; }

        /// <summary>
        /// 111
        /// </summary>
        [XmlElement("input_c_yincang")]
        public string InputCYincang { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("input_complex_a")]
        public PublicComplex InputComplexA { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("input_d")]
        public string InputD { get; set; }

        /// <summary>
        /// aa
        /// </summary>
        [XmlElement("input_e")]
        public string InputE { get; set; }
    }
}
