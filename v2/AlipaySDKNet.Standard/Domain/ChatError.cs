using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ChatError Data Structure.
    /// </summary>
    [Serializable]
    public class ChatError : AopObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
