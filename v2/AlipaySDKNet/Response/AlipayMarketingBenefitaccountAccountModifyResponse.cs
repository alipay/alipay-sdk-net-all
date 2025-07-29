using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingBenefitaccountAccountModifyResponse.
    /// </summary>
    public class AlipayMarketingBenefitaccountAccountModifyResponse : AopResponse
    {
        /// <summary>
        /// 权益账户账号
        /// </summary>
        [XmlElement("benefit_account_no")]
        public string BenefitAccountNo { get; set; }

        /// <summary>
        /// 权益账户出资方信息
        /// </summary>
        [XmlArray("fund_infos")]
        [XmlArrayItem("benefit_account_fs_fund_info_d_t_o")]
        public List<BenefitAccountFsFundInfoDTO> FundInfos { get; set; }

        /// <summary>
        /// 出资关系组
        /// </summary>
        [XmlElement("fund_relation_groups")]
        public FsFundRelationGroupDTO FundRelationGroups { get; set; }
    }
}
