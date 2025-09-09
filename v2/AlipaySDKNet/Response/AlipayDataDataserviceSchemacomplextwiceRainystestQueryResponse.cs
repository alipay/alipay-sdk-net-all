using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceSchemacomplextwiceRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceSchemacomplextwiceRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 强引用复杂类型
        /// </summary>
        [XmlElement("demo_strong_complextype")]
        public RainyComplexTypesTheSecond DemoStrongComplextype { get; set; }

        /// <summary>
        /// V1.3版本引用
        /// </summary>
        [XmlElement("demo_weak_complextype")]
        public RainyComplexTypeRefWeakFirst DemoWeakComplextype { get; set; }
    }
}
