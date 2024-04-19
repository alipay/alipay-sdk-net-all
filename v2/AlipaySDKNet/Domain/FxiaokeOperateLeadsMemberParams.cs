using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FxiaokeOperateLeadsMemberParams Data Structure.
    /// </summary>
    [Serializable]
    public class FxiaokeOperateLeadsMemberParams : AopObject
    {
        /// <summary>
        /// 纷享销客商机成员主键
        /// </summary>
        [XmlElement("fxiaoke_leads_member_id")]
        public string FxiaokeLeadsMemberId { get; set; }

        /// <summary>
        /// 是否为负责人 0 是 不可删除 1 否
        /// </summary>
        [XmlElement("is_leader")]
        public string IsLeader { get; set; }

        /// <summary>
        /// 商机id
        /// </summary>
        [XmlElement("leads_id")]
        public long LeadsId { get; set; }

        /// <summary>
        /// 海图商机成员主键
        /// </summary>
        [XmlElement("leads_member_id")]
        public string LeadsMemberId { get; set; }

        /// <summary>
        /// 成员角色
        /// </summary>
        [XmlElement("member_role")]
        public string MemberRole { get; set; }

        /// <summary>
        /// 成员工号
        /// </summary>
        [XmlElement("member_work_no")]
        public string MemberWorkNo { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        [XmlElement("work_no_create")]
        public string WorkNoCreate { get; set; }

        /// <summary>
        /// 更新人
        /// </summary>
        [XmlElement("work_no_update")]
        public string WorkNoUpdate { get; set; }
    }
}
