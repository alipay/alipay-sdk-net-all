using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenDanielTestQueryResponse.
    /// </summary>
    public class AlipayOpenDanielTestQueryResponse : AopResponse
    {
        /// <summary>
        /// 21
        /// </summary>
        [XmlElement("out_put")]
        public string OutPut { get; set; }
    }
}
