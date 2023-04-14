using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ErrorCodeDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ErrorCodeDTO : AopObject
    {
        /// <summary>
        /// jsapi参数描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 错误码,SYSTEM_ERROR:系统错误
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误解决方案
        /// </summary>
        [XmlElement("solution")]
        public string Solution { get; set; }
    }
}
