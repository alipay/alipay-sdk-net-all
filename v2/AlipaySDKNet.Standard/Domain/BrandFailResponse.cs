using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BrandFailResponse Data Structure.
    /// </summary>
    [Serializable]
    public class BrandFailResponse : AopObject
    {
        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }
    }
}
