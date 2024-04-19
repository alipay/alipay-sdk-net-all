using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceSportsOnlinegameGameSyncResponse.
    /// </summary>
    public class AlipayCommerceSportsOnlinegameGameSyncResponse : AopResponse
    {
        /// <summary>
        /// 线上赛事信息
        /// </summary>
        [XmlElement("online_game_info")]
        public OnlineGameInfo OnlineGameInfo { get; set; }
    }
}
