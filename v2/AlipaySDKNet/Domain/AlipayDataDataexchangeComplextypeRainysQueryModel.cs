using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataexchangeComplextypeRainysQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataexchangeComplextypeRainysQueryModel : AopObject
    {
        /// <summary>
        /// 引用当前迭代；
        /// </summary>
        [XmlElement("references_test_a")]
        public RainyComplexTypesTheFirst ReferencesTestA { get; set; }

        /// <summary>
        /// 引用不同迭代的复杂类型；
        /// </summary>
        [XmlElement("references_test_b")]
        public RainyComplexTypesTheSecond ReferencesTestB { get; set; }
    }
}
