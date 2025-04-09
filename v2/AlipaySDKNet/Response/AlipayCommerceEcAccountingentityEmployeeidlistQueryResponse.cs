using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcAccountingentityEmployeeidlistQueryResponse.
    /// </summary>
    public class AlipayCommerceEcAccountingentityEmployeeidlistQueryResponse : AopResponse
    {
        /// <summary>
        /// 当前页数
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 员工id列表
        /// </summary>
        [XmlArray("employee_id_list")]
        [XmlArrayItem("string")]
        public List<string> EmployeeIdList { get; set; }

        /// <summary>
        /// 员工总数量
        /// </summary>
        [XmlElement("total_num")]
        public long TotalNum { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }
    }
}
