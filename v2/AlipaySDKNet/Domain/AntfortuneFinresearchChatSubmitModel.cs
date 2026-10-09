using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneFinresearchChatSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneFinresearchChatSubmitModel : AopObject
    {
        /// <summary>
        /// 合作方内部的唯一标识
        /// </summary>
        [XmlElement("bu_unique_id")]
        public string BuUniqueId { get; set; }

        /// <summary>
        /// 业务类型，如果是就业问答请传入college_work 其他的情况可以不传或者传空字符串
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 文件id，目前仅支持单个，如果传多个会默认使用第一个， 如果filetype传了file，并且指定了file_id ，则会根据文件内容来回答问题
        /// </summary>
        [XmlArray("file_ids")]
        [XmlArrayItem("string")]
        public List<string> FileIds { get; set; }

        /// <summary>
        /// 文件类型。开放出来的支持 文件解读(目前仅支持单个pdf),网页（单个）
        /// </summary>
        [XmlElement("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// RAG 快速解读，PEER 4e模式 不传默认使用PEER，
        /// </summary>
        [XmlElement("interpret_mode")]
        public string InterpretMode { get; set; }

        /// <summary>
        /// 用户所要提问的问题
        /// </summary>
        [XmlElement("question")]
        public string Question { get; set; }

        /// <summary>
        /// 会话id
        /// </summary>
        [XmlElement("session_id")]
        public string SessionId { get; set; }

        /// <summary>
        /// 小助分配给用户的租户id
        /// </summary>
        [XmlElement("tenant_id")]
        public string TenantId { get; set; }

        /// <summary>
        /// 需要解析的网页列表，如果file_type等于url，并且这个字段传了网址，则会根据网站的内容来回答内容，目前仅支持单个，如果传多个会默认使用第一个
        /// </summary>
        [XmlArray("urls")]
        [XmlArrayItem("string")]
        public List<string> Urls { get; set; }

        /// <summary>
        /// 从预设专家框架中选择想要指定的框架
        /// </summary>
        [XmlElement("user_framework_code")]
        public string UserFrameworkCode { get; set; }
    }
}
