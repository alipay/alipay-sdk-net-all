using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeApplepayAuthenticationSubmitResponse.
    /// </summary>
    public class AlipayTradeApplepayAuthenticationSubmitResponse : AopResponse
    {
        /// <summary>
        /// 核身错误信息
        /// </summary>
        [XmlElement("authentication_error")]
        public string AuthenticationError { get; set; }

        /// <summary>
        /// 失败时的鉴权重试机制
        /// </summary>
        [XmlArray("fallback_authentication_mechanisms")]
        [XmlArrayItem("string")]
        public List<string> FallbackAuthenticationMechanisms { get; set; }

        /// <summary>
        /// applePay公用响应头
        /// </summary>
        [XmlElement("response_header")]
        public OpenApiResponseHeader ResponseHeader { get; set; }

        /// <summary>
        /// 鉴权重试机制
        /// </summary>
        [XmlArray("retry_authentication_mechanisms")]
        [XmlArrayItem("string")]
        public List<string> RetryAuthenticationMechanisms { get; set; }

        /// <summary>
        /// base64之后的证书
        /// </summary>
        [XmlElement("signing_certificate")]
        public string SigningCertificate { get; set; }

        /// <summary>
        /// 最新的鉴权明细信息
        /// </summary>
        [XmlElement("updated_authentication_details")]
        public UpdatedAuthenticationDetails UpdatedAuthenticationDetails { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [XmlElement("updated_transaction_status")]
        public string UpdatedTransactionStatus { get; set; }
    }
}
