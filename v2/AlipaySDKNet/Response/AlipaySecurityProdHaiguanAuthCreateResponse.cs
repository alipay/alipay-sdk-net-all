using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdHaiguanAuthCreateResponse.
    /// </summary>
    public class AlipaySecurityProdHaiguanAuthCreateResponse : AopResponse
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("out_one")]
        public string OutOne { get; set; }

        /// <summary>
        /// 33
        /// </summary>
        [XmlElement("out_three")]
        public string OutThree { get; set; }

        /// <summary>
        /// 23
        /// </summary>
        [XmlElement("out_two")]
        public string OutTwo { get; set; }
    }
}
