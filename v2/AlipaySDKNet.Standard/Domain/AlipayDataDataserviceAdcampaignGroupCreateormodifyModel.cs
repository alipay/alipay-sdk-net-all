using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignGroupCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdcampaignGroupCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 年龄定向
        /// </summary>
        [XmlArray("age_list")]
        [XmlArrayItem("string")]
        public List<string> AgeList { get; set; }

        /// <summary>
        /// 资产类型（前置转化资产openAPI接口获取）转化类型获取接口：alipay.data.dataservice.adconversion.conversiontype.query 字段名asset
        /// </summary>
        [XmlElement("asset")]
        public string Asset { get; set; }

        /// <summary>
        /// 行为人群包,根据行为人群定向API接口返回值填写 alipay.data.dataservice.adcrowd.behaviorcategory.batchquery
        /// </summary>
        [XmlArray("behavior_list")]
        [XmlArrayItem("string")]
        public List<string> BehaviorList { get; set; }

        /// <summary>
        /// 0:DEFAULT 1:OCPX 2:NO_BID   仅支持 智投场景 3:ROI（仅支持应用推广-小游戏推广、商品推广-保险商品全域推广，小程序商品推广 转化目标类型为小程序支付ROI ）
        /// </summary>
        [XmlElement("bid_type")]
        public string BidType { get; set; }

        /// <summary>
        /// 起量预算（元）【人民币】 若oneBoostStatus为开启，必填 起量预算最低100元 起量预算不可超过计划日预算100元
        /// </summary>
        [XmlElement("boost_budget")]
        public string BoostBudget { get; set; }

        /// <summary>
        /// 城市等级（行政区域与城市等级互斥）
        /// </summary>
        [XmlArray("city_level_list")]
        [XmlArrayItem("string")]
        public List<string> CityLevelList { get; set; }

        /// <summary>
        /// 转化事件类型，（前置转化资产openAPI接口获取）转化类型获取接口：alipay.data.dataservice.adconversion.conversiontype.query 字段名converted_event
        /// </summary>
        [XmlElement("converted_event")]
        public string ConvertedEvent { get; set; }

        /// <summary>
        /// 转化分层非必填（前置转化资产openAPI接口获取）转化类型获取接口：alipay.data.dataservice.adconversion.conversiontype.query 字段名converted_event_grp
        /// </summary>
        [XmlElement("converted_event_grp")]
        public string ConvertedEventGrp { get; set; }

        /// <summary>
        /// 转化事件Id（前置转化事件查询接口openAPI接口获取）接口：alipay.data.dataservice.adconversion.conversionid.query 字段名converted_id
        /// </summary>
        [XmlElement("converted_id")]
        public string ConvertedId { get; set; }

        /// <summary>
        /// 定向选择的地理位置类型
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 排除人群，自定义人群查询API alipay.data.dataservice.adcrowd.dmpcrowd.batchquery
        /// </summary>
        [XmlArray("exclude_customized_crowd_list")]
        [XmlArrayItem("string")]
        public List<string> ExcludeCustomizedCrowdList { get; set; }

        /// <summary>
        /// 排除转化事件列表，根据灯火广告定向已转化事件查询API返回的转化事件列表填写 alipay.data.dataservice.adtarget.convertedevent.batchquery
        /// </summary>
        [XmlArray("filter_converted_event_list")]
        [XmlArrayItem("string")]
        public List<string> FilterConvertedEventList { get; set; }

        /// <summary>
        /// 排除已转化人群维度 CUSTOMER同pid
        /// </summary>
        [XmlElement("filter_converted_scope")]
        public string FilterConvertedScope { get; set; }

        /// <summary>
        /// 排除已转化人群时间范围 近1天. one_day 近7天. seven_day 近1月. one_month 近3月 .threemonth 近6月. six_month 同单元和同计划只允许6个月
        /// </summary>
        [XmlElement("filter_converted_time_range")]
        public string FilterConvertedTimeRange { get; set; }

        /// <summary>
        /// 性别,允许值： GENDER_FEMALE、 GENDER_MALE
        /// </summary>
        [XmlArray("gender_list")]
        [XmlArrayItem("string")]
        public List<string> GenderList { get; set; }

        /// <summary>
        /// 单元日预算（元）【人民币】 若为不限预算时，此项为空 当bidType=NO_BID时，单元日预算必填
        /// </summary>
        [XmlElement("group_budget")]
        public string GroupBudget { get; set; }

        /// <summary>
        /// 单元出价(元)：当bidType= DEFAULT时，必填
        /// </summary>
        [XmlElement("group_charge")]
        public string GroupCharge { get; set; }

        /// <summary>
        /// 单元id,修改单元时必传,新增单元时不传
        /// </summary>
        [XmlElement("group_id")]
        public long GroupId { get; set; }

        /// <summary>
        /// 同营销目标和同主体下的单元ID
        /// </summary>
        [XmlElement("group_inherit")]
        public long GroupInherit { get; set; }

        /// <summary>
        /// 单元名称
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 自定义人群包，自定义人群查询API alipay.data.dataservice.adcrowd.dmpcrowd.batchquery
        /// </summary>
        [XmlArray("include_customized_crowd_list")]
        [XmlArrayItem("string")]
        public List<string> IncludeCustomizedCrowdList { get; set; }

        /// <summary>
        /// 兴趣人群包，根据兴趣人群定向API接口返回值填写 alipay.data.dataservice.adcrowd.interestcategory.batchquery
        /// </summary>
        [XmlArray("interest_list")]
        [XmlArrayItem("string")]
        public List<string> InterestList { get; set; }

        /// <summary>
        /// 地理点位设置
        /// </summary>
        [XmlArray("lbs_list")]
        [XmlArrayItem("open_lbs_entry")]
        public List<OpenLbsEntry> LbsList { get; set; }

        /// <summary>
        /// 仅出价方式bidType=OCPX时才可开启一键起量 ENABLE: 开启 MANUAL_DISABLE：手动关闭
        /// </summary>
        [XmlElement("one_boost_status")]
        public string OneBoostStatus { get; set; }

        /// <summary>
        /// 手机操作系统
        /// </summary>
        [XmlArray("os_list")]
        [XmlArrayItem("string")]
        public List<string> OsList { get; set; }

        /// <summary>
        /// 计划id
        /// </summary>
        [XmlElement("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 委托人标识
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 是否开启推荐流量开关.1打开，0关闭
        /// </summary>
        [XmlElement("referral_traffic_switch")]
        public long ReferralTrafficSwitch { get; set; }

        /// <summary>
        /// 允许值是行政区域码，仅支持大陆和港澳地区省、市、区县级别，条件必填，行政区域码请参考 <a href="https://www.mca.gov.cn/mzsj/xzqh/2022/202201xzqh.html">文档</a>，请完整填写6位数，目前仅支持到区县粒度
        /// </summary>
        [XmlArray("region_list")]
        [XmlArrayItem("string")]
        public List<string> RegionList { get; set; }

        /// <summary>
        /// 地理位置类型 CURRENT正在该地区的用户， RESIDENCE常驻在该地区的用户， TRAVEL到该地区旅行的用户， ALL该地区内的所有用户， RECENT最近出现的用户 条件必填 当region_list有值和district=REGION时必填
        /// </summary>
        [XmlElement("region_type")]
        public string RegionType { get; set; }

        /// <summary>
        /// 搜索词列表
        /// </summary>
        [XmlArray("search_word_list")]
        [XmlArrayItem("search_word")]
        public List<SearchWord> SearchWordList { get; set; }

        /// <summary>
        /// 目标转化成本：当bidType= OCPX时，必填 单位为元【人民币】
        /// </summary>
        [XmlElement("target_cpa")]
        public string TargetCpa { get; set; }

        /// <summary>
        /// 目标ROI，单位【元】，人民币。 bidType= ROI时候必填
        /// </summary>
        [XmlElement("target_roi")]
        public string TargetRoi { get; set; }

        /// <summary>
        /// 行业主题人群包，根据行业主题人群查询定向API接口返回值填写 alipay.data.dataservice.adcrowd.themecrowd.batchquery
        /// </summary>
        [XmlArray("theme_crowd_list")]
        [XmlArrayItem("string")]
        public List<string> ThemeCrowdList { get; set; }
    }
}
