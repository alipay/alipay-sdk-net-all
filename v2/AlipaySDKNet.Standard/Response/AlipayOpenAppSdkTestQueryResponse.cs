using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppSdkTestQueryResponse.
    /// </summary>
    public class AlipayOpenAppSdkTestQueryResponse : AopResponse
    {
        /// <summary>
        /// 123
        /// </summary>
        [XmlElement("str_out")]
        public string StrOut { get; set; }
    }
}
