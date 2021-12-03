using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossFncGffundStandardvoucherBatchqueryResponse.
    /// </summary>
    public class AlipayBossFncGffundStandardvoucherBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("cur_page")]
        public long CurPage { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 资金流水凭证list
        /// </summary>
        [XmlArray("standard_voucher_list")]
        [XmlArrayItem("standard_voucher_open_api_v_o")]
        public List<StandardVoucherOpenApiVO> StandardVoucherList { get; set; }

        /// <summary>
        /// 服务处理是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 查询到的结果总数
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }
    }
}
