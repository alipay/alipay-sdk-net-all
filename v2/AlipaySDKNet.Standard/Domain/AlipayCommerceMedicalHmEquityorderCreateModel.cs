using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHmEquityorderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHmEquityorderCreateModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("appoint_info_list")]
        [XmlArrayItem("hm_appoint_info")]
        public List<HmAppointInfo> AppointInfoList { get; set; }

        /// <summary>
        /// 基础权益Code
        /// </summary>
        [XmlElement("benefit_code")]
        public string BenefitCode { get; set; }

        /// <summary>
        /// 业务流水号
        /// </summary>
        [XmlElement("biz_serial_no")]
        public string BizSerialNo { get; set; }

        /// <summary>
        /// 订单的业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 用户证件号
        /// </summary>
        [XmlElement("certificate_no")]
        public string CertificateNo { get; set; }

        /// <summary>
        /// 该字段定义的枚举为: 中国居民身份证:IDENTITY_CARD 军人证:THE_MILITARY_CARD 港澳回乡证或台胞证:BACK_HOMETOWN_CARD 台湾通行证:HOME_VISIT_PERMIT_TAIWAN 护照:PASSPORT 港澳台居民居住证:RESIDENCE_PERMIT_HK_MC_TW 外国人永久居留身份证:PERMANENT_RESIDENCE_FOREIGNER 港澳通行证:HOME_VISIT_PERMIT_HK_MC 其他证件:OTHER_CARD
        /// </summary>
        [XmlElement("certificate_type")]
        public string CertificateType { get; set; }

        /// <summary>
        /// 权益包编码
        /// </summary>
        [XmlElement("equity_package_code")]
        public string EquityPackageCode { get; set; }

        /// <summary>
        /// 健管用户ID（UID）
        /// </summary>
        [XmlElement("hm_uid")]
        public string HmUid { get; set; }

        /// <summary>
        /// 订单来源
        /// </summary>
        [XmlElement("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 订单创建时间（yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 该字段定义的枚举为: 线上购药:BUY_MEDICINE 折扣购药:DISCOUNT_MEDICINE 全年无限次图文问诊:GRAPHICS_INQUIRY 全年无限次视频问诊:VIDEO_INQUIRY 就医绿通:GREEN_CHANNEL
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部out_uid
        /// </summary>
        [XmlElement("out_uid")]
        public string OutUid { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("pay_info_list")]
        [XmlArrayItem("hm_pay_info")]
        public List<HmPayInfo> PayInfoList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("product_info_list")]
        [XmlArrayItem("hm_product_info")]
        public List<HmProductInfo> ProductInfoList { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("refund_info_list")]
        [XmlArrayItem("hm_refund_info")]
        public List<HmRefundInfo> RefundInfoList { get; set; }

        /// <summary>
        /// 供应商订单号
        /// </summary>
        [XmlElement("supplier_order_id")]
        public string SupplierOrderId { get; set; }

        /// <summary>
        /// 订单的总金额（所有费用总金额）单位：分
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [XmlElement("uid_open_id")]
        public string UidOpenId { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("user_phone")]
        public string UserPhone { get; set; }
    }
}
