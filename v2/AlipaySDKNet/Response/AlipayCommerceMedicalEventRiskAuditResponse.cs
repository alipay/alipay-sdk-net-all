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
        /// 请求参数 参照【蚂蚁文档 NextGuard总线接入文档 】 auditItemResultList
        /// </summary>
        [XmlElement("audit_item_result_list")]
        public string AuditItemResultList { get; set; }

        /// <summary>
        /// 事件id
        /// </summary>
        [XmlElement("event_id")]
        public string EventId { get; set; }

        /// <summary>
        /// 一般放存证信息
        /// </summary>
        [XmlElement("notarization")]
        public string Notarization { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 事件code
        /// </summary>
        [XmlElement("risk_event_code")]
        public string RiskEventCode { get; set; }

        /// <summary>
        /// 请求参数 参照【蚂蚁文档 NextGuard总线接入文档 】params riskLabelList
        /// </summary>
        [XmlElement("risk_label_list")]
        public string RiskLabelList { get; set; }

        /// <summary>
        /// SUCCESS表示有审核结果，不需要等待结果消息 INIT或者PROCESSING表示需要等待消息 见【 NextGuard总线接入文档 】审核返回status
        /// </summary>
        [XmlElement("risk_process")]
        public string RiskProcess { get; set; }
    }
}
