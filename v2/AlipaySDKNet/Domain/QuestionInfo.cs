using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QuestionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class QuestionInfo : AopObject
    {
        /// <summary>
        /// 使用分组配置的时候才有该字段
        /// </summary>
        [XmlElement("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 机器人对话中，近30天命中次数，单位 （次）
        /// </summary>
        [XmlElement("hits")]
        public long Hits { get; set; }

        /// <summary>
        /// 问题id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 知识库id
        /// </summary>
        [XmlElement("library_id")]
        public long LibraryId { get; set; }

        /// <summary>
        /// 问题名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
