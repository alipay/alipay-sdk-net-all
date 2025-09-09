using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPcreditLoanHonorLoanBatchqueryResponse.
    /// </summary>
    public class AlipayPcreditLoanHonorLoanBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 入参传了currentPage才返回
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页条数, 入参传了currentPage才返回
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 记录列表。result_code=0则必填
        /// </summary>
        [XmlArray("records")]
        [XmlArrayItem("honor_loan_record_d_t_o")]
        public List<HonorLoanRecordDTO> Records { get; set; }

        /// <summary>
        /// 记录总数, 入参传了currentPage才返回
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 记录总条数，result_code=0则必填
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 总页数, 入参传了currentPage才返回
        /// </summary>
        [XmlElement("total_page")]
        public long TotalPage { get; set; }
    }
}
