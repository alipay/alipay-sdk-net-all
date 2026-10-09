using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Area Data Structure.
    /// </summary>
    [Serializable]
    public class Area : AopObject
    {
        /// <summary>
        /// 围栏列表
        /// </summary>
        [XmlArray("fences")]
        [XmlArrayItem("fence_dto")]
        public List<FenceDto> Fences { get; set; }
    }
}
