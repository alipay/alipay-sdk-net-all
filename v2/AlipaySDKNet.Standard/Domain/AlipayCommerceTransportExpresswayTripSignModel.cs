using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportExpresswayTripSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportExpresswayTripSignModel : AopObject
    {
        /// <summary>
        /// 车辆类型
        /// </summary>
        [XmlElement("car_type")]
        public string CarType { get; set; }

        /// <summary>
        /// 办理人所在地城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 调用方行业标识ID
        /// </summary>
        [XmlElement("isv_id")]
        public string IsvId { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部协议单号，调用方标识ID维度下需保证唯一
        /// </summary>
        [XmlElement("out_agreement_no")]
        public string OutAgreementNo { get; set; }

        /// <summary>
        /// 办理车牌颜色
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 办理车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 车高，单位mm
        /// </summary>
        [XmlElement("vi_height")]
        public long ViHeight { get; set; }

        /// <summary>
        /// 车长，单位mm
        /// </summary>
        [XmlElement("vi_length")]
        public long ViLength { get; set; }

        /// <summary>
        /// 行驶证信息核定载人数
        /// </summary>
        [XmlElement("vi_license_apc")]
        public long ViLicenseApc { get; set; }

        /// <summary>
        /// 行驶证上的品牌型号
        /// </summary>
        [XmlElement("vi_license_brand_model")]
        public string ViLicenseBrandModel { get; set; }

        /// <summary>
        /// 行驶证信息车辆类型
        /// </summary>
        [XmlElement("vi_license_car_type")]
        public string ViLicenseCarType { get; set; }

        /// <summary>
        /// 行驶证信息-发动机号
        /// </summary>
        [XmlElement("vi_license_engine")]
        public string ViLicenseEngine { get; set; }

        /// <summary>
        /// 行驶证正面支付宝文件id，通过alipay.open.file.upload(支付宝文件上传接口)接口上传文件后返回的file_id
        /// </summary>
        [XmlElement("vi_license_front_file_id")]
        public string ViLicenseFrontFileId { get; set; }

        /// <summary>
        /// 行驶证信息发证时间
        /// </summary>
        [XmlElement("vi_license_issue_date")]
        public string ViLicenseIssueDate { get; set; }

        /// <summary>
        /// 行驶证信息车辆所有人
        /// </summary>
        [XmlElement("vi_license_owner")]
        public string ViLicenseOwner { get; set; }

        /// <summary>
        /// 行驶证上车辆注册日期
        /// </summary>
        [XmlElement("vi_license_register_date")]
        public string ViLicenseRegisterDate { get; set; }

        /// <summary>
        /// 行驶证信息整备质量
        /// </summary>
        [XmlElement("vi_license_unladen_mass")]
        public string ViLicenseUnladenMass { get; set; }

        /// <summary>
        /// 行驶证信息使用性质
        /// </summary>
        [XmlElement("vi_license_use_type")]
        public string ViLicenseUseType { get; set; }

        /// <summary>
        /// 行驶证副页支付宝文件id，，通过alipay.open.file.upload(支付宝文件上传接口)接口上传文件后返回的file_id
        /// </summary>
        [XmlElement("vi_license_vice_file_id")]
        public string ViLicenseViceFileId { get; set; }

        /// <summary>
        /// 车辆识别号VIN码
        /// </summary>
        [XmlElement("vi_license_vin")]
        public string ViLicenseVin { get; set; }

        /// <summary>
        /// 车宽，单位mm
        /// </summary>
        [XmlElement("vi_width")]
        public long ViWidth { get; set; }
    }
}
