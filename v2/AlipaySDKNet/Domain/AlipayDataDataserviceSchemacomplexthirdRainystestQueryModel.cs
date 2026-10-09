using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceSchemacomplexthirdRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceSchemacomplexthirdRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 迭代内新增
        /// </summary>
        [XmlElement("demo_new_strong")]
        public RainyComplexTypesRefWeakFirst DemoNewStrong { get; set; }

        /// <summary>
        /// 迭代内新增
        /// </summary>
        [XmlElement("demo_new_weak")]
        public RainyComplexTypesRefWeakSecond DemoNewWeak { get; set; }
    }
}
