using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseLifecreationShortplayModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseLifecreationShortplayModifyModel : AopObject
    {
        /// <summary>
        /// 短剧唯一标识（剧库ID）
        /// </summary>
        [XmlElement("album_id")]
        public string AlbumId { get; set; }

        /// <summary>
        /// 封面媒资ID
        /// </summary>
        [XmlElement("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 剧集信息。如果不修改剧集信息，无需传入
        /// </summary>
        [XmlArray("episode_info_list")]
        [XmlArrayItem("short_play_episode_info")]
        public List<ShortPlayEpisodeInfo> EpisodeInfoList { get; set; }

        /// <summary>
        /// 备案材料 注意： 短剧审核通过后，将不可修改
        /// </summary>
        [XmlElement("record_material")]
        public ShortPlayRecordMaterial RecordMaterial { get; set; }

        /// <summary>
        /// 标签列表，如 ["甜宠", "逆袭", "都市"]
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("string")]
        public List<string> TagList { get; set; }

        /// <summary>
        /// 短剧名称，2~20 个字（英文和符号计 0.5 字）
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
