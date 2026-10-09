using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionISVOrderStatusDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionISVOrderStatusDTO : AopObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [XmlElement("status_desc")]
        public string StatusDesc { get; set; }
    }
}
