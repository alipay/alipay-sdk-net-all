using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RedPacketAssistantMsgContentVO Data Structure.
    /// </summary>
    [Serializable]
    public class RedPacketAssistantMsgContentVO : AopObject
    {
        /// <summary>
        /// 小助手定向消息内容，发送小助手时推送给用户的群内推荐内容
        /// </summary>
        [XmlElement("recommend_text")]
        public string RecommendText { get; set; }

        /// <summary>
        /// 小助手红包列表
        /// </summary>
        [XmlArray("red_packet_list")]
        [XmlArrayItem("assistant_red_packet_v_o")]
        public List<AssistantRedPacketVO> RedPacketList { get; set; }
    }
}
