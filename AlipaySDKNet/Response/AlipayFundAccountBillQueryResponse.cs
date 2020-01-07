using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundAccountBillQueryResponse.
    /// </summary>
    public class AlipayFundAccountBillQueryResponse : AopResponse
    {
        /// <summary>
        /// 账单详情
        /// </summary>
        [XmlArray("acc_detail_list")]
        [XmlArrayItem("trusteeship_account_bill_query_response")]
        public List<TrusteeshipAccountBillQueryResponse> AccDetailList { get; set; }

        /// <summary>
        /// 结果页数
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 结果页大小
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 每页元素数
        /// </summary>
        [XmlElement("total_item_count")]
        public string TotalItemCount { get; set; }
    }
}
