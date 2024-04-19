using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalShortenurlExchangeResponse.
    /// </summary>
    public class AlipayCommerceMedicalShortenurlExchangeResponse : AopResponse
    {
        /// <summary>
        /// 业务错误描述
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 业务结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 短链
        /// </summary>
        [XmlElement("shorten_url")]
        public string ShortenUrl { get; set; }
    }
}
