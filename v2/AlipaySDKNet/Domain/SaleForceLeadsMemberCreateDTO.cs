using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleForceLeadsMemberCreateDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SaleForceLeadsMemberCreateDTO : AopObject
    {
        /// <summary>
        /// 商机ID
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 海图项目组成员ID
        /// </summary>
        [XmlElement("leads_member_id")]
        public string LeadsMemberId { get; set; }

        /// <summary>
        /// 项目组成员角色枚举CODE
        /// </summary>
        [XmlElement("member_role")]
        public string MemberRole { get; set; }

        /// <summary>
        /// 项目组成员工号
        /// </summary>
        [XmlElement("member_work_no")]
        public string MemberWorkNo { get; set; }

        /// <summary>
        /// 创建人工号
        /// </summary>
        [XmlElement("work_no_create")]
        public string WorkNoCreate { get; set; }
    }
}
