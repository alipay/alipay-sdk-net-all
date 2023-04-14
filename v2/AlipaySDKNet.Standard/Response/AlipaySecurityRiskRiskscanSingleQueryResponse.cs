using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityRiskRiskscanSingleQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskRiskscanSingleQueryResponse : AopResponse
    {
        /// <summary>
        /// 业务返回数据，这是一个JsonString，Json中的key根据业务不同而不同，接入时商定。
        /// </summary>
        [XmlElement("scan_result_data")]
        public string ScanResultData { get; set; }
    }
}
