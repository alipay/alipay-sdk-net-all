using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppEbppFamilyNoticeSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppEbppFamilyNoticeSendModel : AopObject
    {
        /// <summary>
        /// 发送的消息类型
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 消息发送变量
        /// </summary>
        [XmlElement("msg_vars")]
        public string MsgVars { get; set; }

        /// <summary>
        /// 发送目标用户的支付宝UID,数据来源于用户线上授权
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 共享权益的商品SKUID
        /// </summary>
        [XmlElement("sku")]
        public string Sku { get; set; }

        /// <summary>
        /// 发送目标用户的支付宝UID,数据来源于用户线上授权
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
