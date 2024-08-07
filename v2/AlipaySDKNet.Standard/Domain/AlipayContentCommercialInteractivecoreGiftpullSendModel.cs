using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentCommercialInteractivecoreGiftpullSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentCommercialInteractivecoreGiftpullSendModel : AopObject
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
        /// 查询开始时间，毫秒时间戳，查询礼物数据的起始时间，最早不超过当前时间的20s
        /// </summary>
        [XmlElement("query_start_time")]
        public string QueryStartTime { get; set; }

        /// <summary>
        /// 毫秒时间戳
        /// </summary>
        [XmlElement("ts")]
        public string Ts { get; set; }
    }
}
