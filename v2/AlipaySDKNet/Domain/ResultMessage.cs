using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResultMessage Data Structure.
    /// </summary>
    [Serializable]
    public class ResultMessage : AopObject
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
        /// 调用结果
        /// </summary>
        [XmlElement("result_flag")]
        public bool ResultFlag { get; set; }
    }
}
