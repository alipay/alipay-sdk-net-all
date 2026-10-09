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
        /// 企业共同账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 未切换 open_id 时请使用此字段： 需要添加的员工UID列表 特殊说明：一次最多50个
        /// </summary>
        [XmlArray("add_employee_list")]
        [XmlArrayItem("string")]
        public List<string> AddEmployeeList { get; set; }

        /// <summary>
        /// 切换 open_id 后请使用此字段： 需要添加的open_id/企业码员工ID列表 特殊说明：一次最多50个
        /// </summary>
        [XmlArray("add_employee_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> AddEmployeeOpenIdList { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业码企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 费控规则ID列表
        /// </summary>
        [XmlArray("group_id_list")]
        [XmlArrayItem("string")]
        public List<string> GroupIdList { get; set; }

        /// <summary>
        /// 未切换 open_id 时请使用此字段： 需要移除的员工UID列表 特殊说明：一次最多50个
        /// </summary>
        [XmlArray("remove_employee_list")]
        [XmlArrayItem("string")]
        public List<string> RemoveEmployeeList { get; set; }

        /// <summary>
        /// 切换 open_id 后请使用此字段： 需要移除的open_id/企业码员工ID列表 特殊说明：一次最多50个
        /// </summary>
        [XmlArray("remove_employee_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> RemoveEmployeeOpenIdList { get; set; }
    }
}
