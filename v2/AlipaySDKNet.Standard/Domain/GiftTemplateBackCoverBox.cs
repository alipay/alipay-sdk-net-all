using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiftTemplateBackCoverBox Data Structure.
    /// </summary>
    [Serializable]
    public class GiftTemplateBackCoverBox : AopObject
    {
        /// <summary>
        /// 封底图片，用于拆包页
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 异形封底图，用于拆包页
        /// </summary>
        [XmlElement("special_shaped_url")]
        public string SpecialShapedUrl { get; set; }
    }
}
