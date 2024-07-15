using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsUsergameDataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsUsergameDataSyncModel : AopObject
    {
        /// <summary>
        /// 赛事id
        /// </summary>
        [XmlElement("game_id")]
        public string GameId { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部用户赛事编号
        /// </summary>
        [XmlElement("out_user_game_no")]
        public string OutUserGameNo { get; set; }

        /// <summary>
        /// 来源ID
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 赛事状态  FINISH 已完赛  UN_FINISH 未完赛 UNDER_WAY 进行中
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 赛事上报数据ID集合，只有完赛状态为未完赛时可空，其他场景都必填
        /// </summary>
        [XmlArray("user_game_data_id_list")]
        [XmlArrayItem("string")]
        public List<string> UserGameDataIdList { get; set; }

        /// <summary>
        /// 用户赛事ID
        /// </summary>
        [XmlElement("user_game_id")]
        public string UserGameId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
