using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceSportsOnlinegameUsergamedataQueryResponse.
    /// </summary>
    public class AlipayCommerceSportsOnlinegameUsergamedataQueryResponse : AopResponse
    {
        /// <summary>
        /// 分页接口，是否有更多数据，还有数据返回true，否则返回false
        /// </summary>
        [XmlElement("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 用户参赛数据信息
        /// </summary>
        [XmlArray("user_online_game_data_info_list")]
        [XmlArrayItem("user_online_game_data_info")]
        public List<UserOnlineGameDataInfo> UserOnlineGameDataInfoList { get; set; }
    }
}
