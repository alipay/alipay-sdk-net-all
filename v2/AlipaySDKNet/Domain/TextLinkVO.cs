using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TextLinkVO Data Structure.
    /// </summary>
    [Serializable]
    public class TextLinkVO : AopObject
    {
        /// <summary>
        /// 请输入http、https或alipays开头的链接
        /// </summary>
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 字数不超过15个字
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
