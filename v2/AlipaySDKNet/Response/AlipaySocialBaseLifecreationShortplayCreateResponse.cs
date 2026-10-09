using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseLifecreationShortplayCreateResponse.
    /// </summary>
    public class AlipaySocialBaseLifecreationShortplayCreateResponse : AopResponse
    {
        /// <summary>
        /// 短剧唯一标识（剧库ID）
        /// </summary>
        [XmlElement("album_id")]
        public string AlbumId { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [XmlElement("lib_version")]
        public long LibVersion { get; set; }
    }
}
