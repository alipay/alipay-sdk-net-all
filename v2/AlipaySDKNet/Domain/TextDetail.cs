using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TextDetail Data Structure.
    /// </summary>
    [Serializable]
    public class TextDetail : AopObject
    {
        /// <summary>
        /// 文本类型内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
