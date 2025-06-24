using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCheckinRuleModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCheckinRuleModifyModel : AopObject
    {
        /// <summary>
        /// auth_activity_id
        /// </summary>
        [XmlElement("auth_activity_id")]
        public string AuthActivityId { get; set; }

        /// <summary>
        /// 签到核身认证类型
        /// </summary>
        [XmlElement("authentication_type")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// 规则生效状态
        /// </summary>
        [XmlElement("enable_status")]
        public bool EnableStatus { get; set; }

        /// <summary>
        /// 结束时间，用于标识签到结束类型的时间，单位分钟
        /// </summary>
        [XmlElement("end_minutes")]
        public long EndMinutes { get; set; }

        /// <summary>
        /// 签到结束时间，格式：HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 签到结束类型
        /// </summary>
        [XmlElement("end_type")]
        public string EndType { get; set; }

        /// <summary>
        /// 签到频率类型
        /// </summary>
        [XmlElement("frequency_type")]
        public string FrequencyType { get; set; }

        /// <summary>
        /// 机构内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 碰一下签到校验开关
        /// </summary>
        [XmlElement("nfc_check")]
        public bool NfcCheck { get; set; }

        /// <summary>
        /// 是否启用拍照校验
        /// </summary>
        [XmlElement("picture_check")]
        public bool PictureCheck { get; set; }

        /// <summary>
        /// 是否启用位置校验
        /// </summary>
        [XmlElement("place_check")]
        public bool PlaceCheck { get; set; }

        /// <summary>
        /// 关联的位置列表
        /// </summary>
        [XmlArray("place_id_list")]
        [XmlArrayItem("string")]
        public List<string> PlaceIdList { get; set; }

        /// <summary>
        /// 签到半径，单位：米。用户签到时所在位置和签到地点经纬度的直线距离。
        /// </summary>
        [XmlElement("radius")]
        public long Radius { get; set; }

        /// <summary>
        /// 签到规则ID
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 签到规则名称
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 签到规则类型，不传默认为寝室签到
        /// </summary>
        [XmlElement("rule_type")]
        public string RuleType { get; set; }

        /// <summary>
        /// 开始时间，用于标识签到开始类型的时间，单位分钟
        /// </summary>
        [XmlElement("start_minutes")]
        public long StartMinutes { get; set; }

        /// <summary>
        /// 签到开始时间，格式：HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 签到开始类型
        /// </summary>
        [XmlElement("start_type")]
        public string StartType { get; set; }

        /// <summary>
        /// 周天列表，数字1-7分别表示周一到周日。
        /// </summary>
        [XmlArray("week_day_list")]
        [XmlArrayItem("number")]
        public List<long> WeekDayList { get; set; }
    }
}
