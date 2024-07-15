using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdComplextypeRainysQueryResponse.
    /// </summary>
    public class AlipaySecurityProdComplextypeRainysQueryResponse : AopResponse
    {
        /// <summary>
        /// 引用同迭代的复杂类型
        /// </summary>
        [XmlElement("references_test_a")]
        public RainyComplexTypesTheSecond ReferencesTestA { get; set; }
    }
}
