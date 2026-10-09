using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MemberExtInfo : AopObject
    {
        /// <summary>
        /// 员工工号信息
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }
    }
}
