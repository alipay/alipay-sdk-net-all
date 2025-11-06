using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NcoilopenAddressInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NcoilopenAddressInfo : AopObject
    {
        /// <summary>
        /// 城市编码，通用2025款行政区划编码，依据GB/T 2260标准
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 详细地址,如果地址里面包含省市区，省市区字段可不传，否则为必传
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 区编码，通用2025款行政区划编码获取
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 区名称
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 省编码，通用2025款行政区划编码获取
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收货人手机号
        /// </summary>
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }
    }
}
