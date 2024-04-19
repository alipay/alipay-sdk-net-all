using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CloudbusCommonResult Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusCommonResult : AopObject
    {
        /// <summary>
        /// 返回码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 数据字符
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 返回码描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
