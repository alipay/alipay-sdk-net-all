using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiSalesKbassetStuffPurchaseorderQueryResponse.
    /// </summary>
    public class KoubeiSalesKbassetStuffPurchaseorderQueryResponse : AopResponse
    {
        /// <summary>
        /// 采购单记录集合
        /// </summary>
        [XmlArray("asset_purchase_orders")]
        [XmlArrayItem("access_purchase_order")]
        public List<AccessPurchaseOrder> AssetPurchaseOrders { get; set; }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        [XmlElement("has_next_page")]
        public bool HasNextPage { get; set; }
    }
}
