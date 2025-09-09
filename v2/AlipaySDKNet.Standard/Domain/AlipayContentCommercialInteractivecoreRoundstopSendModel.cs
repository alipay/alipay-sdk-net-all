using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentCommercialInteractivecoreRoundstopSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentCommercialInteractivecoreRoundstopSendModel : AopObject
    {
        /// <summary>
        /// 玩法token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 消息唯一id，用于幂等消费
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 对局结束原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 对局id
        /// </summary>
        [XmlElement("round_id")]
        public string RoundId { get; set; }

        /// <summary>
        /// 毫秒时间戳
        /// </summary>
        [XmlElement("ts")]
        public string Ts { get; set; }
    }
}
