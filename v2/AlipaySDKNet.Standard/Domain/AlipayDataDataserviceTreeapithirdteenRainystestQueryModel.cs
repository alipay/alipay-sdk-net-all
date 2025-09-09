using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceTreeapithirdteenRainystestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceTreeapithirdteenRainystestQueryModel : AopObject
    {
        /// <summary>
        /// 引用复杂类型
        /// </summary>
        [XmlElement("req_ref_strong")]
        public RainyComplexTypesTheThirteen ReqRefStrong { get; set; }
    }
}
