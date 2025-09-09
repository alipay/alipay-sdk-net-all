using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceSchemacomplextwiceRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceSchemacomplextwiceRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 强引用复杂类型
        /// </summary>
        [XmlElement("demo_strong_complextype")]
        public RainyComplexTypesTheSecond DemoStrongComplextype { get; set; }

        /// <summary>
        /// 弱引用复杂
        /// </summary>
        [XmlElement("demo_weak_complextype")]
        public RainyComplexTypeRefWeakFirst DemoWeakComplextype { get; set; }

        /// <summary>
        /// V1.3新增的
        /// </summary>
        [XmlElement("weak_complextype")]
        public RainyComplexTypeRefWeakSecond WeakComplextype { get; set; }
    }
}
