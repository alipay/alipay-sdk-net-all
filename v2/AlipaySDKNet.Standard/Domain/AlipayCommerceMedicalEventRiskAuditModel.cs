using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalEventRiskAuditModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalEventRiskAuditModel : AopObject
    {
        /// <summary>
        /// 上游工单号
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 业务方请求id，业务方要保证唯一，用于幂等性校验
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 分配给业务方的事件code 
        /// </summary>
        [XmlElement("risk_event_code")]
        public string RiskEventCode { get; set; }

        /// <summary>
        /// 请求参数 参照【蚂蚁文档 NextGuard总线接入文档 】params 
        /// </summary>
        [XmlElement("risk_params")]
        public string RiskParams { get; set; }
    }
}
