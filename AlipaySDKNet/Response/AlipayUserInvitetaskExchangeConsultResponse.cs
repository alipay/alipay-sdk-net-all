using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserInvitetaskExchangeConsultResponse.
    /// </summary>
    public class AlipayUserInvitetaskExchangeConsultResponse : AopResponse
    {
        /// <summary>
        /// true--有兑换资格  false--无兑换资格
        /// </summary>
        [XmlElement("consult_result")]
        public bool ConsultResult { get; set; }
    }
}
