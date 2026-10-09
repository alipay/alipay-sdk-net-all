using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySocialBaseLifecreationShortplayPublishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseLifecreationShortplayPublishModel : AopObject
    {
        /// <summary>
        /// 短剧唯一标识（剧库ID）
        /// </summary>
        [XmlElement("album_id")]
        public string AlbumId { get; set; }

        /// <summary>
        /// 广电备案号。三方渠道版审送审时必填
        /// </summary>
        [XmlElement("broadcast_record_number")]
        public string BroadcastRecordNumber { get; set; }

        /// <summary>
        /// 渠道：0 商家小程序；1 生活号； 必填，会同时发布所有已发布的渠道；
        /// </summary>
        [XmlArray("channels")]
        [XmlArrayItem("string")]
        public List<string> Channels { get; set; }

        /// <summary>
        /// 版权材料
        /// </summary>
        [XmlElement("copyright_material")]
        public ShortPlayCopyrightMaterial CopyrightMaterial { get; set; }

        /// <summary>
        /// 生活号id，渠道为生活号必填
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }
    }
}
