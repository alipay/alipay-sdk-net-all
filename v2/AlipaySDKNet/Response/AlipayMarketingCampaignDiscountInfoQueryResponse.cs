using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountInfoQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignDiscountInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 代理人
        /// </summary>
        [XmlArray("agents")]
        [XmlArrayItem("string")]
        public List<string> Agents { get; set; }

        /// <summary>
        /// 预警阀值信息
        /// </summary>
        [XmlArray("alert_detail_list")]
        [XmlArrayItem("number")]
        public List<long> AlertDetailList { get; set; }

        /// <summary>
        /// 预警接收人
        /// </summary>
        [XmlArray("alert_users")]
        [XmlArrayItem("string")]
        public List<string> AlertUsers { get; set; }

        /// <summary>
        /// 总预算金额(元)
        /// </summary>
        [XmlElement("budget_amount")]
        public string BudgetAmount { get; set; }

        /// <summary>
        /// 创建人姓名
        /// </summary>
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 活动描述
        /// </summary>
        [XmlElement("discount_desc")]
        public string DiscountDesc { get; set; }

        /// <summary>
        /// 活动Id
        /// </summary>
        [XmlElement("discount_id")]
        public string DiscountId { get; set; }

        /// <summary>
        /// 立减活动名称
        /// </summary>
        [XmlElement("discount_name")]
        public string DiscountName { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 需求方
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 活动的定价策略
        /// </summary>
        [XmlElement("price_calc_type")]
        public string PriceCalcType { get; set; }

        /// <summary>
        /// 剩余预算(元)
        /// </summary>
        [XmlElement("remaining_budget_amount")]
        public string RemainingBudgetAmount { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 状态信息
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 已使用预算金额(元)
        /// </summary>
        [XmlElement("used_budget_amount")]
        public string UsedBudgetAmount { get; set; }
    }
}
