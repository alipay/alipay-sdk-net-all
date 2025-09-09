using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RainyComplexTypesTheFifteenOne Data Structure.
    /// </summary>
    [Serializable]
    public class RainyComplexTypesTheFifteenOne : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("weak_ref")]
        [XmlArrayItem("rainy_complex_types_the_fourth")]
        public List<RainyComplexTypesTheFourth> WeakRef { get; set; }
    }
}
