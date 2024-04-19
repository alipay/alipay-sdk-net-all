using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiftTemplateFrontCoverBox Data Structure.
    /// </summary>
    [Serializable]
    public class GiftTemplateFrontCoverBox : AopObject
    {
        /// <summary>
        /// 封面图，使用于在拆红包页、红包详情页
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 异形封面图
        /// </summary>
        [XmlElement("special_shaped_url")]
        public string SpecialShapedUrl { get; set; }

        /// <summary>
        /// 封面视频，使用在拆红包页与红包详情页
        /// </summary>
        [XmlElement("video_url")]
        public string VideoUrl { get; set; }
    }
}
