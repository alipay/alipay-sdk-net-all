using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyComplexTypesTheFourteen Data Structure.
    /// </summary>
    [Serializable]
    public class RainyComplexTypesTheFourteen : AopObject
    {
        /// <summary>
        /// 复杂类型2.0新增的数据
        /// </summary>
        [XmlElement("demo_case")]
        public RainyComplexTypesRefWeakFirst DemoCase { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 完全引用
        /// </summary>
        [XmlArray("weak_ref")]
        [XmlArrayItem("rainy_complex_types_the_fourth")]
        public List<RainyComplexTypesTheFourth> WeakRef { get; set; }
    }
}
