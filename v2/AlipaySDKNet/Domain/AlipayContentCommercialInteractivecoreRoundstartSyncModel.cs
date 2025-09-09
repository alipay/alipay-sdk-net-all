using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentCommercialInteractivecoreRoundstartSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentCommercialInteractivecoreRoundstartSyncModel : AopObject
    {
        /// <summary>
        /// 玩法token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 加入面板信息
        /// </summary>
        [XmlArray("join_panel_info")]
        [XmlArrayItem("join_panel_info")]
        public List<JoinPanelInfo> JoinPanelInfo { get; set; }

        /// <summary>
        /// 消息唯一id，用于幂等消费
        /// </summary>
        [XmlElement("msg_id")]
        public string MsgId { get; set; }

        /// <summary>
        /// 对局id，由英文数字组成，不超过20字符，同一玩法内唯一
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
