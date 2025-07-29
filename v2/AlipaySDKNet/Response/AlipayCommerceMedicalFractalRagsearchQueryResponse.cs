using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalFractalRagsearchQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalFractalRagsearchQueryResponse : AopResponse
    {
        /// <summary>
        /// 请求信息，包含query, results, responseTime
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
