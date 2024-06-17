using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssistantMsgRecordVO Data Structure.
    /// </summary>
    [Serializable]
    public class AssistantMsgRecordVO : AopObject
    {
        /// <summary>
        /// 小助手类型，目前只支持 activity_recommend (自定义活动)
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 小助手内容id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 消息发布时间
        /// </summary>
        [XmlElement("gmt_published")]
        public string GmtPublished { get; set; }

        /// <summary>
        /// 消息名称，b侧展示用，不在c侧群内透出
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 小助手消息状态  INIT (初始化), AUDITING (审核中), DENY (审核驳回), PENDING (待生效), VALID (生效), INVALID (失效), DELETED (删除);
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
