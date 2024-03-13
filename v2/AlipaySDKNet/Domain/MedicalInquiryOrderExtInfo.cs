using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MedicalInquiryOrderExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MedicalInquiryOrderExtInfo : AopObject
    {
        /// <summary>
        /// 支付宝渠道订单标识，Y代表支付宝渠道订单
        /// </summary>
        [XmlElement("alipay_channel_order_flag")]
        public string AlipayChannelOrderFlag { get; set; }

        /// <summary>
        /// 审核意见
        /// </summary>
        [XmlElement("approve_comment")]
        public string ApproveComment { get; set; }

        /// <summary>
        /// 链接格式
        /// </summary>
        [XmlElement("chat_url")]
        public string ChatUrl { get; set; }

        /// <summary>
        /// 联系医生问诊链接
        /// </summary>
        [XmlElement("doctor_inquiry_link_page")]
        public string DoctorInquiryLinkPage { get; set; }

        /// <summary>
        /// 链接格式
        /// </summary>
        [XmlElement("invoice_url")]
        public string InvoiceUrl { get; set; }

        /// <summary>
        /// 问诊订单评价信息
        /// </summary>
        [XmlElement("medical_inquiry_order_evaluate_info")]
        public MedicalInquiryOrderEvaluateInfo MedicalInquiryOrderEvaluateInfo { get; set; }

        /// <summary>
        /// 订单所属pid
        /// </summary>
        [XmlElement("order_pid")]
        public string OrderPid { get; set; }

        /// <summary>
        /// 链接格式
        /// </summary>
        [XmlElement("refund_url")]
        public string RefundUrl { get; set; }

        /// <summary>
        /// 订单来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
