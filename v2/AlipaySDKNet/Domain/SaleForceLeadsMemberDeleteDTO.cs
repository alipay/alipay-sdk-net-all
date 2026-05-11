using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SaleForceLeadsMemberDeleteDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SaleForceLeadsMemberDeleteDTO : AopObject
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
        /// 删除人工号
        /// </summary>
        [XmlElement("work_no_delete")]
        public string WorkNoDelete { get; set; }
    }
}
