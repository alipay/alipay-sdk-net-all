using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitEnrollRule Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitEnrollRule : AopObject
    {
        /// <summary>
        /// 最大数量
        /// </summary>
        [XmlElement("max_size")]
        public long MaxSize { get; set; }

        /// <summary>
        /// 最小数量
        /// </summary>
        [XmlElement("min_size")]
        public long MinSize { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [XmlElement("required")]
        public bool Required { get; set; }

        /// <summary>
        /// 规则数据
        /// </summary>
        [XmlElement("rule_data")]
        public RecruitEnrollRuleData RuleData { get; set; }

        /// <summary>
        /// 招商报名时提交的内容类型: 券:VOUCHER; 小程序:MINI_APP; 报名商户:ENROLL_MERCHANT; 素材:MATERIAL; 活动城市:CITY;
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
