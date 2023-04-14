using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInstserviceDeductConfirmResponse.
    /// </summary>
    public class AlipayEbppInstserviceDeductConfirmResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// success 成功 failure 失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
