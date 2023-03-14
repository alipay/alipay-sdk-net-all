using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecontrolIssuebatchCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpensecontrolIssuebatchCreateModel : AopObject
    {
        /// <summary>
        /// 共同账户id - 通过企业码1.0接口签约的共同账户，和agreement_no搭配使用
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 发放批次号，用于幂等校验本次发放
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 额度有效结束时间
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 额度有效起始时间
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 企业ID - 通过企业码2.0签约接口签约的企业
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 发放说明
        /// </summary>
        [XmlElement("issue_desc")]
        public string IssueDesc { get; set; }

        /// <summary>
        /// 发放名称
        /// </summary>
        [XmlElement("issue_name")]
        public string IssueName { get; set; }

        /// <summary>
        /// 员工发放信息列表
        /// </summary>
        [XmlArray("issue_target_info_list")]
        [XmlArrayItem("issue_target_info_content")]
        public List<IssueTargetInfoContent> IssueTargetInfoList { get; set; }

        /// <summary>
        /// 额度类型
        /// </summary>
        [XmlElement("quota_type")]
        public string QuotaType { get; set; }

        /// <summary>
        /// 是否可转赠，枚举：0（不可转赠）、1（可转赠）
        /// </summary>
        [XmlElement("share_mode")]
        public string ShareMode { get; set; }
    }
}
