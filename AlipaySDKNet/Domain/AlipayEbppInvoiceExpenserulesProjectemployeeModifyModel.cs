using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectemployeeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpenserulesProjectemployeeModifyModel : AopObject
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 需要添加的员工UID列表 约束：一次最多50个
        /// </summary>
        [XmlArray("add_employee_list")]
        [XmlArrayItem("string")]
        public List<string> AddEmployeeList { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 需要移除的员工UID列表 约束：一次最多50个
        /// </summary>
        [XmlArray("remove_employee_list")]
        [XmlArrayItem("string")]
        public List<string> RemoveEmployeeList { get; set; }
    }
}
