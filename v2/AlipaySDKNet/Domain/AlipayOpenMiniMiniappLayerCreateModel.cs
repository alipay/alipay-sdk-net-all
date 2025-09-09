using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniMiniappLayerCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniMiniappLayerCreateModel : AopObject
    {
        /// <summary>
        /// 快窗有礼活动名称，仅用于商家识别，不对用户可见
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 不传表示无入群权益；
        /// </summary>
        [XmlArray("benefit_activity_list")]
        [XmlArrayItem("benefit_activity")]
        public List<BenefitActivity> BenefitActivityList { get; set; }

        /// <summary>
        /// 该参数为快窗在C端有哪些渠道能出的配置参数
        /// </summary>
        [XmlArray("channel_code_list")]
        [XmlArrayItem("string")]
        public List<string> ChannelCodeList { get; set; }

        /// <summary>
        /// 默认不填写表示不对城市进行限制；填写了只有对应地区才能弹出此有礼活动；若填写不符合规范的城市编码、B站详情页展示不会显示该不符合规范的城市编码
        /// </summary>
        [XmlArray("city_code_list")]
        [XmlArrayItem("string")]
        public List<string> CityCodeList { get; set; }

        /// <summary>
        /// 展示设置相关参数
        /// </summary>
        [XmlElement("display_setting")]
        public DisplaySetting DisplaySetting { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用户每日进入小程序，快窗展示3次后不再展示；若不传该值表示无疲劳度限制
        /// </summary>
        [XmlElement("fatigue_count")]
        public long FatigueCount { get; set; }

        /// <summary>
        /// 每日投放的开始时间
        /// </summary>
        [XmlElement("layer_show_time_begin")]
        public string LayerShowTimeBegin { get; set; }

        /// <summary>
        /// 每日投放结束时间
        /// </summary>
        [XmlElement("layer_show_time_end")]
        public string LayerShowTimeEnd { get; set; }

        /// <summary>
        /// 默认不填表示此活动不限制人群；填写了表示只针对人群包中的人群生效
        /// </summary>
        [XmlArray("mrch_crowd_list")]
        [XmlArrayItem("string")]
        public List<string> MrchCrowdList { get; set; }

        /// <summary>
        /// 不传表示无券权益；券权益最多支持10个
        /// </summary>
        [XmlArray("promo_activity_list")]
        [XmlArrayItem("promo_act_activity")]
        public List<PromoActActivity> PromoActivityList { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 三个枚举中选一个传入
        /// </summary>
        [XmlElement("target")]
        public string Target { get; set; }
    }
}
