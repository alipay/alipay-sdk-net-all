using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportCarbonjusticeLowcarbonbehaviorQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportCarbonjusticeLowcarbonbehaviorQueryModel : AopObject
    {
        /// <summary>
        /// 城市编码，与城市名二选一必须有一个。比cityName更标准，在接入前确认传参。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 提前和出行方确认对应城市的城市名，部分城市的出行行为包含“市” 部分没有城市名只能使用cityCode。如果需要区县级别，则重新评估
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 查询行程的最晚时间。用于圈定行程的范围。如果不传则默认为当前时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 属于哪种低碳类型，必须属于枚举中的一个 CARBON_JUSTICE_BUS|CARBON_JUSTICE_METRO|CARBON_JUSTICE_HITCHHIKING
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 讲明自己是哪个调用方，要求能够让商务定位到来源即可
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 表示行程开始时间的最早时间，用于圈定时间范围。 如果不传，会默认取前一天
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
