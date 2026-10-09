using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsWarehouseQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsWarehouseQueryResponse : AopResponse
    {
        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 仓库信息
        /// </summary>
        [XmlArray("warehouses")]
        [XmlArrayItem("warehouse_v_o")]
        public List<WarehouseVO> Warehouses { get; set; }
    }
}
