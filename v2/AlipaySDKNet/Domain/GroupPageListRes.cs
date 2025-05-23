using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GroupPageListRes Data Structure.
    /// </summary>
    [Serializable]
    public class GroupPageListRes : AopObject
    {
        /// <summary>
        /// 单元出价类型
        /// </summary>
        [XmlElement("bid_type")]
        public string BidType { get; set; }

        /// <summary>
        /// 起量预算。单位：元【人民币】；没有使用一键起量时，此值为空
        /// </summary>
        [XmlElement("boost_budget")]
        public string BoostBudget { get; set; }

        /// <summary>
        /// 起量结束时间
        /// </summary>
        [XmlElement("boost_end_date")]
        public string BoostEndDate { get; set; }

        /// <summary>
        /// 起量id
        /// </summary>
        [XmlElement("boost_id")]
        public long BoostId { get; set; }

        /// <summary>
        /// 起量开始时间
        /// </summary>
        [XmlElement("boost_start_date")]
        public string BoostStartDate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 单元日预算。单位：元【人民币】如果是不限单元日预算，此值为空
        /// </summary>
        [XmlElement("group_budget")]
        public string GroupBudget { get; set; }

        /// <summary>
        /// 单次出价。单位：元【人民币】
        /// </summary>
        [XmlElement("group_charge")]
        public string GroupCharge { get; set; }

        /// <summary>
        /// 单元id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 单元名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 单元状态
        /// </summary>
        [XmlElement("group_status")]
        public string GroupStatus { get; set; }

        /// <summary>
        /// 二级营销目标code
        /// </summary>
        [XmlElement("market_target_code")]
        public string MarketTargetCode { get; set; }

        /// <summary>
        /// 二级营销目标名称
        /// </summary>
        [XmlElement("market_target_name")]
        public string MarketTargetName { get; set; }

        /// <summary>
        /// 起量状态
        /// </summary>
        [XmlElement("one_boost_status")]
        public string OneBoostStatus { get; set; }

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
        /// 商家id
        /// </summary>
        [XmlElement("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 场景code
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 转化目标成本。单位：元【人民币】
        /// </summary>
        [XmlElement("target_cpa")]
        public string TargetCpa { get; set; }
    }
}
