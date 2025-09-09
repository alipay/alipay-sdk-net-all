using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FastAuditTaskInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class FastAuditTaskInfoVO : AopObject
    {
        /// <summary>
        /// 审核任务内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 审核任务类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
