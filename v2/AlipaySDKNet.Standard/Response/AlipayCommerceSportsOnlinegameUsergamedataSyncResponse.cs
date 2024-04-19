using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceSportsOnlinegameUsergamedataSyncResponse.
    /// </summary>
    public class AlipayCommerceSportsOnlinegameUsergamedataSyncResponse : AopResponse
    {
        /// <summary>
        /// 用户参赛数据信息
        /// </summary>
        [XmlArray("user_online_game_data_info_list")]
        [XmlArrayItem("user_online_game_data_info")]
        public List<UserOnlineGameDataInfo> UserOnlineGameDataInfoList { get; set; }
    }
}
