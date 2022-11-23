using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceInstitutionScopeModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceInstitutionScopeModifyModel : AopObject
    {
        /// <summary>
        /// 企业共同账户id
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 制度适配范围类型
        /// </summary>
        [XmlElement("adapter_type")]
        public string AdapterType { get; set; }

        /// <summary>
        /// 未切换open_id时请使用：adapterType为EMPLOYEE_ALL时，无需填写；adapterType为EMPLOYEE_SELECT时，填写员工id（可通过设置owner_type来指定id类型，支持员工支付宝id，员工企业码id和员工手机号）; adapterType为EMPLOYEE_DEPARTMENT时，填写部门id
        /// </summary>
        [XmlArray("add_owner_id_list")]
        [XmlArrayItem("string")]
        public List<string> AddOwnerIdList { get; set; }

        /// <summary>
        /// 切换open_id后请使用：adapterType为EMPLOYEE_ALL时，无需填写；adapterType为EMPLOYEE_SELECT时，填写员工id（可通过设置owner_type来指定id类型，支持员工open_id，员工企业码id和员工手机号）; adapterType为EMPLOYEE_DEPARTMENT时，填写部门id
        /// </summary>
        [XmlArray("add_owner_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> AddOwnerOpenIdList { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        [XmlElement("institution_id")]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 当adapterType为指定员工时，通过该字段指定操作的owner_id类型
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 未切换open_id时请使用：adapterType为EMPLOYEE_ALL时，无需填写；adapterType为EMPLOYEE_SELECT时，填写员工id（可通过设置owner_type来指定id类型，支持员工支付宝id，员工企业码id和员工手机号）; adapterType为EMPLOYEE_DEPARTMENT时，填写部门id
        /// </summary>
        [XmlArray("remove_owner_id_list")]
        [XmlArrayItem("string")]
        public List<string> RemoveOwnerIdList { get; set; }

        /// <summary>
        /// 切换open_id后请使用：adapterType为EMPLOYEE_ALL时，无需填写；adapterType为EMPLOYEE_SELECT时，填写员工id（可通过设置owner_type来指定id类型，支持员工open_id，员工企业码id和员工手机号）; adapterType为EMPLOYEE_DEPARTMENT时，填写部门id
        /// </summary>
        [XmlArray("remove_owner_open_id_list")]
        [XmlArrayItem("string")]
        public List<string> RemoveOwnerOpenIdList { get; set; }
    }
}
