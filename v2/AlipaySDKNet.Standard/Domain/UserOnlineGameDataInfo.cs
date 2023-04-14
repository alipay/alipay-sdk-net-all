using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UserOnlineGameDataInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UserOnlineGameDataInfo : AopObject
    {
        /// <summary>
        /// 运动结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 用户外部参赛业务号
        /// </summary>
        [XmlElement("out_user_game_no")]
        public string OutUserGameNo { get; set; }

        /// <summary>
        /// 运动开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 消耗的卡路里(卡 保留五位小数)
        /// </summary>
        [XmlElement("user_data_calory")]
        public string UserDataCalory { get; set; }

        /// <summary>
        /// 消耗的时间
        /// </summary>
        [XmlElement("user_data_seconds")]
        public long UserDataSeconds { get; set; }

        /// <summary>
        /// 配速(保留五位小数)
        /// </summary>
        [XmlElement("user_data_speed")]
        public string UserDataSpeed { get; set; }

        /// <summary>
        /// 运动类型
        /// </summary>
        [XmlElement("user_data_sports_type")]
        public string UserDataSportsType { get; set; }

        /// <summary>
        /// 进度单位
        /// </summary>
        [XmlElement("user_data_unit")]
        public string UserDataUnit { get; set; }

        /// <summary>
        /// 用户完成进度值(保留两位小数)
        /// </summary>
        [XmlElement("user_data_value")]
        public string UserDataValue { get; set; }

        /// <summary>
        /// 运动侧来源ID
        /// </summary>
        [XmlElement("user_game_data_id")]
        public string UserGameDataId { get; set; }

        /// <summary>
        /// 文体侧用户参赛业务号
        /// </summary>
        [XmlElement("user_game_id")]
        public string UserGameId { get; set; }
    }
}
