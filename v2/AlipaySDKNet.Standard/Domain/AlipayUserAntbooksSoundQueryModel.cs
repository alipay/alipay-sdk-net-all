using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserAntbooksSoundQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntbooksSoundQueryModel : AopObject
    {
        /// <summary>
        /// 最新版本审核状态，用做过滤。如果传入AUDIT_REJECT，则只返回审核失败的声音
        /// </summary>
        [XmlElement("latest_audit_status")]
        public string LatestAuditStatus { get; set; }

        /// <summary>
        /// 三方专辑id列表，长度不能超过20。如果传入，则只返回输入专辑ID的声音信息。soundIdList和albumId不能同时为空
        /// </summary>
        [XmlElement("out_album_id")]
        public string OutAlbumId { get; set; }

        /// <summary>
        /// 三方声音id列表，长度不能超过20。如果传入，则只返回输入id列表范围内的声音信息。soundIdList和albumId不能同时为空
        /// </summary>
        [XmlArray("out_sound_id_list")]
        [XmlArrayItem("string")]
        public List<string> OutSoundIdList { get; set; }

        /// <summary>
        /// 从1开始，默认为1。如果传入albumId，分页查询声音
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 默认为20。如果传入albumId，分页查询声音
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
