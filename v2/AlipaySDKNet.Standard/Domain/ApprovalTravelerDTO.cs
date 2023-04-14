using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApprovalTravelerDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApprovalTravelerDTO : AopObject
    {
        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 外部同行人手机号
        /// </summary>
        [XmlElement("external_user_mobile")]
        public string ExternalUserMobile { get; set; }

        /// <summary>
        /// 外部同行人名称
        /// </summary>
        [XmlElement("external_user_name")]
        public string ExternalUserName { get; set; }
    }
}
