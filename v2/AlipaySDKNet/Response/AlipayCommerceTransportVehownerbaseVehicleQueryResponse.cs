using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehownerbaseVehicleQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportVehownerbaseVehicleQueryResponse : AopResponse
    {
        /// <summary>
        /// 认证日期（yyyy-mm-dd）
        /// </summary>
        [XmlElement("auth_date")]
        public string AuthDate { get; set; }

        /// <summary>
        /// 品牌 ID
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 发动机号
        /// </summary>
        [XmlElement("engine_no")]
        public string EngineNo { get; set; }

        /// <summary>
        /// 发证日期（yyyy-mm-dd）
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 行驶证反面照片 URL
        /// </summary>
        [XmlElement("license_back_url")]
        public string LicenseBackUrl { get; set; }

        /// <summary>
        /// 行驶证正面照片 URL
        /// </summary>
        [XmlElement("license_url")]
        public string LicenseUrl { get; set; }

        /// <summary>
        /// 车型 ID
        /// </summary>
        [XmlElement("model_id")]
        public string ModelId { get; set; }

        /// <summary>
        /// 车型名称
        /// </summary>
        [XmlElement("model_name")]
        public string ModelName { get; set; }

        /// <summary>
        /// 车辆所有人姓名
        /// </summary>
        [XmlElement("owner")]
        public string Owner { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 注册日期（yyyy-mm-dd）
        /// </summary>
        [XmlElement("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// 高级认证
        /// </summary>
        [XmlElement("senior_certificated")]
        public string SeniorCertificated { get; set; }

        /// <summary>
        /// 车系 ID
        /// </summary>
        [XmlElement("series_id")]
        public string SeriesId { get; set; }

        /// <summary>
        /// 车系名称
        /// </summary>
        [XmlElement("series_name")]
        public string SeriesName { get; set; }

        /// <summary>
        /// 认证方式
        /// </summary>
        [XmlElement("trusted_from")]
        public string TrustedFrom { get; set; }

        /// <summary>
        /// 使用性质
        /// </summary>
        [XmlElement("use_type")]
        public string UseType { get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        [XmlElement("vehicle_type")]
        public string VehicleType { get; set; }

        /// <summary>
        /// 车辆 ID
        /// </summary>
        [XmlElement("vi_id")]
        public string ViId { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("vi_number")]
        public string ViNumber { get; set; }

        /// <summary>
        /// 车架号（VIN 码）
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }

        /// <summary>
        /// 认证级别
        /// </summary>
        [XmlElement("vur_grade")]
        public string VurGrade { get; set; }
    }
}
