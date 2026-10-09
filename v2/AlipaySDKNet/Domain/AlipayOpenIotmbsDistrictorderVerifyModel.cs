using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsDistrictorderVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsDistrictorderVerifyModel : AopObject
    {
        /// <summary>
        /// order_id：待核销的订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// store_id：核销门店的id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }
    }
}
