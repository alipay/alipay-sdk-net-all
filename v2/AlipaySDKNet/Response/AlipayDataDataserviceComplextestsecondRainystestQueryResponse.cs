using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceComplextestsecondRainystestQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceComplextestsecondRainystestQueryResponse : AopResponse
    {
        /// <summary>
        /// 测试数据
        /// </summary>
        [XmlElement("response_case")]
        public RainyComplexTypesTheFourth ResponseCase { get; set; }
    }
}
