using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResponseContent Data Structure.
    /// </summary>
    [Serializable]
    public class ResponseContent : AopObject
    {
        /// <summary>
        /// 模型的响应具体内容
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
