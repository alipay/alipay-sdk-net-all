using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectruleQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesProjectruleQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 当前记录数
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 项目规则列表
        /// </summary>
        [XmlArray("project_rule_info_list")]
        [XmlArrayItem("project_rule_info")]
        public List<ProjectRuleInfo> ProjectRuleInfoList { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_page_count")]
        public string TotalPageCount { get; set; }
    }
}
