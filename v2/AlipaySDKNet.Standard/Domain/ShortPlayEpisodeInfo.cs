using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ShortPlayEpisodeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShortPlayEpisodeInfo : AopObject
    {
        /// <summary>
        /// 剧集封面媒资ID（支付宝上传接口返回的 file_id）
        /// </summary>
        [XmlElement("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 剧集视频媒资ID（支付宝上传接口返回的 file_id）
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 集数序号，要求从 1 开始连贯递增，最大序号等于总集数。
        /// </summary>
        [XmlElement("seq")]
        public long Seq { get; set; }

        /// <summary>
        /// 剧集标题，最多30个字。
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
