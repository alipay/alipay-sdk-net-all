using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResourceAihrInterviewProcessQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ResourceAihrInterviewProcessQueryModel : AopObject
    {
        /// <summary>
        /// 固定值，对应系统租户
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 流程名称关键字，用于模糊匹配
        /// </summary>
        [XmlElement("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 从1开始，默认为1
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 默认为10，最大100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
