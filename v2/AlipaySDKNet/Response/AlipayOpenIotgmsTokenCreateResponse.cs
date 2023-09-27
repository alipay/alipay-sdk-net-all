using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenIotgmsTokenCreateResponse.
    /// </summary>
    public class AlipayOpenIotgmsTokenCreateResponse : AopResponse
    {
        /// <summary>
        /// 查询token，符合jwt标准
        /// </summary>
        [XmlElement("query_token")]
        public string QueryToken { get; set; }
    }
}
