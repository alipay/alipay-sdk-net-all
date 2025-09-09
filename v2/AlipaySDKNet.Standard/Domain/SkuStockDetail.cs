using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SkuStockDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SkuStockDetail : AopObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("sku_code")]
        public string SkuCode { get; set; }

        /// <summary>
        /// 库存数
        /// </summary>
        [XmlElement("stock")]
        public long Stock { get; set; }
    }
}
