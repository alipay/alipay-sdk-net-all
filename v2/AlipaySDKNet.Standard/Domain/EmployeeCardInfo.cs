using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EmployeeCardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EmployeeCardInfo : AopObject
    {
        /// <summary>
        /// 零工扩展信息
        /// </summary>
        [XmlElement("card_extend_params")]
        public CardExtendParamsDTO CardExtendParams { get; set; }

        /// <summary>
        /// 零工卡工牌ID
        /// </summary>
        [XmlElement("employee_card_no")]
        public string EmployeeCardNo { get; set; }

        /// <summary>
        /// 雇主信息
        /// </summary>
        [XmlElement("hire_principal")]
        public ParticipantInfoDTO HirePrincipal { get; set; }

        /// <summary>
        /// 邀请方信息
        /// </summary>
        [XmlElement("invite_principal")]
        public ParticipantInfoDTO InvitePrincipal { get; set; }
    }
}
