using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalDoctorMsgSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalDoctorMsgSendModel : AopObject
    {
        /// <summary>
        /// 端用户id
        /// </summary>
        [XmlElement("aq_user_id")]
        public string AqUserId { get; set; }

        /// <summary>
        /// aq_user_id
        /// </summary>
        [XmlElement("aq_user_open_id")]
        public string AqUserOpenId { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 最近的客户端消息ID
        /// </summary>
        [XmlElement("client_msg_id")]
        public string ClientMsgId { get; set; }

        /// <summary>
        /// 外部传入，随机生成
        /// </summary>
        [XmlElement("conversation_id")]
        public string ConversationId { get; set; }

        /// <summary>
        /// 会话名称
        /// </summary>
        [XmlElement("conversation_name")]
        public string ConversationName { get; set; }

        /// <summary>
        /// 会话类型
        /// </summary>
        [XmlElement("conversation_type")]
        public string ConversationType { get; set; }

        /// <summary>
        /// 最近消息时间
        /// </summary>
        [XmlElement("latest_msg_time")]
        public string LatestMsgTime { get; set; }

        /// <summary>
        /// 跳转链接
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 最近的消息数据
        /// </summary>
        [XmlElement("msg_data")]
        public string MsgData { get; set; }

        /// <summary>
        /// 最近的消息ID
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 外部传入，需要发送的消息模版
        /// </summary>
        [XmlElement("msg_template_code")]
        public string MsgTemplateCode { get; set; }

        /// <summary>
        /// 最近的消息类型
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 外部传入，随机生成
        /// </summary>
        [XmlElement("out_app_id")]
        public string OutAppId { get; set; }

        /// <summary>
        /// 外部传入，随机生成
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 外部业务名称
        /// </summary>
        [XmlElement("out_biz_name")]
        public string OutBizName { get; set; }

        /// <summary>
        /// 接收者类型
        /// </summary>
        [XmlElement("receiver_type")]
        public string ReceiverType { get; set; }

        /// <summary>
        /// 接收者，逗号分隔
        /// </summary>
        [XmlElement("receivers")]
        public string Receivers { get; set; }

        /// <summary>
        /// 外部传入，需要发送的消息类型
        /// </summary>
        [XmlElement("send_types")]
        public string SendTypes { get; set; }

        /// <summary>
        /// 显示内容
        /// </summary>
        [XmlElement("show_content")]
        public string ShowContent { get; set; }

        /// <summary>
        /// 外部传入，需要发送的消息内容
        /// </summary>
        [XmlElement("template_params")]
        public string TemplateParams { get; set; }

        /// <summary>
        /// 剩余未读消息数
        /// </summary>
        [XmlElement("un_read_count")]
        public long UnReadCount { get; set; }
    }
}
