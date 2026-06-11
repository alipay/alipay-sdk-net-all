using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EbikeChargeStation Data Structure.
    /// </summary>
    [Serializable]
    public class EbikeChargeStation : AopObject
    {
        /// <summary>
        /// 充电桩设备详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 可用空闲插口数
        /// </summary>
        [XmlElement("available_plug_count")]
        public long AvailablePlugCount { get; set; }

        /// <summary>
        /// 桩企品牌code
        /// </summary>
        [XmlElement("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 桩企品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 设备经纬度
        /// </summary>
        [XmlElement("device_lbs")]
        public LocationParam DeviceLbs { get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [XmlElement("device_name")]
        public string DeviceName { get; set; }

        /// <summary>
        /// 设备编号，设备唯一标识
        /// </summary>
        [XmlElement("device_no")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 设备状态
        /// </summary>
        [XmlElement("device_status")]
        public string DeviceStatus { get; set; }

        /// <summary>
        /// 充电桩类型
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 收费标准文案描述
        /// </summary>
        [XmlElement("fee_desc")]
        public string FeeDesc { get; set; }

        /// <summary>
        /// 单路最大输出功率 单位: 瓦
        /// </summary>
        [XmlElement("maximum_power")]
        public string MaximumPower { get; set; }

        /// <summary>
        /// 充电桩名称
        /// </summary>
        [XmlElement("station_name")]
        public string StationName { get; set; }

        /// <summary>
        /// 充电桩编号
        /// </summary>
        [XmlElement("station_no")]
        public string StationNo { get; set; }

        /// <summary>
        /// 插口总数
        /// </summary>
        [XmlElement("total_plug_count")]
        public long TotalPlugCount { get; set; }
    }
}
