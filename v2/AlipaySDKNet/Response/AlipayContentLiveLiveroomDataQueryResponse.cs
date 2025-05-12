using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayContentLiveLiveroomDataQueryResponse.
    /// </summary>
    public class AlipayContentLiveLiveroomDataQueryResponse : AopResponse
    {
        /// <summary>
        /// 直播中观看人数Uv
        /// </summary>
        [XmlElement("count_uv")]
        public long CountUv { get; set; }
    }
}
