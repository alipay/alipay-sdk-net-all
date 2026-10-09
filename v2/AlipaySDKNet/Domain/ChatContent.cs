using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatContent Data Structure.
    /// </summary>
    [Serializable]
    public class ChatContent : AopObject
    {
        /// <summary>
        /// 用户的意图问题
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
