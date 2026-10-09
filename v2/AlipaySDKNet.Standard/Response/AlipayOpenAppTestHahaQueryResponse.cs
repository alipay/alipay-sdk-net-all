using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppTestHahaQueryResponse.
    /// </summary>
    public class AlipayOpenAppTestHahaQueryResponse : AopResponse
    {
        /// <summary>
        /// 2088
        /// </summary>
        [XmlElement("out_one")]
        public string OutOne { get; set; }

        /// <summary>
        /// 20881234
        /// </summary>
        [XmlElement("out_two")]
        public string OutTwo { get; set; }
    }
}
