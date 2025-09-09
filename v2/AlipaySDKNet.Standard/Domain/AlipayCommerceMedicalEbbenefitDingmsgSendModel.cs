using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalEbbenefitDingmsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalEbbenefitDingmsgSendModel : AopObject
    {
        /// <summary>
        /// 消息类型（好大夫这边自定义，方便后续识别特定消息做特殊处理）
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 息参数
        /// </summary>
        [XmlElement("data")]
        public RemindVO Data { get; set; }

        /// <summary>
        /// 会员id
        /// </summary>
        [XmlElement("eb_user_id")]
        public string EbUserId { get; set; }

        /// <summary>
        /// 服务类型  图文问诊:IMAGE_INQUIRY 电话问诊:PHONE_INQUIRY 视频问诊:VIDEO_INQUIRY 快速图文:QUICK_IMAGE_INQUIRY 快速电话:QUICK_PHONE_INQUIRY 快速视频:QUICK_VIDEO_INQUIRY 互联网门诊（电话）: INTERNET_CLINIC_PHONE 互联网门诊（视频）: INTERNET_CLINIC_VIDEO 门诊安排：CLINIC_ARRANGEMENT 住院安排：HOSPITALIZATION_ARRANGEMENTS
        /// </summary>
        [XmlElement("inquiry_mode")]
        public string InquiryMode { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("jump_url")]
        public string JumpUrl { get; set; }

        /// <summary>
        /// 消息创建时间
        /// </summary>
        [XmlElement("msg_time")]
        public string MsgTime { get; set; }

        /// <summary>
        /// 消息类型 提醒消息  REMIND
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 订单id（好大夫不传）
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单类型   专家问诊:SPECIALIST_CONSULTATION 体检解读:HEALTH_CHECK 家庭医生:FAMILY_DOCTOR 家庭医生服务记录:FAMILY_DOCTOR_SERVICES 就医协助:MEDICAL_ASSISTANCE 顾问服务:CONSULTING_SERVICES
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部订单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 外部父单号
        /// </summary>
        [XmlElement("out_parent_order_id")]
        public string OutParentOrderId { get; set; }

        /// <summary>
        /// 外部子用户ID
        /// </summary>
        [XmlElement("out_sub_user_id")]
        public string OutSubUserId { get; set; }

        /// <summary>
        /// 外部自有用户id，无特殊校验
        /// </summary>
        [XmlElement("out_user_id")]
        public string OutUserId { get; set; }
    }
}
