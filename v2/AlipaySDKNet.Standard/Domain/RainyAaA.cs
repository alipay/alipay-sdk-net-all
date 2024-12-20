using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyAaA Data Structure.
    /// </summary>
    [Serializable]
    public class RainyAaA : AopObject
    {
        /// <summary>
        /// 弱引用
        /// </summary>
        [XmlElement("ref_weak")]
        public RainyWeakRefFourth RefWeak { get; set; }
    }
}
