using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseLifecreationShortplayCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseLifecreationShortplayCreateModel : AopObject
    {
        /// <summary>
        /// 广电备案号。 真人制作费用 ≥ 100 万，或 AI/动画类制作费用 ≥ 30 万时 必填 上线商家小程序 必填 注意：备案号有值提交后，将不可修改
        /// </summary>
        [XmlElement("broadcast_record_number")]
        public string BroadcastRecordNumber { get; set; }

        /// <summary>
        /// 封面媒资ID（支付宝 alipay.open.file.upload 接口返回的 file_id）
        /// </summary>
        [XmlElement("cover")]
        public string Cover { get; set; }

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
