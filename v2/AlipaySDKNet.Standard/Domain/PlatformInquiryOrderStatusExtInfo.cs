using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PlatformInquiryOrderStatusExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PlatformInquiryOrderStatusExtInfo : AopObject
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 已取消：取消原因 超时取消 TIMEOUT_CANCEL 用户取消 CANCEL_BY_USER
        /// </summary>
        [XmlElement("cancel_reason")]
        public string CancelReason { get; set; }

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
        /// 医生头像
        /// </summary>
        [XmlElement("doctor_avatar")]
        public string DoctorAvatar { get; set; }

        /// <summary>
        /// 联系医生问诊链接
        /// </summary>
        [XmlElement("doctor_inquiry_link_page")]
        public string DoctorInquiryLinkPage { get; set; }

        /// <summary>
        /// 接诊医生外部医生ID
        /// </summary>
        [XmlElement("doctor_out_id")]
        public string DoctorOutId { get; set; }

        /// <summary>
        /// 接诊医生姓名
        /// </summary>
        [XmlElement("doctor_out_name")]
        public string DoctorOutName { get; set; }

        /// <summary>
        /// 医生拒诊原因
        /// </summary>
        [XmlElement("doctor_refuse_reason")]
        public string DoctorRefuseReason { get; set; }

        /// <summary>
        /// 医生职称
        /// </summary>
        [XmlElement("doctor_title")]
        public string DoctorTitle { get; set; }

        /// <summary>
        /// 医生类型，判断医生属于家庭医生还是专科医生
        /// </summary>
        [XmlElement("doctor_type")]
        public string DoctorType { get; set; }

        /// <summary>
        /// 是否首次回复
        /// </summary>
        [XmlElement("first_reply")]
        public bool FirstReply { get; set; }

        /// <summary>
        /// 接诊时间
        /// </summary>
        [XmlElement("gmt_adoption")]
        public string GmtAdoption { get; set; }

        /// <summary>
        /// 取消时间
        /// </summary>
        [XmlElement("gmt_cancel")]
        public string GmtCancel { get; set; }

        /// <summary>
        /// 问诊单完成时间
        /// </summary>
        [XmlElement("gmt_finished")]
        public string GmtFinished { get; set; }

        /// <summary>
        /// 支付时间
        /// </summary>
        [XmlElement("gmt_paid")]
        public string GmtPaid { get; set; }

        /// <summary>
        /// 退款时间
        /// </summary>
        [XmlElement("gmt_refund")]
        public string GmtRefund { get; set; }

        /// <summary>
        /// 退款申请时间
        /// </summary>
        [XmlElement("gmt_refund_applying")]
        public string GmtRefundApplying { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 问诊完成类型 DOCTOR_ACTIVE_END：医生主动完成 TIMEOUT_END：超时结束
        /// </summary>
        [XmlElement("inquiry_complete_status")]
        public string InquiryCompleteStatus { get; set; }

        /// <summary>
        /// 是否触发消息通知
        /// </summary>
        [XmlElement("notice")]
        public bool Notice { get; set; }

        /// <summary>
        /// 实付金额
        /// </summary>
        [XmlElement("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款审核失败原因
        /// </summary>
        [XmlElement("reject_refund_reason")]
        public string RejectRefundReason { get; set; }

        /// <summary>
        /// 5分钟未支付消息提醒
        /// </summary>
        [XmlElement("remind_pay")]
        public bool RemindPay { get; set; }

        /// <summary>
        /// 回复内容
        /// </summary>
        [XmlElement("reply_content")]
        public string ReplyContent { get; set; }

        /// <summary>
        /// 服务截止时间
        /// </summary>
        [XmlElement("service_end_time")]
        public string ServiceEndTime { get; set; }
    }
}
