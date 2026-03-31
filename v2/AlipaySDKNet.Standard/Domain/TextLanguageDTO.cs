using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TextLanguageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TextLanguageDTO : AopObject
    {
        /// <summary>
        /// 文案
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 语种
        /// </summary>
        [XmlElement("locale")]
        public string Locale { get; set; }
    }
}
