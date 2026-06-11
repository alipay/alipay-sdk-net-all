using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelMessagesSendNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelMessagesSendNotifyModel : AopObject
    {
        /// <summary>
        /// 消息参数，钱包服务端使用该字段值去组装对应的模板参数
        /// </summary>
        [XmlElement("message_args")]
        public string MessageArgs { get; set; }

        /// <summary>
        /// 业务id,消息唯一id
        /// </summary>
        [XmlElement("message_request_id")]
        public string MessageRequestId { get; set; }

        /// <summary>
        /// 消息场景，用于映射消息通知模板
        /// </summary>
        [XmlElement("message_scene")]
        public string MessageScene { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 钱包id
        /// </summary>
        [XmlElement("psp_id")]
        public string PspId { get; set; }
    }
}
