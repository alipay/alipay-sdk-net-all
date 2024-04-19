using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInstserviceDeductSignResponse.
    /// </summary>
    public class AlipayEbppInstserviceDeductSignResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 流程ID用于校验
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }
    }
}
