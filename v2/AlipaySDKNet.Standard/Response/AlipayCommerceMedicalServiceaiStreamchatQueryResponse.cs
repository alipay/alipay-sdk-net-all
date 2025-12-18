using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalServiceaiStreamchatQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalServiceaiStreamchatQueryResponse : AopResponse
    {
        /// <summary>
        /// 结构
        /// </summary>
        [XmlElement("data")]
        public StreamResponse Data { get; set; }
    }
}
