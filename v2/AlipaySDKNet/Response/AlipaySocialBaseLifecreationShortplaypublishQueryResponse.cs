using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseLifecreationShortplaypublishQueryResponse.
    /// </summary>
    public class AlipaySocialBaseLifecreationShortplaypublishQueryResponse : AopResponse
    {
        /// <summary>
        /// 短剧 ID（剧库ID）
        /// </summary>
        [XmlElement("album_id")]
        public string AlbumId { get; set; }

        /// <summary>
        /// 渠道发布结果
        /// </summary>
        [XmlArray("publish_info_list")]
        [XmlArrayItem("short_play_channel_info")]
        public List<ShortPlayChannelInfo> PublishInfoList { get; set; }
    }
}
