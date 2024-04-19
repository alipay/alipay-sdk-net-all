using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaTorchreplayleftoffliQueryResponse.
    /// </summary>
    public class AlipayDataMdaTorchreplayleftoffliQueryResponse : AopResponse
    {
        /// <summary>
        /// 分享亚运精神用户数
        /// </summary>
        [XmlElement("share_asian_games_spirit_cnt")]
        public long ShareAsianGamesSpiritCnt { get; set; }

        /// <summary>
        /// 取火用户数
        /// </summary>
        [XmlElement("take_flame_cnt")]
        public long TakeFlameCnt { get; set; }
    }
}
