using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentExtInfo : AopObject
    {
        /// <summary>
        /// 买家扩展信息
        /// </summary>
        [XmlElement("buyer_ext_info")]
        public RentBuyerExtInfo BuyerExtInfo { get; set; }

        /// <summary>
        /// 物流扩展信息
        /// </summary>
        [XmlElement("delivery_ext_info")]
        public RentDeliveryExtInfo DeliveryExtInfo { get; set; }

        /// <summary>
        /// 融资扩展信息
        /// </summary>
        [XmlArray("financing_ext_info")]
        [XmlArrayItem("rent_financing_ext_info")]
        public List<RentFinancingExtInfo> FinancingExtInfo { get; set; }

        /// <summary>
        /// 历史资产融资扩展信息
        /// </summary>
        [XmlElement("historical_asset_financing_ext_info")]
        public RentHistoricalAssetFinancingExtInfoDTO HistoricalAssetFinancingExtInfo { get; set; }

        /// <summary>
        /// 商品扩展信息
        /// </summary>
        [XmlElement("item_ext_info")]
        public RentItemExtInfo ItemExtInfo { get; set; }

        /// <summary>
        /// 订单扩展信息
        /// </summary>
        [XmlElement("order_ext_info")]
        public RentOrderExtInfo OrderExtInfo { get; set; }
    }
}
