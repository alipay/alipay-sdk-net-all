using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TextLanguageReq Data Structure.
    /// </summary>
    [Serializable]
    public class TextLanguageReq : AopObject
    {
        /// <summary>
        /// 文案
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// zh-CN
        /// </summary>
        [XmlElement("locale")]
        public string Locale { get; set; }
    }
}
