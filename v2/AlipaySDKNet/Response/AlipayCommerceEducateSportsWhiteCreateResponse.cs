using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateSportsWhiteCreateResponse.
    /// </summary>
    public class AlipayCommerceEducateSportsWhiteCreateResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("white_code_list")]
        [XmlArrayItem("string")]
        public List<string> WhiteCodeList { get; set; }
    }
}
