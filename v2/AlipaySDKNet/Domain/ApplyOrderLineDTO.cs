using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApplyOrderLineDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApplyOrderLineDTO : AopObject
    {
        /// <summary>
        /// 后台产品码
        /// </summary>
        [XmlElement("fulfil_product_code")]
        public string FulfilProductCode { get; set; }

        /// <summary>
        /// 简单合约属性
        /// </summary>
        [XmlElement("product_property")]
        public string ProductProperty { get; set; }

        /// <summary>
        /// 前台产品码
        /// </summary>
        [XmlElement("sales_product_code")]
        public string SalesProductCode { get; set; }
    }
}
