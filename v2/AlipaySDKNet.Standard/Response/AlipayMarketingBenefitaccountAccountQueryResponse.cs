using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingBenefitaccountAccountQueryResponse.
    /// </summary>
    public class AlipayMarketingBenefitaccountAccountQueryResponse : AopResponse
    {
        /// <summary>
        /// 权益账户号
        /// </summary>
        [XmlElement("benefit_account_no")]
        public string BenefitAccountNo { get; set; }

        /// <summary>
        /// 权益账户当前剩余可核销金额，单位：元
        /// </summary>
        [XmlElement("current_amount")]
        public string CurrentAmount { get; set; }

        /// <summary>
        /// 权益账户生效时间
        /// </summary>
        [XmlElement("effective_time")]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 权益账户失效时间
        /// </summary>
        [XmlElement("expired_time")]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// 权益账户出资明细
        /// </summary>
        [XmlArray("fund_infos")]
        [XmlArrayItem("benefit_account_fs_fund_info_d_t_o")]
        public List<BenefitAccountFsFundInfoDTO> FundInfos { get; set; }

        /// <summary>
        /// 预授权资金信息
        /// </summary>
        [XmlElement("fund_pre_auth_info")]
        public BenefitAccountFundPreAuthInfoDTO FundPreAuthInfo { get; set; }

        /// <summary>
        /// 出资关系组
        /// </summary>
        [XmlArray("fund_relation_groups")]
        [XmlArrayItem("fs_fund_relation_group_d_t_o")]
        public List<FsFundRelationGroupDTO> FundRelationGroups { get; set; }

        /// <summary>
        /// 权益账户的账户名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 有效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 权益账户总金额，随着退款缩减而变化，单位：元
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }
    }
}
