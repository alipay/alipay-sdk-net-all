using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssistantMsgDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class AssistantMsgDetailVO : AopObject
    {
        /// <summary>
        /// 自定义活动内容
        /// </summary>
        [XmlElement("activity_content")]
        public ActivityAssistantMsgContentVO ActivityContent { get; set; }

        /// <summary>
        /// 权益推荐小助手内容
        /// </summary>
        [XmlElement("benefit_content")]
        public BenefitAssistantMsgContentVO BenefitContent { get; set; }

        /// <summary>
        /// 小助手类型，目前支持 activity_recommend (自定义活动)、benefit_recommend（权益推荐）
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 小助手消息内容id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 消息发送时间
        /// </summary>
        [XmlElement("gmt_published")]
        public string GmtPublished { get; set; }

        /// <summary>
        /// 群组id列表，创建群组时对应的一个群组id
        /// </summary>
        [XmlArray("group_ids")]
        [XmlArrayItem("string")]
        public List<string> GroupIds { get; set; }

        /// <summary>
        /// 消息名称，b侧展示用，不在c侧群内透出
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 消息发送状态  INIT( 初始化), AUDITING (审核中), DENY (审核驳回), PENDING (待生效), VALID (生效), INVALID (下线), DELETED (删除);
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
