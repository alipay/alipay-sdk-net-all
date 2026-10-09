using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProductGroup Data Structure.
    /// </summary>
    [Serializable]
    public class ProductGroup : AopObject
    {
        /// <summary>
        /// 数目
        /// </summary>
        [XmlElement("count")]
        public string Count { get; set; }

        /// <summary>
        /// 产品对象
        /// </summary>
        [XmlElement("product")]
        public ProductInfo Product { get; set; }

        /// <summary>
        /// 产品总价(单位：元)
        /// </summary>
        [XmlElement("total_price")]
        public string TotalPrice { get; set; }
    }
}
