using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationDcsMerchantQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationDcsMerchantQueryModel : AopObject
    {
        /// <summary>
        /// 品牌标识
        /// </summary>
        [XmlElement("brander_id")]
        public string BranderId { get; set; }
    }
}
