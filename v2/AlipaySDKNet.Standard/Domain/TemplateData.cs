using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateData Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateData : AopObject
    {
        /// <summary>
        /// 返回预期页面的数据
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 卡片id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 卡片的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
