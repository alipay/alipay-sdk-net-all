using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdHaiguanNoauthCreateResponse.
    /// </summary>
    public class AlipaySecurityProdHaiguanNoauthCreateResponse : AopResponse
    {
        /// <summary>
        /// 23
        /// </summary>
        [XmlElement("out_one")]
        public string OutOne { get; set; }

        /// <summary>
        /// 23
        /// </summary>
        [XmlElement("out_three")]
        public string OutThree { get; set; }

        /// <summary>
        /// 32
        /// </summary>
        [XmlArray("out_two")]
        [XmlArrayItem("string")]
        public List<string> OutTwo { get; set; }
    }
}
