using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryUserIntentionIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryUserIntentionIdentifyModel : AopObject
    {
        /// <summary>
        /// 历史提问和回答
        /// </summary>
        [XmlArray("history_list")]
        [XmlArrayItem("history_query_and_answer")]
        public List<HistoryQueryAndAnswer> HistoryList { get; set; }

        /// <summary>
        /// 用户身份id
        /// </summary>
        [XmlElement("identity_id")]
        public string IdentityId { get; set; }

        /// <summary>
        /// 用户提问的问题
        /// </summary>
        [XmlElement("query")]
        public string Query { get; set; }

        /// <summary>
        /// 用户会话id，用于描述用户当前的会话树
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }
    }
}
