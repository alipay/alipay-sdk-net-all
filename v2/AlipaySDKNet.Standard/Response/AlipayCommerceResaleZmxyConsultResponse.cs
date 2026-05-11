using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceResaleZmxyConsultResponse.
    /// </summary>
    public class AlipayCommerceResaleZmxyConsultResponse : AopResponse
    {
        /// <summary>
        /// 是否准入
        /// </summary>
        [XmlElement("permit")]
        public bool Permit { get; set; }
    }
}
