using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MsgData Data Structure.
    /// </summary>
    [Serializable]
    public class MsgData : AopObject
    {
        /// <summary>
        /// 问诊订单ID
        /// </summary>
        [XmlElement("consultation_order_id")]
        public string ConsultationOrderId { get; set; }

        /// <summary>
        /// 问诊时间
        /// </summary>
        [XmlElement("consultation_time")]
        public string ConsultationTime { get; set; }

        /// <summary>
        /// 医生ID
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 接诊医生姓名
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        [XmlElement("introduction")]
        public string Introduction { get; set; }

        /// <summary>
        /// 外部商品编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 最新会话时间
        /// </summary>
        [XmlElement("latest_conversation_time")]
        public string LatestConversationTime { get; set; }

        /// <summary>
        /// 最新消息内容
        /// </summary>
        [XmlElement("latest_msg_content")]
        public string LatestMsgContent { get; set; }

        /// <summary>
        /// 消息id
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 消息时间
        /// </summary>
        [XmlElement("msg_time")]
        public string MsgTime { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 患者ID
        /// </summary>
        [XmlElement("patient_id")]
        public string PatientId { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 服务包过期时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("service_end_time")]
        public string ServiceEndTime { get; set; }

        /// <summary>
        /// 服务包ID
        /// </summary>
        [XmlElement("service_package_id")]
        public string ServicePackageId { get; set; }

        /// <summary>
        /// 服务包名称
        /// </summary>
        [XmlElement("service_package_name")]
        public string ServicePackageName { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
