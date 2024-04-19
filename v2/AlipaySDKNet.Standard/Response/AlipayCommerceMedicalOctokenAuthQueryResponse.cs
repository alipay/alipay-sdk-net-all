using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalOctokenAuthQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalOctokenAuthQueryResponse : AopResponse
    {
        /// <summary>
        /// 医保电子凭证线上支付授权信息
        /// </summary>
        [XmlElement("data")]
        public MedicalOnlinePayAuthInfo Data { get; set; }

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
    }
}
