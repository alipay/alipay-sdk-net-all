using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// IcommunityContentMediaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IcommunityContentMediaInfo : AopObject
    {
        /// <summary>
        /// 视频资源的封面图片的资源id
        /// </summary>
        [XmlElement("cover_img_src")]
        public string CoverImgSrc { get; set; }

        /// <summary>
        /// 关联资源的高度，单位px
        /// </summary>
        [XmlElement("media_content_height")]
        public long MediaContentHeight { get; set; }

        /// <summary>
        /// 关联资源的宽度，单位px
        /// </summary>
        [XmlElement("media_content_width")]
        public long MediaContentWidth { get; set; }

        /// <summary>
        /// 媒体内容资源id
        /// </summary>
        [XmlElement("media_src")]
        public string MediaSrc { get; set; }

        /// <summary>
        /// 内容关联的媒体类型 1."image"表示图片类型 2."video"表示视频类型
        /// </summary>
        [XmlElement("media_type")]
        public string MediaType { get; set; }
    }
}
