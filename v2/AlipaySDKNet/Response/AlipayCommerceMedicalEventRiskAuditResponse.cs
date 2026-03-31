using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalEventRiskAuditResponse.
    /// </summary>
    public class AlipayCommerceMedicalEventRiskAuditResponse : AopResponse
    {
        /// <summary>
        /// 事件id
        /// </summary>
        [XmlElement("event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 事件code
        /// </summary>
        [XmlElement("risk_event_code")]
        public string RiskEventCode { get; set; }

        /// <summary>
        /// SUCCESS表示有审核结果，不需要等待结果消息 INIT或者PROCESSING表示需要等待消息 见【 NextGuard总线接入文档 】审核返回status
        /// </summary>
        [XmlElement("risk_process")]
        public string RiskProcess { get; set; }
    }
}
