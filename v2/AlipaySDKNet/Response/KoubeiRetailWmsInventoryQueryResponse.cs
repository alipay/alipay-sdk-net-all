using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsInventoryQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsInventoryQueryResponse : AopResponse
    {
        /// <summary>
        /// 返回货品库存列表
        /// </summary>
        [XmlArray("inventory_list")]
        [XmlArrayItem("inventory")]
        public List<Inventory> InventoryList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
