using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInstserviceDeductPayResponse.
    /// </summary>
    public class AlipayEbppInstserviceDeductPayResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// true代表受理成功 false代表受理失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
