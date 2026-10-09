using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalMedmsgEventmsgNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalMedmsgEventmsgNotifyModel : AopObject
    {
        /// <summary>
        /// 关联业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [XmlElement("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 消息事件触发的事件类型，由服务端指定。
        /// </summary>
        [XmlElement("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 发送事件消息的参数
        /// </summary>
        [XmlArray("medical_medmsg_arg")]
        [XmlArrayItem("medical_medmsg_arg")]
        public List<MedicalMedmsgArg> MedicalMedmsgArg { get; set; }

        /// <summary>
        /// 消息创建时间
        /// </summary>
        [XmlElement("msg_create_time")]
        public string MsgCreateTime { get; set; }

        /// <summary>
        /// 事件消息的唯一消息ID
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 推送标志位
        /// </summary>
        [XmlElement("push")]
        public string Push { get; set; }

        /// <summary>
        /// 目标支付宝用户ID
        /// </summary>
        [XmlElement("to_user_id")]
        public string ToUserId { get; set; }
    }
}
