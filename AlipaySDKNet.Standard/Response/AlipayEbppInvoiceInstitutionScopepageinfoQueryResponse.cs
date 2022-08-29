using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionScopepageinfoQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceInstitutionScopepageinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 制度下人员生效范围，枚举值： EMPLOYEE_ALL(全体员工), EMPLOYEE_SELECT(自定义员工), EMPLOYEE_DEPARTMENT(部门)
        /// </summary>
        [XmlElement("adapter_type")]
        public string AdapterType { get; set; }

        /// <summary>
        /// 员工id列表，如owner_type为phone返回员工手机号
        /// </summary>
        [XmlArray("owner_id_list")]
        [XmlArrayItem("string")]
        public List<string> OwnerIdList { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("total_page_count")]
        public long TotalPageCount { get; set; }
    }
}
