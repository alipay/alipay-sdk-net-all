using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcInvoiceProductQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcInvoiceProductQueryModel : AopObject
    {
        /// <summary>
        /// 发票产品类型
        /// </summary>
        [XmlElement("product_type")]
        public string ProductType { get; set; }
    }
}
