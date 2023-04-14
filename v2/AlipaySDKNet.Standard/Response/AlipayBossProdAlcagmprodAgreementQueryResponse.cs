using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdAlcagmprodAgreementQueryResponse.
    /// </summary>
    public class AlipayBossProdAlcagmprodAgreementQueryResponse : AopResponse
    {
        /// <summary>
        /// S-签约  U-解约
        /// </summary>
        [XmlElement("result_data")]
        public string ResultData { get; set; }

        /// <summary>
        /// 请求结果状态
        /// </summary>
        [XmlElement("result_success")]
        public bool ResultSuccess { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [XmlElement("result_trace_id")]
        public string ResultTraceId { get; set; }
    }
}
