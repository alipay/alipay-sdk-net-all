using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOverseasTravelGoodsSyncresultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTravelGoodsSyncresultQueryModel : AopObject
    {
        /// <summary>
        /// 外部商户或第三方的商品ID
        /// </summary>
        [XmlElement("out_goods_id")]
        public string OutGoodsId { get; set; }

        /// <summary>
        /// 外部店铺ID，对于特定行业可选，比如GOL线上商品的场景非必填
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
