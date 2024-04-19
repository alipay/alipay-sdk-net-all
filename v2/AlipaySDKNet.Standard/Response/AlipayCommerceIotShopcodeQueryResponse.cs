using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotShopcodeQueryResponse.
    /// </summary>
    public class AlipayCommerceIotShopcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 投放状态，已投放（on），未投放（off）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
