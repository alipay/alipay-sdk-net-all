using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceCompanysupplierQueryResponse.
    /// </summary>
    public class AlipayCommerceEcRecyclinginvoiceCompanysupplierQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页实际数据条数
        /// </summary>
        [XmlElement("curr_page_size")]
        public long CurrPageSize { get; set; }

        /// <summary>
        /// 供应商列表信息
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("supplier_query_open_result")]
        public List<SupplierQueryOpenResult> DataList { get; set; }

        /// <summary>
        /// 页号
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
