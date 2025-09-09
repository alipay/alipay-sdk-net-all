using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingBenefitaccountAccountModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingBenefitaccountAccountModifyModel : AopObject
    {
        /// <summary>
        /// 权益账户账号
        /// </summary>
        [XmlElement("benefit_account_no")]
        public string BenefitAccountNo { get; set; }

        /// <summary>
        /// 业务本次修改业务订单号，用于幂等
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 出资方信息
        /// </summary>
        [XmlArray("fund_infos")]
        [XmlArrayItem("fs_fund_info_form")]
        public List<FsFundInfoForm> FundInfos { get; set; }

        /// <summary>
        /// 出资关系组
        /// </summary>
        [XmlArray("fund_relation_groups")]
        [XmlArrayItem("fs_fund_relation_group_form")]
        public List<FsFundRelationGroupForm> FundRelationGroups { get; set; }

        /// <summary>
        /// 权益账户归属人对应的支付宝账号
        /// </summary>
        [XmlElement("publisher_user_id")]
        public string PublisherUserId { get; set; }
    }
}
