using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TabFilterTag Data Structure.
    /// </summary>
    [Serializable]
    public class TabFilterTag : AopObject
    {
        /// <summary>
        /// id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 显示类型
        /// </summary>
        [XmlElement("show_type")]
        public string ShowType { get; set; }

        /// <summary>
        /// 文本
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
