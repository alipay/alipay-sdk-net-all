using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInspectSessionQueryResponse.
    /// </summary>
    public class AlipayEbppInspectSessionQueryResponse : AopResponse
    {
        /// <summary>
        /// 登录ID
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
