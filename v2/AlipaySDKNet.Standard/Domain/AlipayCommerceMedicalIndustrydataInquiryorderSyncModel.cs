using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataInquiryorderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataInquiryorderSyncModel : AopObject
    {
        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 订单金额，单位元，保留小数点后两位
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public PlatformInquiryOrderExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 外部排班Id
        /// </summary>
        [XmlElement("ext_shift_case_id")]
        public string ExtShiftCaseId { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 枚举值： 图文问诊:IMAGE_INQUIRY 电话问诊:PHONE_INQUIRY 视频问诊:VIDEO_INQUIRY 快速图文:QUICK_IMAGE_INQUIRY 快速电话:QUICK_PHONE_INQUIRY 快速视频:QUICK_VIDEO_INQUIR
        /// </summary>
        [XmlElement("inquiry_mode")]
        public string InquiryMode { get; set; }

        /// <summary>
        /// 枚举值： 咨询:FIRST_CONSULTATION 复诊:FURTHER_CONSULTATION 报告解读:REPORT_INTERPRET 会诊:MEETING_CONSULTATION 义诊:FREE_CONSULTATION 咨询+复诊:FIRST_FURTHER_CONSULTATION 加号:PLUS_REGISTER
        /// </summary>
        [XmlElement("inquiry_type")]
        public string InquiryType { get; set; }

        /// <summary>
        /// 外部平台医生id
        /// </summary>
        [XmlElement("merchant_doctor_id")]
        public string MerchantDoctorId { get; set; }

        /// <summary>
        /// 必须是支付宝小程序链接
        /// </summary>
        [XmlElement("merchant_order_link_page")]
        public string MerchantOrderLinkPage { get; set; }

        /// <summary>
        /// 待支付：WAIT_PAY、待接诊：WAIT_INQUIRY 订单在待支付/待接诊状态时回流
        /// </summary>
        [XmlElement("merchant_order_status")]
        public string MerchantOrderStatus { get; set; }

        /// <summary>
        /// 外部自有用户id，无特殊校验
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 订单创建时间，不可晚于当前时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 枚举值： 是:Y 否:N
        /// </summary>
        [XmlElement("order_hidden_flag")]
        public string OrderHiddenFlag { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [XmlElement("order_modified_time")]
        public string OrderModifiedTime { get; set; }

        /// <summary>
        /// 枚举值： 问诊订单:INQUIRY_ORDER
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// out_biz_no，唯一，外部商户自有订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 枚举值： 问诊订单:INQUIRY_ORDER 义诊订单:PUBLIC_WELFARE
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 患者年龄
        /// </summary>
        [XmlElement("patient_age")]
        public string PatientAge { get; set; }

        /// <summary>
        /// 患者身份证号
        /// </summary>
        [XmlElement("patient_idcard")]
        public string PatientIdcard { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 患者手机号
        /// </summary>
        [XmlElement("patient_phone")]
        public string PatientPhone { get; set; }

        /// <summary>
        /// 枚举值： 男：MALE  女：FEMALE
        /// </summary>
        [XmlElement("patient_sex")]
        public string PatientSex { get; set; }

        /// <summary>
        /// 平台编码号
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 实际支付金额
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 预约问诊时间
        /// </summary>
        [XmlElement("scheduled_time")]
        public string ScheduledTime { get; set; }
    }
}
