using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySocialBaseLifecreationShortplayModifyResponse.
    /// </summary>
    public class AlipaySocialBaseLifecreationShortplayModifyResponse : AopResponse
    {
        /// <summary>
        /// 短剧唯一标识（剧库ID）
        /// </summary>
        [XmlElement("album_id")]
        public string AlbumId { get; set; }

        /// <summary>
        /// 新版本号（每次编辑 +1）
        /// </summary>
        [XmlElement("lib_version")]
        public string LibVersion { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [XmlElement("update_time")]
        public string UpdateTime { get; set; }
    }
}
