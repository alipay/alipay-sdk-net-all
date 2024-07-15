using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OnlineGameInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OnlineGameInfo : AopObject
    {
        /// <summary>
        /// 赛事类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 金秋跑出风采
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 参赛详情支付宝小程序跳转地址
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 赛事结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 环境参数 TEST(测试数据)/PROD(正式数据)
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// 文体侧赛事业务号
        /// </summary>
        [XmlElement("game_id")]
        public string GameId { get; set; }

        /// <summary>
        /// 赛事总进度，线上赛为M（米），步数赛为STEP(步数)
        /// </summary>
        [XmlElement("game_progress_unit")]
        public string GameProgressUnit { get; set; }

        /// <summary>
        /// 赛事总进度，线上赛为M（米），步数赛为STEP(步数)
        /// </summary>
        [XmlElement("game_progress_value")]
        public long GameProgressValue { get; set; }

        /// <summary>
        /// 奖牌图片
        /// </summary>
        [XmlElement("medal_image")]
        public string MedalImage { get; set; }

        /// <summary>
        /// 2022跑遍中国-乐享中秋跑量挑战赛
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 线上赛事场次组别信息列表
        /// </summary>
        [XmlArray("online_game_event_list")]
        [XmlArrayItem("online_game_event_info")]
        public List<OnlineGameEventInfo> OnlineGameEventList { get; set; }

        /// <summary>
        /// 三方赛事ID(唯一值)
        /// </summary>
        [XmlElement("out_game_no")]
        public string OutGameNo { get; set; }

        /// <summary>
        /// 中田赛事海报图片
        /// </summary>
        [XmlElement("poster_url")]
        public string PosterUrl { get; set; }

        /// <summary>
        /// 0代表上报条数无限制/1代表上报一条/n代表具体上报条数，n可为任意整数，单位为条
        /// </summary>
        [XmlElement("sports_data_limit_count")]
        public string SportsDataLimitCount { get; set; }

        /// <summary>
        /// 运动类型 ALIPAY_SPORTS 支付宝运动
        /// </summary>
        [XmlElement("sports_data_source")]
        public string SportsDataSource { get; set; }

        /// <summary>
        /// run跑步 walk走路  ride骑行
        /// </summary>
        [XmlElement("sports_data_type")]
        public string SportsDataType { get; set; }

        /// <summary>
        /// MARATHON 马拉松
        /// </summary>
        [XmlElement("sports_type")]
        public string SportsType { get; set; }

        /// <summary>
        /// 赛事开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 赛事状态 ONLINE上线  OFFLINE下线
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 比如交互中提到的赛组，目前未使用
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("string")]
        public List<string> TagList { get; set; }

        /// <summary>
        /// 用户参赛结束时间
        /// </summary>
        [XmlElement("user_join_end_time")]
        public string UserJoinEndTime { get; set; }

        /// <summary>
        /// 用户参赛时间
        /// </summary>
        [XmlElement("user_join_start_time")]
        public string UserJoinStartTime { get; set; }
    }
}
