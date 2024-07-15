using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsOnlinegameGameSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsOnlinegameGameSyncModel : AopObject
    {
        /// <summary>
        /// 业务类型
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
        /// 文体侧赛事业务号，由文体标志及时间戳生成
        /// </summary>
        [XmlElement("game_id")]
        public string GameId { get; set; }

        /// <summary>
        /// 赛事总进度，线上赛为M（米），步数赛为STEP(步数)
        /// </summary>
        [XmlElement("game_progress_unit")]
        public string GameProgressUnit { get; set; }

        /// <summary>
        /// 赛事总进度,线上赛单位为M，步数赛为单位STEP
        /// </summary>
        [XmlElement("game_progress_value")]
        public long GameProgressValue { get; set; }

        /// <summary>
        /// 奖牌图片链接
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
        /// 三方赛事ID(唯一值)，由三方提供值
        /// </summary>
        [XmlElement("out_game_no")]
        public string OutGameNo { get; set; }

        /// <summary>
        /// 赛事海报图片地址，图片不大于2M
        /// </summary>
        [XmlElement("poster_url")]
        public string PosterUrl { get; set; }

        /// <summary>
        /// 商品id，keep方必填，为交易组件接口返回
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 0代表上报条数无限制/1代表上报一条/n代表具体上报条数，单位为条
        /// </summary>
        [XmlElement("sports_data_limit_count")]
        public long SportsDataLimitCount { get; set; }

        /// <summary>
        /// ALIPAY_SPORTS 支付宝运动
        /// </summary>
        [XmlElement("sports_data_source")]
        public string SportsDataSource { get; set; }

        /// <summary>
        /// 运动类型
        /// </summary>
        [XmlElement("sports_data_type")]
        public string SportsDataType { get; set; }

        /// <summary>
        /// MARATHON(马拉松)
        /// </summary>
        [XmlElement("sports_type")]
        public string SportsType { get; set; }

        /// <summary>
        /// 赛事开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 状态(上线[ONLINE]/下线[OFFLINE])
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 赛事中的子业务类型(该字段目前为预留字段,供接入方需要输入额外时使用)
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }

        /// <summary>
        /// 标签列表信息
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
