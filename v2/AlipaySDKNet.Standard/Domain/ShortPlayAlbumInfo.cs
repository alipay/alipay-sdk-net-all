using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShortPlayAlbumInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShortPlayAlbumInfo : AopObject
    {
        /// <summary>
        /// 短剧唯一标识
        /// </summary>
        [XmlElement("album_id")]
        public string AlbumId { get; set; }

        /// <summary>
        /// 广电备案号
        /// </summary>
        [XmlElement("broadcast_record_number")]
        public string BroadcastRecordNumber { get; set; }

        /// <summary>
        /// 渠道分发状态列表。
        /// </summary>
        [XmlArray("channel_status")]
        [XmlArrayItem("short_play_channel_info")]
        public List<ShortPlayChannelInfo> ChannelStatus { get; set; }

        /// <summary>
        /// 版权材料
        /// </summary>
        [XmlElement("copyright_material")]
        public ShortPlayCopyrightMaterial CopyrightMaterial { get; set; }

        /// <summary>
        /// 封面媒资ID
        /// </summary>
        [XmlElement("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 创建时间，时间戳（秒）
        /// </summary>
        [XmlElement("create_time")]
        public long CreateTime { get; set; }

        /// <summary>
        /// 剧集列表
        /// </summary>
        [XmlArray("episode_info_list")]
        [XmlArrayItem("short_play_episode_info")]
        public List<ShortPlayEpisodeInfo> EpisodeInfoList { get; set; }

        /// <summary>
        /// 备案材料
        /// </summary>
        [XmlElement("record_material")]
        public ShortPlayRecordMaterial RecordMaterial { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("string")]
        public List<string> TagList { get; set; }

        /// <summary>
        /// 短剧名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
