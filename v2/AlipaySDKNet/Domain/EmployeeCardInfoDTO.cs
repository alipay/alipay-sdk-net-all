using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EmployeeCardInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class EmployeeCardInfoDTO : AopObject
    {
        /// <summary>
        /// 零工卡工牌ID
        /// </summary>
        [XmlElement("employee_card_no")]
        public string EmployeeCardNo { get; set; }

        /// <summary>
        /// 雇主信息
        /// </summary>
        [XmlElement("hire_principal")]
        public AttendancePariticipantInfoDTO HirePrincipal { get; set; }
    }
}
