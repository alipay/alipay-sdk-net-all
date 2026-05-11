using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalHdfImmessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalHdfImmessageSendModel : AopObject
    {
        /// <summary>
        /// 消息行为
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 前端消息唯一id
        /// </summary>
        [XmlElement("app_msg_id")]
        public string AppMsgId { get; set; }

        /// <summary>
        /// app版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// 业务标识
        /// </summary>
        [XmlElement("business")]
        public string Business { get; set; }

        /// <summary>
        /// 业务标识详细
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 连接申请设备类型
        /// </summary>
        [XmlElement("device")]
        public string Device { get; set; }

        /// <summary>
        /// 连接申请设备唯一标识
        /// </summary>
        [XmlElement("device_key")]
        public string DeviceKey { get; set; }

        /// <summary>
        /// 消息发送者连接id
        /// </summary>
        [XmlElement("from_connection_id")]
        public string FromConnectionId { get; set; }

        /// <summary>
        /// 消息发送者账号id
        /// </summary>
        [XmlElement("from_source_id")]
        public string FromSourceId { get; set; }

        /// <summary>
        /// 消息发送者账号类型
        /// </summary>
        [XmlElement("from_source_type")]
        public string FromSourceType { get; set; }

        /// <summary>
        /// 接口行为
        /// </summary>
        [XmlElement("method_action")]
        public string MethodAction { get; set; }

        /// <summary>
        /// 消息体
        /// </summary>
        [XmlElement("msg_body")]
        public string MsgBody { get; set; }

        /// <summary>
        /// 消息唯一KEY
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 是否需要Xss
        /// </summary>
        [XmlElement("need_xss")]
        public bool NeedXss { get; set; }

        /// <summary>
        /// im sdk版本号
        /// </summary>
        [XmlElement("sdk_version")]
        public string SdkVersion { get; set; }

        /// <summary>
        /// 消息接收详细id集合，适用于发送给群内某些人
        /// </summary>
        [XmlElement("to_detail_id_list")]
        public string ToDetailIdList { get; set; }

        /// <summary>
        /// 消息接收者账号id
        /// </summary>
        [XmlElement("to_source_id")]
        public string ToSourceId { get; set; }

        /// <summary>
        /// 消息接收者类型
        /// </summary>
        [XmlElement("to_source_type")]
        public string ToSourceType { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 好大夫用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
