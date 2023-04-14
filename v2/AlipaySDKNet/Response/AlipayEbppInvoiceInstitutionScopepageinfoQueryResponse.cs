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
        /// 切换 open_id 后请使用此字段： adapter_type为： EMPLOYEE_DEPARTMENT：返回部门ID EMPLOYEE_SELECT：当owner_type为PHONE时返回手机号，其他值则根据对接方式返回open_id，或企业码员工ID
        /// </summary>
        [XmlArray("onwer_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> OnwerOpenIdList { get; set; }

        /// <summary>
        /// 未切换 open_id 时请使用此字段： adapter_type为： EMPLOYEE_DEPARTMENT：返回部门ID EMPLOYEE_SELECT：当owner_type为PHONE时返回手机号，其他值则根据对接方式返回支付宝用户ID，或企业码员工ID
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
