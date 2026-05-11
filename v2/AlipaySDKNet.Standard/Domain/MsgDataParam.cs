using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MsgDataParam Data Structure.
    /// </summary>
    [Serializable]
    public class MsgDataParam : AopObject
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
        /// 患者姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
