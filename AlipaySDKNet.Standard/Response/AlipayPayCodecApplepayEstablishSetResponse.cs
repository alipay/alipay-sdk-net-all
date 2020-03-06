using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayCodecApplepayEstablishSetResponse.
    /// </summary>
    public class AlipayPayCodecApplepayEstablishSetResponse : AopResponse
    {
        /// <summary>
        /// 结果。 statusCode:Status code used to indicate an error. If omitted, assumed to be 200 (success);subStatusCode:Conveys failure codes from downstream entities or for more granular conveyance of specific error conditions;statusMessage:Not parsed programmatically. Example "Downstream system offline".
        /// </summary>
        [XmlElement("response_header")]
        public EstablishResponseHeader ResponseHeader { get; set; }
    }
}
