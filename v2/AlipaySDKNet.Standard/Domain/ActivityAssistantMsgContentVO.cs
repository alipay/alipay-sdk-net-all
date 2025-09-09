using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityAssistantMsgContentVO Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityAssistantMsgContentVO : AopObject
    {
        /// <summary>
        /// 小助手活动内容信息列表
        /// </summary>
        [XmlArray("activity_list")]
        [XmlArrayItem("assistant_activity_v_o")]
        public List<AssistantActivityVO> ActivityList { get; set; }

        /// <summary>
        /// 小助手定向消息内容，发送小助手时推送给用户的群内消息内容
        /// </summary>
        [XmlElement("recommend_text")]
        public string RecommendText { get; set; }
    }
}
