using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentOfflineShoppingVO Data Structure.
    /// </summary>
    [Serializable]
    public class RentOfflineShoppingVO : AopObject
    {
        /// <summary>
        /// 关联租赁订单id
        /// </summary>
        [XmlElement("relate_rent_order_id")]
        public string RelateRentOrderId { get; set; }

        /// <summary>
        /// 关联实物购买订单id
        /// </summary>
        [XmlElement("relate_shopping_order_id")]
        public string RelateShoppingOrderId { get; set; }
    }
}
