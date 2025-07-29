using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignGroupQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignGroupQueryResponse : AopResponse
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlArray("age_list")]
        [XmlArrayItem("string")]
        public List<string> AgeList { get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [XmlElement("asset")]
        public string Asset { get; set; }

        /// <summary>
        /// 行为人群
        /// </summary>
        [XmlArray("behavior_list")]
        [XmlArrayItem("string")]
        public List<string> BehaviorList { get; set; }

        /// <summary>
        /// 单元出价方式
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
        /// 地理位置-城市等级
        /// </summary>
        [XmlArray("city_level_list")]
        [XmlArrayItem("string")]
        public List<string> CityLevelList { get; set; }

        /// <summary>
        /// 转化ID对应事件类型
        /// </summary>
        [XmlElement("converted_event")]
        public string ConvertedEvent { get; set; }

        /// <summary>
        /// 转化事件分层
        /// </summary>
        [XmlElement("converted_event_grp")]
        public string ConvertedEventGrp { get; set; }

        /// <summary>
        /// 转化id
        /// </summary>
        [XmlElement("converted_id")]
        public string ConvertedId { get; set; }

        /// <summary>
        /// 地理位置类型
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 排除人群
        /// </summary>
        [XmlArray("exclude_customized_crowd_list")]
        [XmlArrayItem("string")]
        public List<string> ExcludeCustomizedCrowdList { get; set; }

        /// <summary>
        /// 排除已转化人群-转化事件列表
        /// </summary>
        [XmlArray("filter_converted_event_list")]
        [XmlArrayItem("string")]
        public List<string> FilterConvertedEventList { get; set; }

        /// <summary>
        /// 排除已转化人群维度
        /// </summary>
        [XmlElement("filter_converted_scope")]
        public string FilterConvertedScope { get; set; }

        /// <summary>
        /// 排除已转化人群时间范围
        /// </summary>
        [XmlElement("filter_converted_time_range")]
        public string FilterConvertedTimeRange { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlArray("gender_list")]
        [XmlArrayItem("string")]
        public List<string> GenderList { get; set; }

        /// <summary>
        /// 单元修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 单元日预算。单位：元【人民币】如果是不限单元日预算，此值为空
        /// </summary>
        [XmlElement("group_budget")]
        public string GroupBudget { get; set; }

        /// <summary>
        /// 单次出价。单位：元【人民币】。bidType= OCPX时会默认填充对应营销目标配置的最小值
        /// </summary>
        [XmlElement("group_charge")]
        public string GroupCharge { get; set; }

        /// <summary>
        /// 单元id
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 单元继承id
        /// </summary>
        [XmlElement("group_inherit")]
        public long GroupInherit { get; set; }

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
        /// 自定义人群
        /// </summary>
        [XmlArray("include_customized_crowd_list")]
        [XmlArrayItem("string")]
        public List<string> IncludeCustomizedCrowdList { get; set; }

        /// <summary>
        /// 智能定向0-关闭，1-开启
        /// </summary>
        [XmlElement("intelligent_target_switch")]
        public long IntelligentTargetSwitch { get; set; }

        /// <summary>
        /// 兴趣人群
        /// </summary>
        [XmlArray("interest_list")]
        [XmlArrayItem("string")]
        public List<string> InterestList { get; set; }

        /// <summary>
        /// 地理点位
        /// </summary>
        [XmlArray("lbs_list")]
        [XmlArrayItem("open_lbs_entry")]
        public List<OpenLbsEntry> LbsList { get; set; }

        /// <summary>
        /// 二级营销目标
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
        /// 操作系统
        /// </summary>
        [XmlArray("os_list")]
        [XmlArrayItem("string")]
        public List<string> OsList { get; set; }

        /// <summary>
        /// 单元所属计划id
        /// </summary>
        [XmlElement("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 单元所属计划名称
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("principal_id")]
        public long PrincipalId { get; set; }

        /// <summary>
        /// 是否开启推荐流量开关.0关闭，1开启
        /// </summary>
        [XmlElement("referral_traffic_switch")]
        public long ReferralTrafficSwitch { get; set; }

        /// <summary>
        /// 地理位置-行政区域，行政区域编码和省市区县对应关系见<a href="https://www.mca.gov.cn/mzsj/xzqh/2022/202201xzqh.html">文档</a>
        /// </summary>
        [XmlArray("region_list")]
        [XmlArrayItem("string")]
        public List<string> RegionList { get; set; }

        /// <summary>
        /// 地理位置-行政区域-位置类型，包括最近出现用户，正在此地的常驻用户，常驻此地用户，旅游到此地用户，当前地区全部用户
        /// </summary>
        [XmlElement("region_type")]
        public string RegionType { get; set; }

        /// <summary>
        /// 场景code
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 搜索词列表
        /// </summary>
        [XmlArray("search_word_list")]
        [XmlArrayItem("search_word")]
        public List<SearchWord> SearchWordList { get; set; }

        /// <summary>
        /// 转化目标成本。单位：元【人民币】
        /// </summary>
        [XmlElement("target_cpa")]
        public string TargetCpa { get; set; }

        /// <summary>
        /// 目标ROI,单位：元【人民币】
        /// </summary>
        [XmlElement("target_roi")]
        public string TargetRoi { get; set; }

        /// <summary>
        /// 行业主题人群
        /// </summary>
        [XmlArray("theme_crowd_list")]
        [XmlArrayItem("string")]
        public List<string> ThemeCrowdList { get; set; }
    }
}
