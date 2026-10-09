using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseLifecreationShortplayPublishResponse.
    /// </summary>
    public class AlipaySocialBaseLifecreationShortplayPublishResponse : AopResponse
    {
        /// <summary>
        /// 短剧唯一标识（剧库ID）
        /// </summary>
        [XmlElement("album_id")]
        public string AlbumId { get; set; }

        /// <summary>
        /// 短剧发布渠道信息
        /// </summary>
        [XmlArray("publish_channel_info_list")]
        [XmlArrayItem("short_play_publish_channel_info")]
        public List<ShortPlayPublishChannelInfo> PublishChannelInfoList { get; set; }
    }
}
