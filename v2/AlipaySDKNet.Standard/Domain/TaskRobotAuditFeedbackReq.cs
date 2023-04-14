using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TaskRobotAuditFeedbackReq Data Structure.
    /// </summary>
    [Serializable]
    public class TaskRobotAuditFeedbackReq : AopObject
    {
        /// <summary>
        /// 打标信息
        /// </summary>
        [XmlElement("audit_result")]
        public string AuditResult { get; set; }

        /// <summary>
        /// 工单维度机审结果反馈 机审结果是否正确true/false
        /// </summary>
        [XmlElement("audit_status")]
        public bool AuditStatus { get; set; }

        /// <summary>
        /// 请求Id，与app_name组成唯一健，保证业务请求幂等性，同时在请求完毕后，获取业务风险详情信息结果使用
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
