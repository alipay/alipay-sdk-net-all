using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataexchangeComplextypefirstRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataexchangeComplextypefirstRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 引用复杂类型
        /// </summary>
        [XmlElement("complex_type_01")]
        public RainyComplexTypesRefWeakFirst ComplexType01 { get; set; }

        /// <summary>
        /// 引用已有的复杂类型
        /// </summary>
        [XmlElement("complex_type_02")]
        public RainyComplexTypesTheFirst ComplexType02 { get; set; }
    }
}
