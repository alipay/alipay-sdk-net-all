using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleForceLeadsMemberModifyDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SaleForceLeadsMemberModifyDTO : AopObject
    {
        /// <summary>
        /// 商机ID
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 项目组成员ID
        /// </summary>
        [XmlElement("leads_member_id")]
        public string LeadsMemberId { get; set; }

        /// <summary>
        /// 新项目组成员角色
        /// </summary>
        [XmlElement("new_member_role")]
        public string NewMemberRole { get; set; }

        /// <summary>
        /// 新项目组成员工号
        /// </summary>
        [XmlElement("new_member_work_no")]
        public string NewMemberWorkNo { get; set; }

        /// <summary>
        /// 更新人工号
        /// </summary>
        [XmlElement("work_no_update")]
        public string WorkNoUpdate { get; set; }
    }
}
