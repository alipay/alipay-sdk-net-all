using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiRetailWmsSupplierQueryResponse.
    /// </summary>
    public class KoubeiRetailWmsSupplierQueryResponse : AopResponse
    {
        /// <summary>
        /// 供应商信息
        /// </summary>
        [XmlArray("suppliers")]
        [XmlArrayItem("supplier_v_o")]
        public List<SupplierVO> Suppliers { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
