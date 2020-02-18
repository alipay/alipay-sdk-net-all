using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIotSupplierAssetBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceIotSupplierAssetBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("cur_page_num")]
        public string CurPageNum { get; set; }

        /// <summary>
        /// 查询分页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 供应商设备信息列表
        /// </summary>
        [XmlArray("result_list")]
        [XmlArrayItem("supplier_asset_response")]
        public List<SupplierAssetResponse> ResultList { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_size")]
        public long TotalSize { get; set; }
    }
}
