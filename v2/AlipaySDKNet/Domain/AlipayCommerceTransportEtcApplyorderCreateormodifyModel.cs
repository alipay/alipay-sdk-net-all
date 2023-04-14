using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcApplyorderCreateormodifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcApplyorderCreateormodifyModel : AopObject
    {
        /// <summary>
        /// 支付宝订单号，提供则认为是更新
        /// </summary>
        [XmlElement("alipay_order_id")]
        public string AlipayOrderId { get; set; }

        /// <summary>
        /// 办理人所在地城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 蚂蚁会员统一ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 审核资料提交状态。WAIT_SUBMIT：信息待提交；SUBMITTED：信息已提交。
        /// </summary>
        [XmlElement("order_censor_status")]
        public string OrderCensorStatus { get; set; }

        /// <summary>
        /// 支付状态。WAIT_PAY：待支付，PAYED：已支付。
        /// </summary>
        [XmlElement("order_pay_status")]
        public string OrderPayStatus { get; set; }

        /// <summary>
        /// 外部订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 办理车牌颜色 BLUE: 蓝色;  YELLOW: 黄色;  BLACK: 黑色;  WHITE: 白色;  GREEN: 绿色;  LIMEGREEN: 黄绿色。
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 办理车牌号
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

        /// <summary>
        /// 发行方的标识ID
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 行驶证信息-核定载人数
        /// </summary>
        [XmlElement("vi_license_apc")]
        public string ViLicenseApc { get; set; }

        /// <summary>
        /// 行驶证信息-品牌车型
        /// </summary>
        [XmlElement("vi_license_brand_model")]
        public string ViLicenseBrandModel { get; set; }

        /// <summary>
        /// 行驶证信息-车辆类型
        /// </summary>
        [XmlElement("vi_license_car_type")]
        public string ViLicenseCarType { get; set; }

        /// <summary>
        /// 行驶证信息-发动机号
        /// </summary>
        [XmlElement("vi_license_engine")]
        public string ViLicenseEngine { get; set; }

        /// <summary>
        /// 行驶证信息-总质量
        /// </summary>
        [XmlElement("vi_license_gross_mass")]
        public string ViLicenseGrossMass { get; set; }

        /// <summary>
        /// 行驶证信息-发证时间
        /// </summary>
        [XmlElement("vi_license_issue_date")]
        public string ViLicenseIssueDate { get; set; }

        /// <summary>
        /// 行驶证信息-外廓尺寸
        /// </summary>
        [XmlElement("vi_license_overall_dinmension")]
        public string ViLicenseOverallDinmension { get; set; }

        /// <summary>
        /// 行驶证信息-车辆所有人
        /// </summary>
        [XmlElement("vi_license_owner")]
        public string ViLicenseOwner { get; set; }

        /// <summary>
        /// 行驶证信息-注册时间
        /// </summary>
        [XmlElement("vi_license_register_date")]
        public string ViLicenseRegisterDate { get; set; }

        /// <summary>
        /// 行驶证信息-整备质量
        /// </summary>
        [XmlElement("vi_license_unladen_mass")]
        public string ViLicenseUnladenMass { get; set; }

        /// <summary>
        /// 行驶证信息-使用性质：运营/非营运
        /// </summary>
        [XmlElement("vi_license_use_type")]
        public string ViLicenseUseType { get; set; }

        /// <summary>
        /// 行驶证信息-车辆识别号
        /// </summary>
        [XmlElement("vi_license_vin")]
        public string ViLicenseVin { get; set; }
    }
}
