using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceIssuebatchIssuerecordsBatchqueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceIssuebatchIssuerecordsBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 当前批次下的发放记录信息列表
        /// </summary>
        [XmlElement("issue_record_info_list")]
        public IssueRecordInfo IssueRecordInfoList { get; set; }

        /// <summary>
        /// 分页查询页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询单页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page_count")]
        public string TotalPageCount { get; set; }
    }
}
