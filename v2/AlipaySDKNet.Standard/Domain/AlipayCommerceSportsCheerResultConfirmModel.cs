using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsCheerResultConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsCheerResultConfirmModel : AopObject
    {
        /// <summary>
        /// 用户助威记录流水号
        /// </summary>
        [XmlElement("game_serial_number")]
        public string GameSerialNumber { get; set; }

        /// <summary>
        /// 用户是否助威游戏胜利
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 游戏中另一支队伍得分
        /// </summary>
        [XmlElement("other_team_score")]
        public long OtherTeamScore { get; set; }

        /// <summary>
        /// 用户所支持队伍得分
        /// </summary>
        [XmlElement("user_team_score")]
        public long UserTeamScore { get; set; }
    }
}
