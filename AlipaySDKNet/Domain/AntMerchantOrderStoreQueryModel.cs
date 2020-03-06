using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantOrderStoreQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantOrderStoreQueryModel : AopObject
    {
        /// <summary>
        /// 买家id
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 插件业务场景code，预约为ShopService
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 线上店的ID
        /// </summary>
        [XmlElement("store_open_id")]
        public string StoreOpenId { get; set; }
    }
}
