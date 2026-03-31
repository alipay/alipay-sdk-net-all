using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcCertifyorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcCertifyorderCreateModel : AopObject
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
        /// false:不需要用户上传行驶证图片 true:需要用户上传行驶证图片
        /// </summary>
        [XmlElement("license_img_required_flag")]
        public bool LicenseImgRequiredFlag { get; set; }

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
        /// 外部订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

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
        /// 参数需要咨询业务同学,车系品牌id
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 支付宝侧发行方编码,咨询业务获取
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 参数需要咨询业务同学，需预先分配后才可上送，否则会导致传入失败
        /// </summary>
        [XmlElement("veh_biz_scene")]
        public string VehBizScene { get; set; }

        /// <summary>
        /// 车辆发动机号
        /// </summary>
        [XmlElement("vi_license_engine")]
        public string ViLicenseEngine { get; set; }

        /// <summary>
        /// 行驶证信息-车辆识别号
        /// </summary>
        [XmlElement("vi_license_vin")]
        public string ViLicenseVin { get; set; }
    }
}
