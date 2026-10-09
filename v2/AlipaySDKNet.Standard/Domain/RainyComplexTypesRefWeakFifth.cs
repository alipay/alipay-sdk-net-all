using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyComplexTypesRefWeakFifth Data Structure.
    /// </summary>
    [Serializable]
    public class RainyComplexTypesRefWeakFifth : AopObject
    {
        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("demo_case")]
        public string DemoCase { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("demo_ref_list")]
        [XmlArrayItem("rainys_complex_type_weak_ref_fifth")]
        public List<RainysComplexTypeWeakRefFifth> DemoRefList { get; set; }
    }
}
