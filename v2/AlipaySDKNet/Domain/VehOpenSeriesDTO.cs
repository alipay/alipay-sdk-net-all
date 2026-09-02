using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehOpenSeriesDTO Data Structure.
    /// </summary>
    [Serializable]
    public class VehOpenSeriesDTO : AopObject
    {
        /// <summary>
        /// 4门5座三厢车
        /// </summary>
        [XmlElement("body_type")]
        public string BodyType { get; set; }

        /// <summary>
        /// 品牌ID
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// ["-", "CNG", "增程式", "插电式混合动力", "柴油", "柴油+48V轻混系统", "氢燃料", "汽油", "汽油+24V轻混系统", "汽油+48V轻混系统", "汽油+90V轻混系统", "汽油+CNG", "汽油电驱", "油电混合", "甲醇混动", "纯电动"]
        /// </summary>
        [XmlElement("fuel_type")]
        public string FuelType { get; set; }

        /// <summary>
        /// guide price max, unit: yuan
        /// </summary>
        [XmlElement("guide_price_max")]
        public long GuidePriceMax { get; set; }

        /// <summary>
        /// guide price min, unit: yuan
        /// </summary>
        [XmlElement("guide_price_min")]
        public long GuidePriceMin { get; set; }

        /// <summary>
        /// launch date, format yyyyMMdd
        /// </summary>
        [XmlElement("launch_date")]
        public string LaunchDate { get; set; }

        /// <summary>
        /// manufacturer name
        /// </summary>
        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// 厂商类型
        /// </summary>
        [XmlElement("manufacturer_type")]
        public string ManufacturerType { get; set; }

        /// <summary>
        /// sale status: ONLINE/OFFLINE/PHASE_OUT/PRESALE/PRODUCING/UNLISTED
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// seat number
        /// </summary>
        [XmlElement("seat_num")]
        public string SeatNum { get; set; }

        /// <summary>
        /// 车系id
        /// </summary>
        [XmlElement("series_id")]
        public string SeriesId { get; set; }

        /// <summary>
        /// series image url
        /// </summary>
        [XmlElement("series_img")]
        public string SeriesImg { get; set; }

        /// <summary>
        /// series name
        /// </summary>
        [XmlElement("series_name")]
        public string SeriesName { get; set; }

        /// <summary>
        /// 微型车 中大型SUV 紧凑型车 紧凑型SUV 小型车 中型车 跑车 大型车 中型MPV 中型SUV 紧凑型MPV 中大型MPV 小型SUV 中大型车 大型MPV 大型SUV 微面 皮卡 微卡 轻客 轻卡 飞行汽车 紧凑型MPV,MPV MPV 低端皮卡 高端皮卡
        /// </summary>
        [XmlElement("vehicle_size")]
        public string VehicleSize { get; set; }

        /// <summary>
        /// ["-", "MPV", "SUV", "SUV跨界车", "三厢跨界车", "三厢车", "两厢跨界车", "两厢车", "客车", "掀背车", "旅行跨界车", "旅行车", "皮卡", "硬顶敞篷车", "硬顶跑车", "货车", "软顶敞篷车"]
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }
    }
}
