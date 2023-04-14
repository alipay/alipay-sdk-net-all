using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEtcApplyorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEtcApplyorderSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝ETC平台扣款协议号，与order_id参数 二选一。
        /// </summary>
        [XmlElement("biz_agreement_no")]
        public string BizAgreementNo { get; set; }

        /// <summary>
        /// 业务发生时间；对应order_status 几个状态的变更时间； 当order_status = DELIVERYED 时 biz_time 为物流发货时间；order_status = ACTIVATED时 biz_time为设备激活时间，以此类推
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 用户取消订单原因，在取消状态同步时必填
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 用户ETC卡号，激活状态时必传
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 审核不通过原因标准码，审核不通过时可以传递此标准码，域内将优先以标准码为准。
        /// </summary>
        [XmlElement("censor_code")]
        public string CensorCode { get; set; }

        /// <summary>
        /// 审核不通过原因， 审核不通过时必传
        /// </summary>
        [XmlElement("censor_info")]
        public string CensorInfo { get; set; }

        /// <summary>
        /// 已发货状态必传，物流公司编码，需要与菜鸟映射
        /// </summary>
        [XmlElement("delivery_code")]
        public string DeliveryCode { get; set; }

        /// <summary>
        /// 已发货状态必传，物流公司名称
        /// </summary>
        [XmlElement("delivery_name")]
        public string DeliveryName { get; set; }

        /// <summary>
        /// 已发货状态必传，物流单号
        /// </summary>
        [XmlElement("delivery_no")]
        public string DeliveryNo { get; set; }

        /// <summary>
        /// 用户ETC OBU号， 激活状态时必传
        /// </summary>
        [XmlElement("device_no")]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 是否需要退款，该字段只有在取消状态同步时才会消费，其他状态不消费；取消状态同步时，该状态必传。
        /// </summary>
        [XmlElement("need_refund")]
        public bool NeedRefund { get; set; }

        /// <summary>
        /// 蚂蚁会员统一ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝侧订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态； DELIVERYED：已发货； RECEIVED：已收货；  CENSOR_PASS：审核通过；  CENSOR_BLOCK：审核不通过 ； ACTIVATED：已激活；  UNMOUNTED：已注销；  CANCEL：取消；
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 外部业务号，对应用户该笔ETC申请单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 0：蓝； 1：黄； 2：黑； 3：白； 4：渐变绿
        /// </summary>
        [XmlElement("plate_color")]
        public string PlateColor { get; set; }

        /// <summary>
        /// 办理车牌
        /// </summary>
        [XmlElement("plate_no")]
        public string PlateNo { get; set; }

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
