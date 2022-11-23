using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesEmployeeQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesEmployeeQueryResponse : AopResponse
    {
        /// <summary>
        /// 切换open_id前请使用此字段：员工列表
        /// </summary>
        [XmlArray("employee_list")]
        [XmlArrayItem("string")]
        public List<string> EmployeeList { get; set; }

        /// <summary>
        /// 切换open_id后请使用此字段：员工open_id列表
        /// </summary>
        [XmlArray("employee_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> EmployeeOpenIdList { get; set; }

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
        /// 总页数
        /// </summary>
        [XmlElement("total_page_count")]
        public long TotalPageCount { get; set; }
    }
}
