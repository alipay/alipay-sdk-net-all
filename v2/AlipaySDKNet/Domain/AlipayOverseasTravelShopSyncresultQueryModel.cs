using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelShopSyncresultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelShopSyncresultQueryModel : AopObject
    {
        /// <summary>
        /// 外部店铺ID
        /// </summary>
        [XmlElement("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 同步单据id，跨境电商场景必传
        /// </summary>
        [XmlElement("sync_order_id")]
        public string SyncOrderId { get; set; }
    }
}
