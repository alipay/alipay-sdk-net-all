using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderExpoActivityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderExpoActivityCreateModel : AopObject
    {
        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动详细地址
        /// </summary>
        [XmlElement("address_detail")]
        public string AddressDetail { get; set; }

        /// <summary>
        /// 活动归属市
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 活动结束时间，格式如下 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 外部图片路径
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 活动归属省份
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 活动开始时间，格式如下 yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
