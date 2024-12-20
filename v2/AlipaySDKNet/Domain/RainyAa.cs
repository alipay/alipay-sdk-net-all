using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyAa Data Structure.
    /// </summary>
    [Serializable]
    public class RainyAa : AopObject
    {
        /// <summary>
        /// 匿名复杂类型
        /// </summary>
        [XmlElement("object_weak")]
        public RainyAaA ObjectWeak { get; set; }

        /// <summary>
        /// 强引用
        /// </summary>
        [XmlElement("ref_strong")]
        public RainyComplexTypesRefWeakFirst RefStrong { get; set; }
    }
}
