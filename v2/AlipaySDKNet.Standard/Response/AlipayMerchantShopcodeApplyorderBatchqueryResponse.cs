using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantShopcodeApplyorderBatchqueryResponse.
    /// </summary>
    public class AlipayMerchantShopcodeApplyorderBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("cur_page_no")]
        public long CurPageNo { get; set; }

        /// <summary>
        /// 门店码开通流水详情
        /// </summary>
        [XmlArray("order_list")]
        [XmlArrayItem("order_info_d_t_o")]
        public List<OrderInfoDTO> OrderList { get; set; }

        /// <summary>
        /// 当前页数量
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 本次查询总记录数
        /// </summary>
        [XmlElement("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 本次查询总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }
    }
}
