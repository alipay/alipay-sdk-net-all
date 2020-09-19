using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceAntestAppversionQueryResponse.
    /// </summary>
    public class AlipayCommerceAntestAppversionQueryResponse : AopResponse
    {
        /// <summary>
        /// 版本号
        /// </summary>
        [XmlArray("data")]
        [XmlArrayItem("string")]
        public List<string> Data { get; set; }
    }
}
