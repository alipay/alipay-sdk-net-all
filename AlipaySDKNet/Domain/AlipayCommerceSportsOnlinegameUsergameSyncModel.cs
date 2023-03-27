using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsOnlinegameUsergameSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsOnlinegameUsergameSyncModel : AopObject
    {
        /// <summary>
        /// 用户参赛的场次组别ID
        /// </summary>
        [XmlElement("game_event_id")]
        public string GameEventId { get; set; }

        /// <summary>
        /// 文体侧赛事业务号
        /// </summary>
        [XmlElement("game_id")]
        public string GameId { get; set; }

        /// <summary>
        /// 用户参加比赛完成时间
        /// </summary>
        [XmlElement("gmt_complete")]
        public string GmtComplete { get; set; }

        /// <summary>
        /// 用户参加比赛开始时间
        /// </summary>
        [XmlElement("gmt_join")]
        public string GmtJoin { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户参赛的服务商场次组别ID
        /// </summary>
        [XmlElement("out_game_event_no")]
        public string OutGameEventNo { get; set; }

        /// <summary>
        /// 外部赛事业务号
        /// </summary>
        [XmlElement("out_game_no")]
        public string OutGameNo { get; set; }

        /// <summary>
        /// 用户报名赛事业务号
        /// </summary>
        [XmlElement("out_user_game_no")]
        public string OutUserGameNo { get; set; }

        /// <summary>
        /// JOIN("JOIN", "已参加"), COMPLETED("COMPLETED", "已完成"), STOPPED("STOPPED", "未完成"),
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 文体侧用户赛事信息业务号
        /// </summary>
        [XmlElement("user_game_id")]
        public string UserGameId { get; set; }

        /// <summary>
        /// 用户参赛号码牌
        /// </summary>
        [XmlElement("user_game_plate")]
        public string UserGamePlate { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 个人赛
        /// </summary>
        [XmlElement("user_join_type")]
        public string UserJoinType { get; set; }

        /// <summary>
        /// 用户昵称(可空 为空默认取支付宝用户昵称)
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户参赛详情支付宝小程序跳转地址
        /// </summary>
        [XmlElement("user_online_detail_url")]
        public string UserOnlineDetailUrl { get; set; }
    }
}
