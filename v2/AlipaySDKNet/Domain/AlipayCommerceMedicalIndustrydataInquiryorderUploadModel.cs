using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalIndustrydataInquiryorderUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalIndustrydataInquiryorderUploadModel : AopObject
    {
        /// <summary>
        /// 支付宝开放id
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 订单金额，精确到小数点后2位，单位为元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 医生所属科室
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 医生姓名
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public MedicalInquiryOrderExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 医生执业医院
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 图文问诊/电话问诊/视频问诊/快速图文/快速电话/快速视频 IMAGE_INQUIRY/PHONE_INQUIRY/VIDEO_INQUIRY/QUICK_IMAGE_INQUIRY/QUICK_PHONE_INQUIRY/QUICK_VIDEO_INQUIRY
        /// </summary>
        [XmlElement("inquiry_mode")]
        public string InquiryMode { get; set; }

        /// <summary>
        /// 问诊类型
        /// </summary>
        [XmlElement("inquiry_type")]
        public string InquiryType { get; set; }

        /// <summary>
        /// 外部平台医生id
        /// </summary>
        [XmlElement("merchant_doctor_id")]
        public string MerchantDoctorId { get; set; }

        /// <summary>
        /// 订单详情页链接
        /// </summary>
        [XmlElement("merchant_order_link_page")]
        public string MerchantOrderLinkPage { get; set; }

        /// <summary>
        /// 待支付 / 待接诊 / 待问诊 / 问诊中 / 已完成 / 已取消 / 已退款 / 退款中 / 取消中 / 审核失败 / 系统取消 / 用户取消 对应的枚举值 WAIT_PAY/WAIT_RECEPTION/WAIT_INQUIRY/IN_INQUIRY/FINISHED/CANCELED/REFUNDED/REFUNDING/CANCELING/APPROVE_FAIL/SYSTEM_CANCELED/USER_CANCELED
        /// </summary>
        [XmlElement("merchant_order_status")]
        public string MerchantOrderStatus { get; set; }

        /// <summary>
        /// 外部平台自身用户id，无特殊校验
        /// </summary>
        [XmlElement("merchant_user_id")]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单隐藏标志，默认为N
        /// </summary>
        [XmlElement("order_hidden_flag")]
        public string OrderHiddenFlag { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [XmlElement("order_modified_time")]
        public string OrderModifiedTime { get; set; }

        /// <summary>
        /// 固定值：INQUIRY_ORDER
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// out_biz_no，唯一，外部商户自有订单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部订单类型
        /// </summary>
        [XmlElement("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 外部平台编号，支付宝给出
        /// </summary>
        [XmlElement("platform_code")]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 实际支付金额，精确到小数点后2位，单位为元
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 退款金额，精确到小数点后2位，单位为元
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
