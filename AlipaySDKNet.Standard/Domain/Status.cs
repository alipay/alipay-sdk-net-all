using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Status Data Structure.
    /// </summary>
    [Serializable]
    public class Status : AopObject
    {
        /// <summary>
        /// 状态码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 详细信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
