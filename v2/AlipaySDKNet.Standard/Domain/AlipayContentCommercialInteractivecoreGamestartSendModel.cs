using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentCommercialInteractivecoreGamestartSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentCommercialInteractivecoreGamestartSendModel : AopObject
    {
        /// <summary>
        /// 用于标识玩法
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 礼物效果信息
        /// </summary>
        [XmlArray("gift_batch_info")]
        [XmlArrayItem("gift_batch_info")]
        public List<GiftBatchInfo> GiftBatchInfo { get; set; }

        /// <summary>
        /// 消息唯一id，用于幂等消费
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 东八区毫秒时间戳
        /// </summary>
        [XmlElement("ts")]
        public string Ts { get; set; }
    }
}
