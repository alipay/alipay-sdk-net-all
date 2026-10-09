using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceRcservcenterRcsmartConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceRcservcenterRcsmartConfirmModel : AopObject
    {
        /// <summary>
        /// 调用方系统信息
        /// </summary>
        [XmlElement("app_info")]
        public RcsmartCommonAppInfo AppInfo { get; set; }

        /// <summary>
        /// 工单维度机审结果
        /// </summary>
        [XmlElement("task_robot_audit_feedback_req")]
        public TaskRobotAuditFeedbackReq TaskRobotAuditFeedbackReq { get; set; }
    }
}
