using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehOpenModelDTO Data Structure.
    /// </summary>
    [Serializable]
    public class VehOpenModelDTO : AopObject
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
        /// ["-", "H", "L", "R", "V", "W"]
        /// </summary>
        [XmlElement("cylinder_arrangement")]
        public string CylinderArrangement { get; set; }

        /// <summary>
        /// 气缸数
        /// </summary>
        [XmlElement("cylinders")]
        public string Cylinders { get; set; }

        /// <summary>
        /// displacement, unit: T or L, e.g. 1.5T/2.0T/3.0L
        /// </summary>
        [XmlElement("displacement")]
        public string Displacement { get; set; }

        /// <summary>
        /// 车门数
        /// </summary>
        [XmlElement("doors")]
        public string Doors { get; set; }

        /// <summary>
        /// 驱动方式
        /// </summary>
        [XmlElement("drive_mode")]
        public string DriveMode { get; set; }

        /// <summary>
        /// 排放标准
        /// </summary>
        [XmlElement("emission_standard")]
        public string EmissionStandard { get; set; }

        /// <summary>
        /// 供油方式
        /// </summary>
        [XmlElement("fuel_injection")]
        public string FuelInjection { get; set; }

        /// <summary>
        /// 燃料类型
        /// </summary>
        [XmlElement("fuel_type")]
        public string FuelType { get; set; }

        /// <summary>
        /// 官方指导价，单位：元
        /// </summary>
        [XmlElement("guide_price")]
        public string GuidePrice { get; set; }

        /// <summary>
        /// 马力（Ps）
        /// </summary>
        [XmlElement("horsepower")]
        public string Horsepower { get; set; }

        /// <summary>
        /// 进气形式
        /// </summary>
        [XmlElement("intake")]
        public string Intake { get; set; }

        /// <summary>
        /// 上市时间，格式 yyyy-MM-dd
        /// </summary>
        [XmlElement("launch_date")]
        public string LaunchDate { get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }

        /// <summary>
        /// 车型id
        /// </summary>
        [XmlElement("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 车型图片地址
        /// </summary>
        [XmlElement("model_img")]
        public string ModelImg { get; set; }

        /// <summary>
        /// 车型名称
        /// </summary>
        [XmlElement("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 功率（kW）
        /// </summary>
        [XmlElement("power_kw")]
        public string PowerKw { get; set; }

        /// <summary>
        /// 功率对应转速（rpm）
        /// </summary>
        [XmlElement("power_rpm")]
        public string PowerRpm { get; set; }

        /// <summary>
        /// 销售状态
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// 年款
        /// </summary>
        [XmlElement("sale_years")]
        public string SaleYears { get; set; }

        /// <summary>
        /// 座位数
        /// </summary>
        [XmlElement("seat_num")]
        public string SeatNum { get; set; }

        /// <summary>
        /// 车系ID
        /// </summary>
        [XmlElement("series_id")]
        public string SeriesId { get; set; }

        /// <summary>
        /// 车系名称
        /// </summary>
        [XmlElement("series_name")]
        public string SeriesName { get; set; }

        /// <summary>
        /// 扭矩（N·m）
        /// </summary>
        [XmlElement("torque_nm")]
        public string TorqueNm { get; set; }

        /// <summary>
        /// 扭矩对应转速（rpm）
        /// </summary>
        [XmlElement("torque_rpm")]
        public string TorqueRpm { get; set; }

        /// <summary>
        /// 变速箱
        /// </summary>
        [XmlElement("transmission")]
        public string Transmission { get; set; }

        /// <summary>
        /// 变速箱类型
        /// </summary>
        [XmlElement("transmission_type")]
        public string TransmissionType { get; set; }

        /// <summary>
        /// 微型车 中大型SUV 紧凑型车 紧凑型SUV 小型车 中型车 跑车 大型车 中型MPV 中型SUV 紧凑型MPV 中大型MPV 小型SUV 中大型车 大型MPV 大型SUV 微面 皮卡 微卡 轻客 轻卡 飞行汽车 紧凑型MPV,MPV MPV 低端皮卡 高端皮卡
        /// </summary>
        [XmlElement("vehicle_size")]
        public string VehicleSize { get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }
    }
}
