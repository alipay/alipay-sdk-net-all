using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsInventoryrecordQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsInventoryrecordQueryResponse : AopResponse
    {
        /// <summary>
        /// 库存变更记录
        /// </summary>
        [XmlArray("inventory_record_list")]
        [XmlArrayItem("inventory_record")]
        public List<InventoryRecord> InventoryRecordList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 页码大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
