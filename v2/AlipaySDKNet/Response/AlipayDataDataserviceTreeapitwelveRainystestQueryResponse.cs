using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceTreeapitwelveRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceTreeapitwelveRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("res_ref")]
        public RainyComplexTypesTheThirteen ResRef { get; set; }
    }
}
