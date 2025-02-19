using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleItemQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleItemQueryModel : AopObject
    {
        /// <summary>
        /// 产品code，用来描述商品的SPU_ID
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }
    }
}
