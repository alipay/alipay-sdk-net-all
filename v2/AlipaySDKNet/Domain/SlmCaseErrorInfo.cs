using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SlmCaseErrorInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SlmCaseErrorInfo : AopObject
    {
        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_desc")]
        public string ErrorDesc { get; set; }

        /// <summary>
        /// 错误格式
        /// </summary>
        [XmlElement("error_format")]
        public string ErrorFormat { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [XmlElement("error_info")]
        public string ErrorInfo { get; set; }

        /// <summary>
        /// 错误类型
        /// </summary>
        [XmlElement("error_type")]
        public long ErrorType { get; set; }
    }
}
