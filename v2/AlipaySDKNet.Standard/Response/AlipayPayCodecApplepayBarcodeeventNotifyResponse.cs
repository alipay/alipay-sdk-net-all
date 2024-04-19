using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayCodecApplepayBarcodeeventNotifyResponse.
    /// </summary>
    public class AlipayPayCodecApplepayBarcodeeventNotifyResponse : AopResponse
    {
        /// <summary>
        /// 结果。 statusCode:Status code used to indicate an error. If omitted, assumed to be 200 (success);subStatusCode:Conveys failure codes from downstream entities or for more granular conveyance of specific error conditions;statusMessage:Not parsed programmatically. Example "Downstream system offline".
        /// </summary>
        [XmlElement("response_header")]
        public BarcodeEventResponseHeader ResponseHeader { get; set; }

        /// <summary>
        /// 当前付款码是否有交易发生。
        /// </summary>
        [XmlElement("transaction_available")]
        public string TransactionAvailable { get; set; }
    }
}
