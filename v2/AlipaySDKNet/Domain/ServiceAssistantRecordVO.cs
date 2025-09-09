using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceAssistantRecordVO Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceAssistantRecordVO : AopObject
    {
        /// <summary>
        /// 小助手内容id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 小助手发布时间，即小助手创建或者修改时间。
        /// </summary>
        [XmlElement("gmt_published")]
        public string GmtPublished { get; set; }

        /// <summary>
        /// 快捷服务名称，b侧展示用，不在c侧群内透出
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务数量
        /// </summary>
        [XmlElement("service_cnt")]
        public long ServiceCnt { get; set; }

        /// <summary>
        /// 小助手状态 INIT (初始化), AUDITING (审核中), DENY (审核驳回), VALID (生效), INVALID (失效)；DENY (审核驳回)是终态；INVALID (失效)支持修改； INVALID (失效)支持上线；VALID (生效)支持下线。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
