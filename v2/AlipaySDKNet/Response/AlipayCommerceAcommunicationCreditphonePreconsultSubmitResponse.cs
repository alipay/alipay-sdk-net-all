using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphonePreconsultSubmitResponse.
    /// </summary>
    public class AlipayCommerceAcommunicationCreditphonePreconsultSubmitResponse : AopResponse
    {
        /// <summary>
        /// 请求流水号（代表受理）
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }
    }
}
