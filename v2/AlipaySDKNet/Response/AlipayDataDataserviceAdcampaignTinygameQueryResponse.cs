using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdcampaignTinygameQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdcampaignTinygameQueryResponse : AopResponse
    {
        /// <summary>
        /// 小游戏列表信息，返回商家下面可投的所有小游戏appId。若无小游戏，返回空列表
        /// </summary>
        [XmlArray("tiny_game_list")]
        [XmlArrayItem("tiny_game_res")]
        public List<TinyGameRes> TinyGameList { get; set; }
    }
}
