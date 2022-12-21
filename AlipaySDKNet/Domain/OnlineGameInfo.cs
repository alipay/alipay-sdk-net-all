using System;
using System.Xml.Serialization;

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
        /// 赛事结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 文体侧赛事业务号
        /// </summary>
        [XmlElement("game_id")]
        public string GameId { get; set; }

        /// <summary>
        /// 配合赛事总进度使用
        /// </summary>
        [XmlElement("game_progress_unit")]
        public string GameProgressUnit { get; set; }

        /// <summary>
        /// 赛事总进度
        /// </summary>
        [XmlElement("game_progress_value")]
        public long GameProgressValue { get; set; }

        /// <summary>
        /// 2022跑遍中国-乐享中秋跑量挑战赛
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

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
        /// 0代表上报条数无限制/1代表上报一条/n代表具体上报条数
        /// </summary>
        [XmlElement("sports_data_limit_count")]
        public string SportsDataLimitCount { get; set; }

        /// <summary>
        /// 支付宝运动
        /// </summary>
        [XmlElement("sports_data_source")]
        public string SportsDataSource { get; set; }

        /// <summary>
        /// 跑步
        /// </summary>
        [XmlElement("sports_data_type")]
        public string SportsDataType { get; set; }

        /// <summary>
        /// 赛事开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 上线
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 比如交互中提到的赛组
        /// </summary>
        [XmlElement("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
