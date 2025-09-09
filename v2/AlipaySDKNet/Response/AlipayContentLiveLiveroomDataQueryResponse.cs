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

        /// <summary>
        /// 实时在线人数
        /// </summary>
        [XmlElement("online_uv")]
        public long OnlineUv { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        [XmlElement("praise_count")]
        public long PraiseCount { get; set; }
    }
}
