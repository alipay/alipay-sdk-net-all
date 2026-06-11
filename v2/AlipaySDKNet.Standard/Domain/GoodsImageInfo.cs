using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GoodsImageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class GoodsImageInfo : AopObject
    {
        /// <summary>
        /// 图片地址
        /// </summary>
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 展示图位置
        /// </summary>
        [XmlElement("sort")]
        public string Sort { get; set; }
    }
}
