using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductSize Data Structure.
    /// </summary>
    [Serializable]
    public class ProductSize : AopObject
    {
        /// <summary>
        /// 商品深度
        /// </summary>
        [XmlElement("product_deep")]
        public string ProductDeep { get; set; }

        /// <summary>
        /// 商品的高度
        /// </summary>
        [XmlElement("product_height")]
        public string ProductHeight { get; set; }

        /// <summary>
        /// 商品宽度
        /// </summary>
        [XmlElement("product_width")]
        public string ProductWidth { get; set; }
    }
}
