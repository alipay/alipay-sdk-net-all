using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppTestTestChargeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTestTestChargeModel : AopObject
    {
        /// <summary>
        /// 11
        /// </summary>
        [XmlElement("a")]
        public string A { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("b")]
        public string B { get; set; }

        /// <summary>
        /// a
        /// </summary>
        [XmlElement("c")]
        public string C { get; set; }

        /// <summary>
        /// 复杂类型参数
        /// </summary>
        [XmlElement("complex_param")]
        public OpenidComplex ComplexParam { get; set; }

        /// <summary>
        /// das
        /// </summary>
        [XmlElement("d")]
        public string D { get; set; }
    }
}
