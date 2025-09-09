using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeChatSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniAmpeChatSendModel : AopObject
    {
        /// <summary>
        /// AMPE设备id，代表唯一一台设备，在支付宝开放平台，或者通过openapi接口注册。
        /// </summary>
        [XmlElement("ampe_device_id")]
        public string AmpeDeviceId { get; set; }

        /// <summary>
        /// AMPE产品id，在AMPE平台申请，代表一种设备产品。
        /// </summary>
        [XmlElement("ampe_product_id")]
        public string AmpeProductId { get; set; }

        /// <summary>
        /// AMPE运行时的设备信息，仅用于云卡片场景
        /// </summary>
        [XmlElement("device_info")]
        public AmpeDeviceInfo DeviceInfo { get; set; }

        /// <summary>
        /// 支付宝的意图code，由支付宝定义，意图列表可从参见BD提供的意图code列表，不定期更新。接入方可以根据支付宝提供的语料对自由的模型进行训练标注，经过自有模型意图分析后，在调用本接口时传入，这样会提高query的识别准确度，并提高响应速度。如果不传入，支付宝将根据自己的模型对query进行意图识别。目前可选值为:SMART_ORDER（智能点单）
        /// </summary>
        [XmlElement("intent_code")]
        public string IntentCode { get; set; }

        /// <summary>
        /// 地理位置列表，包含对话所需要的各种地理位置信息，例如当前位置、目标位置、家庭等等
        /// </summary>
        [XmlArray("locations")]
        [XmlArrayItem("chat_location")]
        public List<ChatLocation> Locations { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户输入的原始query，不能改写。
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 用户的会话流水，代表用户的一次query。
        /// </summary>
        [XmlElement("req_no")]
        public string ReqNo { get; set; }

        /// <summary>
        /// 会话id，代表用户一个完整的会话周期，用户串联用户会话的上下文，需要有过期机制，以避免会话过长。不同sessionId下的会话相互隔离。
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 支付宝用户uid的加密串，可以通过客户端接口获取。不涉及用户个人数据操作的可为空，其他场景都为非空。
        /// </summary>
        [XmlElement("user_key")]
        public string UserKey { get; set; }
    }
}
