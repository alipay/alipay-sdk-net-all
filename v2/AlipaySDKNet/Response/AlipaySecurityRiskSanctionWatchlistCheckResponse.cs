using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskSanctionWatchlistCheckResponse.
    /// </summary>
    public class AlipaySecurityRiskSanctionWatchlistCheckResponse : AopResponse
    {
        /// <summary>
        /// 可追溯响应ID
        /// </summary>
        [XmlElement("open_trace_id")]
        public string OpenTraceId { get; set; }

        /// <summary>
        /// 人行制裁扫描返回结果
        /// </summary>
        [XmlElement("pbc_scan_result")]
        public PBCScanResult PbcScanResult { get; set; }
    }
}
