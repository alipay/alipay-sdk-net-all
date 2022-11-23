using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryNucleicremindSubscribeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryNucleicremindSubscribeModifyModel : AopObject
    {
        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订阅提醒时间列表,单位小时，必须不小于48
        /// </summary>
        [XmlArray("reminder_hour_list")]
        [XmlArrayItem("number")]
        public List<long> ReminderHourList { get; set; }

        /// <summary>
        /// 订阅状态，1 订阅  0 退订 。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
