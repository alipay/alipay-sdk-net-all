using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InviteMemberBusinessParamsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InviteMemberBusinessParamsDTO : AopObject
    {
        /// <summary>
        /// 企业员工工卡
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }
    }
}
