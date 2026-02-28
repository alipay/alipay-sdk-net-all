using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ProductDetail : AopObject
    {
        /// <summary>
        /// 产品开通明细编码
        /// </summary>
        [XmlElement("product_detail_code")]
        public string ProductDetailCode { get; set; }
    }
}
