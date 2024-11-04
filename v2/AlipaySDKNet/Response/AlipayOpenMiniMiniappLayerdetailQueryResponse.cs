using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniMiniappLayerdetailQueryResponse.
    /// </summary>
    public class AlipayOpenMiniMiniappLayerdetailQueryResponse : AopResponse
    {
        /// <summary>
        /// 表示活动id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 除券以外的权益集合
        /// </summary>
        [XmlArray("benefit_activity_list")]
        [XmlArrayItem("benefit_activity")]
        public List<BenefitActivity> BenefitActivityList { get; set; }

        /// <summary>
        /// 返回创建时传入的渠道的code以及code对应的name
        /// </summary>
        [XmlArray("channel_code_list")]
        [XmlArrayItem("channel_code_info")]
        public List<ChannelCodeInfo> ChannelCodeList { get; set; }

        /// <summary>
        /// 城市code集合
        /// </summary>
        [XmlArray("city_code_list")]
        [XmlArrayItem("string")]
        public List<string> CityCodeList { get; set; }

        /// <summary>
        /// 展示活动标题，标题区主色，活动规则
        /// </summary>
        [XmlElement("display_setting")]
        public DisplaySetting DisplaySetting { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 弹层疲劳度限制次数，出现x次后此弹层不会再出现
        /// </summary>
        [XmlElement("fatigue_count")]
        public long FatigueCount { get; set; }

        /// <summary>
        /// 每日投放活动的开始时间
        /// </summary>
        [XmlElement("layer_show_time_begin")]
        public string LayerShowTimeBegin { get; set; }

        /// <summary>
        /// 每日投放结束时间，每日投放结束时间必须晚于每日投放开始时间
        /// </summary>
        [XmlElement("layer_show_time_end")]
        public string LayerShowTimeEnd { get; set; }

        /// <summary>
        /// 人群code的集合
        /// </summary>
        [XmlArray("mrch_crowd_list")]
        [XmlArrayItem("string")]
        public List<string> MrchCrowdList { get; set; }

        /// <summary>
        /// 券权益集合
        /// </summary>
        [XmlArray("promo_activity_list")]
        [XmlArrayItem("promo_act_activity")]
        public List<PromoActActivity> PromoActivityList { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 承接方式
        /// </summary>
        [XmlElement("target")]
        public string Target { get; set; }
    }
}
