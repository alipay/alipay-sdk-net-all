using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayCodecApplepayCredentialsGetResponse.
    /// </summary>
    public class AlipayPayCodecApplepayCredentialsGetResponse : AopResponse
    {
        /// <summary>
        /// 加密后的码列表。 {List of Credential objects}
        /// </summary>
        [XmlArray("credentials")]
        [XmlArrayItem("payment_credential")]
        public List<PaymentCredential> Credentials { get; set; }

        /// <summary>
        /// 结果。 statusCode:Status code used to indicate an error. If omitted, assumed to be 200 (success);subStatusCode:Conveys failure codes from downstream entities or for more granular conveyance of specific error conditions;statusMessage:Not parsed programmatically. Example "Downstream system offline".
        /// </summary>
        [XmlElement("response_header")]
        public CredentialsResponseHeader ResponseHeader { get; set; }
    }
}
