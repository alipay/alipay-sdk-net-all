using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesSceneruleQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesSceneruleQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 当前记录数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 费控规则列表
        /// </summary>
        [XmlArray("standard_rule_info_list")]
        [XmlArrayItem("standard_rule_info")]
        public List<StandardRuleInfo> StandardRuleInfoList { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page_count")]
        public long TotalPageCount { get; set; }
    }
}
