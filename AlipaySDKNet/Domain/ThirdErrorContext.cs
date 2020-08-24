using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ThirdErrorContext Data Structure.
    /// </summary>
    [Serializable]
    public class ThirdErrorContext : AopObject
    {
        /// <summary>
        /// 支付宝三代错误码内部值
        /// </summary>
        [XmlElement("third_error_code")]
        public string ThirdErrorCode { get; set; }

        /// <summary>
        /// thirdErrorCode的错误描述
        /// </summary>
        [XmlElement("third_error_msg")]
        public string ThirdErrorMsg { get; set; }
    }
}
