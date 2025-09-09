using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceProductInfo Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceProductInfo : AopObject
    {
        /// <summary>
        /// 发票产品描述
        /// </summary>
        [XmlElement("product_desc")]
        public string ProductDesc { get; set; }

        /// <summary>
        /// 发票产品编号
        /// </summary>
        [XmlElement("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// 发票产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 发票产品类型
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }
    }
}
