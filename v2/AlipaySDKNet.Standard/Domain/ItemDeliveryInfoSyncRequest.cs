using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ItemDeliveryInfoSyncRequest Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDeliveryInfoSyncRequest : AopObject
    {
        /// <summary>
        /// 标识商品投放的场景，ALIPAY：公域，MERCHANT：私域
        /// </summary>
        [XmlElement("camp_type")]
        public string CampType { get; set; }

        /// <summary>
        /// 标识商品投放的展位
        /// </summary>
        [XmlElement("position_id")]
        public string PositionId { get; set; }
    }
}
