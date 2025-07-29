using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignPlanQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignPlanQueryResponse : AopResponse
    {
        /// <summary>
        /// 计划日预算。单位：元【人民币】不限日预算时此值为空
        /// </summary>
        [XmlElement("budget")]
        public string Budget { get; set; }

        /// <summary>
        /// 计划计费方式。CPC
        /// </summary>
        [XmlElement("charge_type")]
        public string ChargeType { get; set; }

        /// <summary>
        /// 计划投放结束日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 计划修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 二级营销目标code
        /// </summary>
        [XmlElement("market_target_code")]
        public string MarketTargetCode { get; set; }

        /// <summary>
        /// 营销目标配置
        /// </summary>
        [XmlElement("market_target_config")]
        public MarketTargetConfiguration MarketTargetConfig { get; set; }

        /// <summary>
        /// 二级营销目标名称
        /// </summary>
        [XmlElement("market_target_name")]
        public string MarketTargetName { get; set; }

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
        /// 计划状态
        /// </summary>
        [XmlElement("plan_status")]
        public string PlanStatus { get; set; }

        /// <summary>
        /// 不限日预算开关：ON/OFF
        /// </summary>
        [XmlElement("plan_unlimited_budget_switch")]
        public string PlanUnlimitedBudgetSwitch { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 应用推广 小游戏/ 小程序 appid
        /// </summary>
        [XmlElement("promote_target_app_id")]
        public string PromoteTargetAppId { get; set; }

        /// <summary>
        /// 应用推广 小游戏/ 小程序
        /// </summary>
        [XmlElement("promote_target_app_name")]
        public string PromoteTargetAppName { get; set; }

        /// <summary>
        /// 推广类型         "tinygame",         "tinyapp",
        /// </summary>
        [XmlElement("promote_target_app_type")]
        public string PromoteTargetAppType { get; set; }

        /// <summary>
        /// 冻结单id
        /// </summary>
        [XmlElement("rtb_freeze_order_id")]
        public string RtbFreezeOrderId { get; set; }

        /// <summary>
        /// 场景编码
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 计划交易模式
        /// </summary>
        [XmlElement("sell_mode")]
        public string SellMode { get; set; }

        /// <summary>
        /// 计划关联商品名称
        /// </summary>
        [XmlElement("service_entity_name")]
        public string ServiceEntityName { get; set; }

        /// <summary>
        /// 计划关联商品id
        /// </summary>
        [XmlElement("service_entity_outid")]
        public string ServiceEntityOutid { get; set; }

        /// <summary>
        /// 冻结单名称
        /// </summary>
        [XmlElement("special_name")]
        public string SpecialName { get; set; }

        /// <summary>
        /// 计划投放开始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 投放时段 全时段投放-不返回该字段 分时段投放：格式为24*7位字符串，且都为 0 和 1，以单小时为最小粒度。按日,一,二,......,六排列。单日内按23,22,21,......3,2,1,0排列。0为不投放，1 为投放，全传 1 视为全时段投放，不允许全部传 0。日维度采用“,”分隔
        /// </summary>
        [XmlElement("time_schema")]
        public string TimeSchema { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("tiny_app_id")]
        public string TinyAppId { get; set; }

        /// <summary>
        /// 小程序推广名称
        /// </summary>
        [XmlElement("tiny_app_name")]
        public string TinyAppName { get; set; }
    }
}
