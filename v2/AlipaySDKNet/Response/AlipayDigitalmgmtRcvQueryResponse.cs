using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDigitalmgmtRcvQueryResponse.
    /// </summary>
    public class AlipayDigitalmgmtRcvQueryResponse : AopResponse
    {
        /// <summary>
        /// rcv详情
        /// </summary>
        [XmlElement("rcv_dto")]
        public RcvDto RcvDto { get; set; }
    }
}
