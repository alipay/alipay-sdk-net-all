using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderExpoActivityModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderExpoActivityModifyModel : AopObject
    {
        /// <summary>
        /// 活动code,创建活动会返回
        /// </summary>
        [XmlElement("activity_code")]
        public string ActivityCode { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [XmlElement("activity_name")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 活动地址
        /// </summary>
        [XmlElement("address_detail")]
        public string AddressDetail { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 结束shi jian
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 外部图片路径
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
