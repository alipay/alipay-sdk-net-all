using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryBotChatQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryBotChatQueryResponse : AopResponse
    {
        /// <summary>
        /// 机器人问答记录列表
        /// </summary>
        [XmlArray("answer_list")]
        [XmlArrayItem("bot_chat_log")]
        public List<BotChatLog> AnswerList { get; set; }

        /// <summary>
        /// 当前返回的第几页数据
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 当前入参条件下查询到的个数。单位：个。
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
