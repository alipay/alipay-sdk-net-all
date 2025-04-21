using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceTreeapithirdteenRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceTreeapithirdteenRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 引用复杂类型
        /// </summary>
        [XmlElement("res_strong_ref")]
        public RainyComplexTypesTheThirteen ResStrongRef { get; set; }
    }
}
