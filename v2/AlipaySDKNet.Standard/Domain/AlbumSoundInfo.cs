using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlbumSoundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlbumSoundInfo : AopObject
    {
        /// <summary>
        /// 该声音完整播放时长，单位秒
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 若声音支持试听，该字段传入可试听时长，单位秒
        /// </summary>
        [XmlElement("sample_duration")]
        public long SampleDuration { get; set; }

        /// <summary>
        /// 收费专辑必传，该字段表示收费专辑下，声音是否可免费完整畅听。（例如前3集可免费听）
        /// </summary>
        [XmlElement("sound_free")]
        public bool SoundFree { get; set; }

        /// <summary>
        /// 声音ID，合作方内部可唯一标识一个声音。
        /// </summary>
        [XmlElement("sound_id")]
        public string SoundId { get; set; }

        /// <summary>
        /// 声音名称，可对C端用户展示
        /// </summary>
        [XmlElement("sound_name")]
        public string SoundName { get; set; }

        /// <summary>
        /// 1，默认ADD，专辑新增录入时可不填 2，仅用于专辑内声音变更时传入，例如专辑A内声音1需删除，则album_operate_type传入UPDATE，sound_operate_type传入DELETE，同时传入sound_id=1；
        /// </summary>
        [XmlElement("sound_operate_type")]
        public string SoundOperateType { get; set; }

        /// <summary>
        /// 专辑内声音排序，数字越小越靠前。
        /// </summary>
        [XmlElement("sound_order")]
        public long SoundOrder { get; set; }

        /// <summary>
        /// 声音标签列表，有则填入
        /// </summary>
        [XmlArray("sound_tags")]
        [XmlArrayItem("string")]
        public List<string> SoundTags { get; set; }

        /// <summary>
        /// 收费专辑必填，该字段表示收费专辑下，未购买的声音是否支持试听（例如试听2分钟）
        /// </summary>
        [XmlElement("support_sample")]
        public bool SupportSample { get; set; }
    }
}
