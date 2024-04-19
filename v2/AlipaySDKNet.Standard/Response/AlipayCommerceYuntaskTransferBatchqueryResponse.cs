using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskTransferBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskTransferBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 转账日志记录
        /// </summary>
        [XmlArray("fund_transfer_logs")]
        [XmlArrayItem("fund_transfer_log_result")]
        public List<FundTransferLogResult> FundTransferLogs { get; set; }

        /// <summary>
        /// 第几页，默认1（从1开始计数）
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，默认10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 最大记录数
        /// </summary>
        [XmlElement("total_size")]
        public string TotalSize { get; set; }
    }
}
