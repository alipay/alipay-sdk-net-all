using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// VehModelDto Data Structure.
    /// </summary>
    [Serializable]
    public class VehModelDto : AopObject
    {
        /// <summary>
        /// 车型ID
        /// </summary>
        [XmlElement("acid")]
        public string Acid { get; set; }

        /// <summary>
        /// 车身形式
        /// </summary>
        [XmlElement("body_type")]
        public string BodyType { get; set; }

        /// <summary>
        /// 品牌ID
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 品牌LOGO
        /// </summary>
        [XmlElement("brand_logo_url")]
        public string BrandLogoUrl { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 厢型
        /// </summary>
        [XmlElement("car_type")]
        public string CarType { get; set; }

        /// <summary>
        /// 气缸排列形式
        /// </summary>
        [XmlElement("cylinder_arrangement")]
        public string CylinderArrangement { get; set; }

        /// <summary>
        /// 气缸数
        /// </summary>
        [XmlElement("cylinders_num")]
        public long CylindersNum { get; set; }

        /// <summary>
        /// 排量
        /// </summary>
        [XmlElement("displacement")]
        public string Displacement { get; set; }

        /// <summary>
        /// 车门数
        /// </summary>
        [XmlElement("doors_num")]
        public long DoorsNum { get; set; }

        /// <summary>
        /// 驱动形式
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
        /// 燃油类型
        /// </summary>
        [XmlElement("fuel_type")]
        public string FuelType { get; set; }

        /// <summary>
        /// 最大马力
        /// </summary>
        [XmlElement("horsepower")]
        public string Horsepower { get; set; }

        /// <summary>
        /// 进气形式
        /// </summary>
        [XmlElement("intake")]
        public string Intake { get; set; }

        /// <summary>
        /// 厂商ID
        /// </summary>
        [XmlElement("manufacturer_id")]
        public string ManufacturerId { get; set; }

        /// <summary>
        /// 厂商名称
        /// </summary>
        [XmlElement("manufacturer_name")]
        public string ManufacturerName { get; set; }

        /// <summary>
        /// 最大功率
        /// </summary>
        [XmlElement("power_kw")]
        public string PowerKw { get; set; }

        /// <summary>
        /// 最大功率转速（rpm）
        /// </summary>
        [XmlElement("power_rpm")]
        public string PowerRpm { get; set; }

        /// <summary>
        /// 厂商指导价（单位：万元）
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 销售名称
        /// </summary>
        [XmlElement("sale_name")]
        public string SaleName { get; set; }

        /// <summary>
        /// 销售年款
        /// </summary>
        [XmlElement("sale_years")]
        public string SaleYears { get; set; }

        /// <summary>
        /// 座位数
        /// </summary>
        [XmlElement("seat_num")]
        public long SeatNum { get; set; }

        /// <summary>
        /// 车系ID
        /// </summary>
        [XmlElement("series_id")]
        public string SeriesId { get; set; }

        /// <summary>
        /// 车系图片链接
        /// </summary>
        [XmlElement("series_image_url")]
        public string SeriesImageUrl { get; set; }

        /// <summary>
        /// 车系名称
        /// </summary>
        [XmlElement("series_name")]
        public string SeriesName { get; set; }

        /// <summary>
        /// 展示名称
        /// </summary>
        [XmlElement("show_name")]
        public string ShowName { get; set; }

        /// <summary>
        /// 最大扭矩（n·m）
        /// </summary>
        [XmlElement("torque_nm")]
        public string TorqueNm { get; set; }

        /// <summary>
        /// 最大扭矩转速（rpm）
        /// </summary>
        [XmlElement("torque_rpm")]
        public string TorqueRpm { get; set; }

        /// <summary>
        /// 变速器
        /// </summary>
        [XmlElement("transmission")]
        public string Transmission { get; set; }

        /// <summary>
        /// 档位类型
        /// </summary>
        [XmlElement("transmission_type")]
        public string TransmissionType { get; set; }

        /// <summary>
        /// 车辆级别
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
