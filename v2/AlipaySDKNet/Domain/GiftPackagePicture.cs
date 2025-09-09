using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GiftPackagePicture Data Structure.
    /// </summary>
    [Serializable]
    public class GiftPackagePicture : AopObject
    {
        /// <summary>
        /// 礼包套餐图片顺序，树脂越小，越靠前显示
        /// </summary>
        [XmlElement("img_index")]
        public long ImgIndex { get; set; }

        /// <summary>
        /// 礼包套餐图片地址
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }
    }
}
