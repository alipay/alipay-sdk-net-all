using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsInventoryBatchqueryResponse.
    /// </summary>
    public class KoubeiRetailWmsInventoryBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 库存列表
        /// </summary>
        [XmlArray("inventory_list")]
        [XmlArrayItem("inventory")]
        public List<Inventory> InventoryList { get; set; }
    }
}
