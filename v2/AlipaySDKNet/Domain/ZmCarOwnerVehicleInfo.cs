using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmCarOwnerVehicleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmCarOwnerVehicleInfo : AopObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("license_plate_number")]
        public string LicensePlateNumber { get; set; }

        /// <summary>
        /// 车辆所有人姓名
        /// </summary>
        [XmlElement("vehicle_belong_owner")]
        public string VehicleBelongOwner { get; set; }

        /// <summary>
        /// 车辆品牌
        /// </summary>
        [XmlElement("vehicle_brand")]
        public string VehicleBrand { get; set; }

        /// <summary>
        /// 发动机号码
        /// </summary>
        [XmlElement("vehicle_engine_no")]
        public string VehicleEngineNo { get; set; }

        /// <summary>
        /// 车辆注册日期
        /// </summary>
        [XmlElement("vehicle_register_date")]
        public string VehicleRegisterDate { get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }

        /// <summary>
        /// 车辆使用性质
        /// </summary>
        [XmlElement("vehicle_usage")]
        public string VehicleUsage { get; set; }

        /// <summary>
        /// 车架号，即vin码
        /// </summary>
        [XmlElement("vehicle_vin")]
        public string VehicleVin { get; set; }

        /// <summary>
        /// 验证等级，目前只有官方验证
        /// </summary>
        [XmlElement("verification_level")]
        public string VerificationLevel { get; set; }
    }
}
