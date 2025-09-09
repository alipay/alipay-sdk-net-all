using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcActivityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EcActivityInfo : AopObject
    {
        /// <summary>
        /// 活动唯一id
        /// </summary>
        [XmlElement("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 营销活动的开始时间，时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 营销活动的描述
        /// </summary>
        [XmlElement("promotion_describe")]
        public string PromotionDescribe { get; set; }

        /// <summary>
        /// 营销活动的具体折扣力度。 单位：折 如：8.8折
        /// </summary>
        [XmlElement("promotion_discount")]
        public string PromotionDiscount { get; set; }

        /// <summary>
        /// 折扣时间为json格式的字符串，获取字符串之后，解析成json，key的含义为星期几，value的含义为具体的时间段
        /// </summary>
        [XmlElement("promotion_duration")]
        public string PromotionDuration { get; set; }

        /// <summary>
        /// 活动营销类型
        /// </summary>
        [XmlElement("promotion_type")]
        public string PromotionType { get; set; }

        /// <summary>
        /// 营销活动的开始时间；时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
