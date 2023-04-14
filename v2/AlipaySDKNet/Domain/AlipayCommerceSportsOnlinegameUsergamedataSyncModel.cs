using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsOnlinegameUsergamedataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsOnlinegameUsergamedataSyncModel : AopObject
    {
        /// <summary>
        /// 运动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 三方用户赛事业务号
        /// </summary>
        [XmlElement("out_user_game_no")]
        public string OutUserGameNo { get; set; }

        /// <summary>
        /// 运动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 文体侧用户赛事业务号
        /// </summary>
        [XmlElement("user_game_id")]
        public string UserGameId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
