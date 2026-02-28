using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinRegistrationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinRegistrationInfo : AopObject
    {
        /// <summary>
        /// 获得方式
        /// </summary>
        [XmlElement("acquisition_method")]
        public string AcquisitionMethod { get; set; }

        /// <summary>
        /// 条形编码
        /// </summary>
        [XmlElement("barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// 发动机编号
        /// </summary>
        [XmlElement("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 燃料种类
        /// </summary>
        [XmlElement("fuel_type")]
        public string FuelType { get; set; }

        /// <summary>
        /// 发证日期 (yyyy-MM-dd)
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 最近换证日期
        /// </summary>
        [XmlElement("last_renewal_date")]
        public string LastRenewalDate { get; set; }

        /// <summary>
        /// 最近一次补领日期
        /// </summary>
        [XmlElement("last_replacement_date")]
        public string LastReplacementDate { get; set; }

        /// <summary>
        /// 最近转移登记日期 (yyyy-MM-dd)
        /// </summary>
        [XmlElement("last_transfer_date")]
        public string LastTransferDate { get; set; }

        /// <summary>
        /// 车辆出厂日期 (yyyy-MM-dd)
        /// </summary>
        [XmlElement("manufacture_date")]
        public string ManufactureDate { get; set; }

        /// <summary>
        /// 解除抵押时间
        /// </summary>
        [XmlElement("mortgage_release_date")]
        public string MortgageReleaseDate { get; set; }

        /// <summary>
        /// 车辆抵押状态
        /// </summary>
        [XmlElement("mortgage_status")]
        public string MortgageStatus { get; set; }

        /// <summary>
        /// 机动车所有人
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 机动车身份证号码或者统一社会信用代码
        /// </summary>
        [XmlElement("owner_identification_number")]
        public string OwnerIdentificationNumber { get; set; }

        /// <summary>
        /// 登记机关
        /// </summary>
        [XmlElement("registration_authority")]
        public string RegistrationAuthority { get; set; }

        /// <summary>
        /// yyyy-MM-dd
        /// </summary>
        [XmlElement("registration_date")]
        public string RegistrationDate { get; set; }

        /// <summary>
        /// 过户次数
        /// </summary>
        [XmlElement("transfer_count")]
        public string TransferCount { get; set; }

        /// <summary>
        /// 使用性质
        /// </summary>
        [XmlElement("use_type")]
        public string UseType { get; set; }

        /// <summary>
        /// 车辆品牌
        /// </summary>
        [XmlElement("vehicle_brand")]
        public string VehicleBrand { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("vehicle_license")]
        public string VehicleLicense { get; set; }

        /// <summary>
        /// 2019款 奥迪Q3 35 TFSI 进取致雅型
        /// </summary>
        [XmlElement("vehicle_model")]
        public string VehicleModel { get; set; }

        /// <summary>
        /// 车辆车系
        /// </summary>
        [XmlElement("vehicle_series")]
        public string VehicleSeries { get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }

        /// <summary>
        /// 车辆识别号
        /// </summary>
        [XmlElement("vehicle_vin")]
        public string VehicleVin { get; set; }
    }
}
