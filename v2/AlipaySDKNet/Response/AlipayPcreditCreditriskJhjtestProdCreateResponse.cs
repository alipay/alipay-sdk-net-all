using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditCreditriskJhjtestProdCreateResponse.
    /// </summary>
    public class AlipayPcreditCreditriskJhjtestProdCreateResponse : AopResponse
    {
        /// <summary>
        /// 1111
        /// </summary>
        [XmlElement("out_a")]
        public string OutA { get; set; }
    }
}
