using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudCloudpromoScenicInfoQueryResponse.
    /// </summary>
    public class AlipayCloudCloudpromoScenicInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 租户ID
        /// </summary>
        [XmlElement("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 音频介绍卡片1
        /// </summary>
        [XmlElement("audio_card_vo")]
        public ScenicAudioCardDTO AudioCardVo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("cdn_video_url")]
        [XmlArrayItem("string")]
        public List<string> CdnVideoUrl { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("fun_exploration")]
        [XmlArrayItem("string")]
        public List<string> FunExploration { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("historical_curiosities")]
        [XmlArrayItem("string")]
        public List<string> HistoricalCuriosities { get; set; }

        /// <summary>
        /// 印记
        /// </summary>
        [XmlElement("mark_vo")]
        public MarkDTO MarkVo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("photo_suggest_image_list")]
        [XmlArrayItem("string")]
        public List<string> PhotoSuggestImageList { get; set; }

        /// <summary>
        /// 场景id
        /// </summary>
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 景区基础信息
        /// </summary>
        [XmlElement("scenic_base_vo")]
        public ScenicAllBaseDTO ScenicBaseVo { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("suggest_scenic_vos")]
        [XmlArrayItem("suggest_scenic_v_o")]
        public List<SuggestScenicVO> SuggestScenicVos { get; set; }
    }
}
