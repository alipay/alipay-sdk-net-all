using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServiceAssistantDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceAssistantDetailVO : AopObject
    {
        /// <summary>
        /// 小助手业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 小助手内容id
        /// </summary>
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 小助手发布时间，取的创建或者修改时间。
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
        /// 小助手快捷服务名称，b侧展示用，不在c侧群内透出
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务列表
        /// </summary>
        [XmlArray("services")]
        [XmlArrayItem("assistant_service_v_o")]
        public List<AssistantServiceVO> Services { get; set; }

        /// <summary>
        /// 小助手状态 INIT( 初始化), AUDITING (审核中), DENY (审核驳回), VALID (生效), INVALID (下线)；DENY (审核驳回)是终态；VALID (生效)支持下线到状态INVALID (下线)；INVALID (下线)支持上线到VALID (生效)；INVALID (下线)支持修改。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
