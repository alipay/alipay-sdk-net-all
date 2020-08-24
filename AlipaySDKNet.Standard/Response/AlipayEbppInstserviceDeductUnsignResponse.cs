using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInstserviceDeductUnsignResponse.
    /// </summary>
    public class AlipayEbppInstserviceDeductUnsignResponse : AopResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 流程id
        /// </summary>
        [XmlElement("process_id")]
        public string ProcessId { get; set; }
    }
}
