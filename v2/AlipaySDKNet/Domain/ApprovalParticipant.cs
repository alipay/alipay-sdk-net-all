using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApprovalParticipant Data Structure.
    /// </summary>
    [Serializable]
    public class ApprovalParticipant : AopObject
    {
        /// <summary>
        /// 员工ID
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 是否外部同行人
        /// </summary>
        [XmlElement("external_user")]
        public bool ExternalUser { get; set; }

        /// <summary>
        /// 同行人手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 同行人姓名
        /// </summary>
        [XmlElement("participant_name")]
        public string ParticipantName { get; set; }
    }
}
