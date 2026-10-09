using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossProdContractCaVerifyResponse.
    /// </summary>
    public class AlipayBossProdContractCaVerifyResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlArray("result_data")]
        [XmlArrayItem("pdf_certificate_result")]
        public List<PdfCertificateResult> ResultData { get; set; }

        /// <summary>
        /// traceId编码
        /// </summary>
        [XmlElement("result_trace_id")]
        public string ResultTraceId { get; set; }
    }
}
