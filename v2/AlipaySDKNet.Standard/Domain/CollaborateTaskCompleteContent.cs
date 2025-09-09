using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CollaborateTaskCompleteContent Data Structure.
    /// </summary>
    [Serializable]
    public class CollaborateTaskCompleteContent : AopObject
    {
        /// <summary>
        /// 完成任务以后，反馈内容的类型。
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 完成任务以后反馈内容的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
