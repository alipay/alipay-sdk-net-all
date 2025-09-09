using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalSignpathModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalSignpathModifyModel : AopObject
    {
        /// <summary>
        /// 阿里云结算模式
        /// </summary>
        [XmlElement("alicloud_settlement_mode")]
        public string AlicloudSettlementMode { get; set; }

        /// <summary>
        /// 0=审批中，1=审批驳回，2=审批通过，6=撤销审批
        /// </summary>
        [XmlElement("approval_status")]
        public long ApprovalStatus { get; set; }

        /// <summary>
        /// 最终客户签约对方主体ID，客户则为BID，伙伴则为PID
        /// </summary>
        [XmlElement("final_customer_sign_other_party_subject_id")]
        public string FinalCustomerSignOtherPartySubjectId { get; set; }

        /// <summary>
        /// 最终客户签约对方主体名称
        /// </summary>
        [XmlElement("final_customer_sign_other_party_subject_name")]
        public string FinalCustomerSignOtherPartySubjectName { get; set; }

        /// <summary>
        /// 总代合作类型枚举
        /// </summary>
        [XmlElement("general_agent_cooperation_type")]
        public string GeneralAgentCooperationType { get; set; }

        /// <summary>
        /// 商机编码
        /// </summary>
        [XmlElement("leads_code")]
        public string LeadsCode { get; set; }

        /// <summary>
        /// 伙伴ID，多个逗号隔开
        /// </summary>
        [XmlElement("leads_other_partners")]
        public string LeadsOtherPartners { get; set; }

        /// <summary>
        /// 其他伙伴名字,多个逗号隔开
        /// </summary>
        [XmlElement("leads_other_partners_name")]
        public string LeadsOtherPartnersName { get; set; }

        /// <summary>
        /// 操作人工号
        /// </summary>
        [XmlElement("modifier")]
        public string Modifier { get; set; }

        /// <summary>
        /// OB签约对方主体ID，客户则为BID，伙伴则为PID
        /// </summary>
        [XmlElement("ob_sign_other_party_subject_id")]
        public string ObSignOtherPartySubjectId { get; set; }

        /// <summary>
        /// OB签约对方主体名称
        /// </summary>
        [XmlElement("ob_sign_other_party_subject_name")]
        public string ObSignOtherPartySubjectName { get; set; }

        /// <summary>
        /// 签约路径枚举
        /// </summary>
        [XmlElement("sign_path")]
        public string SignPath { get; set; }
    }
}
