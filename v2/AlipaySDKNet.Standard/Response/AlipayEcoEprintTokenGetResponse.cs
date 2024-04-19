using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoEprintTokenGetResponse.
    /// </summary>
    public class AlipayEcoEprintTokenGetResponse : AopResponse
    {
        /// <summary>
        /// 易联云token
        /// </summary>
        [XmlElement("eprint_token")]
        public string EprintToken { get; set; }
    }
}
