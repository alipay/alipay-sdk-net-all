using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignPlanCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdcampaignPlanCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 计划日预算，单位元【人民币】
        /// </summary>
        [XmlElement("budget")]
        public string Budget { get; set; }

        /// <summary>
        /// 计划结束投放日期，格式为yyyy-MM-dd，新增或者编辑时有改动必须大于等于今天；结束日期必须大于等于开始日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 营销目标参数code
        /// </summary>
        [XmlElement("market_target_code")]
        public string MarketTargetCode { get; set; }

        /// <summary>
        /// 计划id
        /// </summary>
        [XmlElement("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// ON：不限日预算开启 OFF：开启计划日预算（计划日预算字段必填）
        /// </summary>
        [XmlElement("plan_unlimited_budget_switch")]
        public string PlanUnlimitedBudgetSwitch { get; set; }

        /// <summary>
        /// 商家标志,唯一值,在广告投放平台商家详情获取
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 计划开始投放日期，格式为yyyy-MM-dd，新增或者编辑时有改动必须大于等于今天
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 如果是全时段投放，本参数无需传参。 如果指定投放时段，本参数必填，格式为24*7位字符串，且都为 0 和 1，以单小时为最小粒度。按日,一,二,……,六排列。单日内按23,22,21,……3,2,1,0排列。0为不投放，1 为投放，全传 1 视为全时段投放，不允许全部传 0。日维度采用“,”分隔。
        /// </summary>
        [XmlElement("time_schema")]
        public string TimeSchema { get; set; }
    }
}
