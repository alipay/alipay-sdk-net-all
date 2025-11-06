using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentOfflineShoppingDTO Data Structure.
    /// </summary>
    [Serializable]
    public class RentOfflineShoppingDTO : AopObject
    {
        /// <summary>
        /// 支付信息
        /// </summary>
        [XmlArray("purchase_infos")]
        [XmlArrayItem("purchase_info")]
        public List<PurchaseInfo> PurchaseInfos { get; set; }

        /// <summary>
        /// 关联租赁订单
        /// </summary>
        [XmlElement("relate_order_id")]
        public string RelateOrderId { get; set; }
    }
}
