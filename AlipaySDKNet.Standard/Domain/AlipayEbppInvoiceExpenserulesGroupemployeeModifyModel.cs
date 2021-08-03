using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesGroupemployeeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpenserulesGroupemployeeModifyModel : AopObject
    {
        /// <summary>
        /// 企业id-共同账号ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 需要添加的员工Uid列表（一次最多50个）
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
        /// 费控规则ID（可以线下获取，也可以通过接口添加创建）
        /// </summary>
        [XmlArray("group_id_list")]
        [XmlArrayItem("string")]
        public List<string> GroupIdList { get; set; }

        /// <summary>
        /// 需要移除的员工Uid列表（一次最多50个）
        /// </summary>
        [XmlArray("remove_employee_list")]
        [XmlArrayItem("string")]
        public List<string> RemoveEmployeeList { get; set; }
    }
}
