using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// YpzAfuDownloadCardOne Data Structure.
    /// </summary>
    [Serializable]
    public class YpzAfuDownloadCardOne : AopObject
    {
        /// <summary>
        /// 图片URL
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 跳转URL
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
