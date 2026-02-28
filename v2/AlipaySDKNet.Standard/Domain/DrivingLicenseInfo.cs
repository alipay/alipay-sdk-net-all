using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DrivingLicenseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DrivingLicenseInfo : AopObject
    {
        /// <summary>
        /// 行驶证上的地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 发动机编号
        /// </summary>
        [XmlElement("engine_number")]
        public string EngineNumber { get; set; }

        /// <summary>
        /// 行驶证图片路径
        /// </summary>
        [XmlElement("file_path")]
        public string FilePath { get; set; }

        /// <summary>
        /// 发证日期
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("license_plate_number")]
        public string LicensePlateNumber { get; set; }

        /// <summary>
        /// 注册日期
        /// </summary>
        [XmlElement("registration_date")]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// 使用性质
        /// </summary>
        [XmlElement("use_character")]
        public string UseCharacter { get; set; }

        /// <summary>
        /// 车300品牌Id
        /// </summary>
        [XmlElement("vehicle_brand_id")]
        public string VehicleBrandId { get; set; }

        /// <summary>
        /// 车300品牌名称
        /// </summary>
        [XmlElement("vehicle_brand_name")]
        public string VehicleBrandName { get; set; }

        /// <summary>
        /// 车300型号Id
        /// </summary>
        [XmlElement("vehicle_model_id")]
        public string VehicleModelId { get; set; }

        /// <summary>
        /// 车300型号名称
        /// </summary>
        [XmlElement("vehicle_model_name")]
        public string VehicleModelName { get; set; }

        /// <summary>
        /// 机动车所有人
        /// </summary>
        [XmlElement("vehicle_owner")]
        public string VehicleOwner { get; set; }

        /// <summary>
        /// 车300车系Id
        /// </summary>
        [XmlElement("vehicle_series_id")]
        public string VehicleSeriesId { get; set; }

        /// <summary>
        /// 车300车系名称
        /// </summary>
        [XmlElement("vehicle_series_name")]
        public string VehicleSeriesName { get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }

        /// <summary>
        /// 车辆识别码
        /// </summary>
        [XmlElement("vin_number")]
        public string VinNumber { get; set; }
    }
}
