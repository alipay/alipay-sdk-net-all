using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcEmployeeInfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcEmployeeInfoModifyModel : AopObject
    {
        /// <summary>
        /// 员工所属核算主体，核算主体可用于管控不同员工的出资方式，建议和不同出资账户关联，一个员工只能有一个核算主体。
        /// </summary>
        [XmlArray("accounting_entity_ids")]
        [XmlArrayItem("string")]
        public List<string> AccountingEntityIds { get; set; }

        /// <summary>
        /// 员工所属部门。如果不传值，则不更新所属部门
        /// </summary>
        [XmlArray("department_ids")]
        [XmlArrayItem("string")]
        public List<string> DepartmentIds { get; set; }

        /// <summary>
        /// 员工邮箱。如果不传值，则不更新邮箱。
        /// </summary>
        [XmlElement("employee_email")]
        public string EmployeeEmail { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 员工手机号。如果不传值，则不更新手机号。
        /// </summary>
        [XmlElement("employee_mobile")]
        public string EmployeeMobile { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [XmlElement("employee_name")]
        public string EmployeeName { get; set; }

        /// <summary>
        /// 员工工号。如果不传值，则不更新工号。
        /// </summary>
        [XmlElement("employee_no")]
        public string EmployeeNo { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 员工标签，用于员工的打标分类，后续费控管理可使用标签进行控制，支持输入多个标签，如“差旅员工，用餐员工”等；<br/><br/> 使用场景：1. 请严格对标签分类，不要滥用员工标签，否则影响员工和费控管理； 2. 一个员工最多10个标签，如无必要请勿使用；3. 标签名只能包含字母（大小写）、数字或中文字符
        /// </summary>
        [XmlArray("label_names")]
        [XmlArrayItem("string")]
        public List<string> LabelNames { get; set; }

        /// <summary>
        /// 个性化信息。如果不传值，则不更新个性化信息。 <a href='https://opendocs.alipay.com/pre-open/0ceh47?pathHash=14fac87c'>详见文档</a>
        /// </summary>
        [XmlElement("profiles")]
        public string Profiles { get; set; }

        /// <summary>
        /// 角色列表，目前只支持填一种角色。如果不传值，则不更新角色。
        /// </summary>
        [XmlArray("role_list")]
        [XmlArrayItem("string")]
        public List<string> RoleList { get; set; }
    }
}
