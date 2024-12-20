using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PlatformInquiryOrderExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PlatformInquiryOrderExtInfo : AopObject
    {
        /// <summary>
        /// 支付宝渠道订单标识 枚举值： 是:Y 否:N
        /// </summary>
        [XmlElement("alipay_channel_order_flag")]
        public string AlipayChannelOrderFlag { get; set; }

        /// <summary>
        /// 审核意见
        /// </summary>
        [XmlElement("approve_comment")]
        public string ApproveComment { get; set; }

        /// <summary>
        /// 医患沟通详情链接
        /// </summary>
        [XmlElement("chat_url")]
        public string ChatUrl { get; set; }

        /// <summary>
        /// 病情主诉
        /// </summary>
        [XmlElement("complaint")]
        public string Complaint { get; set; }

        /// <summary>
        /// 联系医生问诊链接
        /// </summary>
        [XmlElement("doctor_inquiry_link_page")]
        public string DoctorInquiryLinkPage { get; set; }

        /// <summary>
        /// 订单开票入口
        /// </summary>
        [XmlElement("invoice_url")]
        public string InvoiceUrl { get; set; }

        /// <summary>
        /// 问诊订单评价信息
        /// </summary>
        [XmlElement("medical_inquiry_order_evaluate_info")]
        public PlatformInquiryOrderEvaluateInfo MedicalInquiryOrderEvaluateInfo { get; set; }

        /// <summary>
        /// 订单所属pid
        /// </summary>
        [XmlElement("order_pid")]
        public string OrderPid { get; set; }

        /// <summary>
        /// 加号扩展信息
        /// </summary>
        [XmlElement("plus_register_info")]
        public PlatformPlusRegisterInfo PlusRegisterInfo { get; set; }

        /// <summary>
        /// 订单退款入口
        /// </summary>
        [XmlElement("refund_url")]
        public string RefundUrl { get; set; }

        /// <summary>
        /// 枚举值： 支付宝问诊频道:ALIPAY_INQUIRY_CHANNEL 支付宝义诊频道:ALIPAY_PUBLIC_WELFARE_INQUIRY_CHANNEL 支付宝小程序:ALIPAY_MINI_APP 支付宝其他渠道:ALIPAY_OTHER_CHANNEL
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
