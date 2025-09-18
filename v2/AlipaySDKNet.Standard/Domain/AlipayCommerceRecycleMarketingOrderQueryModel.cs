using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleMarketingOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleMarketingOrderQueryModel : AopObject
    {
        /// <summary>
        /// 订单推广记录id
        /// </summary>
        [XmlElement("promo_id")]
        public string PromoId { get; set; }
    }
}
