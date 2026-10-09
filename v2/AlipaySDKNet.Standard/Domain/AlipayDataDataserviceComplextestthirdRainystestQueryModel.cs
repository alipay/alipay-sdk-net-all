using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceComplextestthirdRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceComplextestthirdRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 不同迭代的复杂类型
        /// </summary>
        [XmlElement("complex_type")]
        public RainyComplexTypesTheFourth ComplexType { get; set; }
    }
}
