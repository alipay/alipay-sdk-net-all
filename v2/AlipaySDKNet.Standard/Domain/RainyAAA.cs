using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyAAA Data Structure.
    /// </summary>
    [Serializable]
    public class RainyAAA : AopObject
    {
        /// <summary>
        /// 是个啥呢
        /// </summary>
        [XmlElement("object_havnt_name")]
        public RainyAa ObjectHavntName { get; set; }
    }
}
