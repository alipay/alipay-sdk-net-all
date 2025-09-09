using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalShopMarketingActivity Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalShopMarketingActivity : AopObject
    {
        /// <summary>
        /// 营销活动阶梯规则
        /// </summary>
        [XmlArray("activity_rule")]
        [XmlArrayItem("medical_shop_marketing_activity_rule")]
        public List<MedicalShopMarketingActivityRule> ActivityRule { get; set; }

        /// <summary>
        /// 营销活动类型：1-配送满减活动
        /// </summary>
        [XmlElement("activity_type")]
        public long ActivityType { get; set; }

        /// <summary>
        /// 活动结束时间，1.精确到分钟，格式为HH:MM 2.不允许跨天，开始时间须小于结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
