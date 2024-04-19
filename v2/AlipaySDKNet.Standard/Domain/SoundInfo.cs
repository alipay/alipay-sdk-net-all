using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SoundInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SoundInfo : AopObject
    {
        /// <summary>
        /// 专辑名称
        /// </summary>
        [XmlElement("album_name")]
        public string AlbumName { get; set; }

        /// <summary>
        /// 审核失败原因，可能为空
        /// </summary>
        [XmlElement("audit_reject_desc")]
        public string AuditRejectDesc { get; set; }

        /// <summary>
        /// 声音最新版本的审核状态，可能为空
        /// </summary>
        [XmlElement("latest_audit_status")]
        public string LatestAuditStatus { get; set; }

        /// <summary>
        /// 三方专辑id
        /// </summary>
        [XmlElement("out_album_id")]
        public string OutAlbumId { get; set; }

        /// <summary>
        /// 三方声音id
        /// </summary>
        [XmlElement("out_sound_id")]
        public string OutSoundId { get; set; }

        /// <summary>
        /// 声音名称
        /// </summary>
        [XmlElement("sound_name")]
        public string SoundName { get; set; }

        /// <summary>
        /// 专辑内的声音顺序，可能被支付宝修改
        /// </summary>
        [XmlElement("sound_order")]
        public long SoundOrder { get; set; }

        /// <summary>
        /// 对C端用户展示的声音上下架状态，可能为空。仅当专辑和声音都上架的时候才返回ONLINE
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
