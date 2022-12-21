using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsInsmopRetainQueryResponse.
    /// </summary>
    public class AlipayInsInsmopRetainQueryResponse : AopResponse
    {
        /// <summary>
        /// 通行证信息
        /// </summary>
        [XmlElement("pass_token")]
        public string PassToken { get; set; }
    }
}
