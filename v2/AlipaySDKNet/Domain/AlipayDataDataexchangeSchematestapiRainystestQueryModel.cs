using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataexchangeSchematestapiRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataexchangeSchematestapiRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 321
        /// </summary>
        [XmlElement("demo_ref")]
        public RainyComplexTypesRefWeakFirst DemoRef { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("demo_ref_no")]
        [XmlArrayItem("rainy_complex_types_ref_weak_first")]
        public List<RainyComplexTypesRefWeakFirst> DemoRefNo { get; set; }
    }
}
