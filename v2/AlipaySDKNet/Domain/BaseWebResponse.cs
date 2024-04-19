using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BaseWebResponse Data Structure.
    /// </summary>
    [Serializable]
    public class BaseWebResponse : AopObject
    {
        /// <summary>
        /// response code
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 返回错误信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
