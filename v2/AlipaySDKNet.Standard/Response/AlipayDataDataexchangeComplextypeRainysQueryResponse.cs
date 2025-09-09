using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataexchangeComplextypeRainysQueryResponse.
    /// </summary>
    public class AlipayDataDataexchangeComplextypeRainysQueryResponse : AopResponse
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("references_test_a")]
        public RainyComplexTypesTheSecond ReferencesTestA { get; set; }

        /// <summary>
        /// 引用同迭代的复杂类型
        /// </summary>
        [XmlElement("references_test_b")]
        public RainyComplexTypesTheFirst ReferencesTestB { get; set; }
    }
}
