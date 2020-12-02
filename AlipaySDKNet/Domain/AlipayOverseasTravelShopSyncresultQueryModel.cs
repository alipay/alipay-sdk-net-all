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
    }
}
