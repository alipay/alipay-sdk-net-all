using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseQuestInstancesQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseQuestInstancesQueryModel : AopObject
    {
        /// <summary>
        /// openId
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 目标ID列表，列表长度不能超过20
        /// </summary>
        [XmlArray("quest_ids")]
        [XmlArrayItem("string")]
        public List<string> QuestIds { get; set; }

        /// <summary>
        /// 调用方标识
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
