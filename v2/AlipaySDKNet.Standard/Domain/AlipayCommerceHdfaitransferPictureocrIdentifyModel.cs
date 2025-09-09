using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHdfaitransferPictureocrIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHdfaitransferPictureocrIdentifyModel : AopObject
    {
        /// <summary>
        /// 图片URL
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }
    }
}
