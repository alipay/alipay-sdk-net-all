using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RemindVO Data Structure.
    /// </summary>
    [Serializable]
    public class RemindVO : AopObject
    {
        /// <summary>
        /// 提醒内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 提醒名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 提醒标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
