using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateYouthServicemessageSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateYouthServicemessageSendModel : AopObject
    {
        /// <summary>
        /// 业务类型，用于区分不同业务场景
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 消息发送者AppId
        /// </summary>
        [XmlElement("from_app_id")]
        public string FromAppId { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("message_properties")]
        public string MessageProperties { get; set; }

        /// <summary>
        /// 消息枚举
        /// </summary>
        [XmlElement("msg_enum")]
        public string MsgEnum { get; set; }

        /// <summary>
        /// 消息接收者openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号（唯一幂等）
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 消息接收者UID
        /// </summary>
        [XmlElement("to_user_id")]
        public string ToUserId { get; set; }
    }
}
