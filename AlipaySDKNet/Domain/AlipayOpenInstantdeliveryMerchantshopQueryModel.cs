using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenInstantdeliveryMerchantshopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenInstantdeliveryMerchantshopQueryModel : AopObject
    {
        /// <summary>
        /// 商家门店编码。
        /// </summary>
        [XmlElement("shop_no")]
        public string ShopNo { get; set; }
    }
}
