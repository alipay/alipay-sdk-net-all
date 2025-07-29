using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingBenefitaccountAccountRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingBenefitaccountAccountRefundModel : AopObject
    {
        /// <summary>
        /// 本次操作退款总金额，单位：元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 权益账户号
        /// </summary>
        [XmlElement("benefit_account_no")]
        public string BenefitAccountNo { get; set; }

        /// <summary>
        /// 本次退款业务订单号，用于幂等
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 预算退款类型：扣减
        /// </summary>
        [XmlElement("budget_decrease_type")]
        public string BudgetDecreaseType { get; set; }

        /// <summary>
        /// 退款资金操作明细
        /// </summary>
        [XmlArray("fund_infos")]
        [XmlArrayItem("fs_fund_info_form")]
        public List<FsFundInfoForm> FundInfos { get; set; }

        /// <summary>
        /// 退款操作人ID
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 退款操作人名称
        /// </summary>
        [XmlElement("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 权益账户归属人用户ID
        /// </summary>
        [XmlElement("publisher_user_id")]
        public string PublisherUserId { get; set; }
    }
}
