using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcDepartmentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcDepartmentCreateModel : AopObject
    {
        /// <summary>
        /// 部门编码，不同部门的编码不可重复，如果为空则生成默认部门编码
        /// </summary>
        [XmlElement("department_code")]
        public string DepartmentCode { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 上级部门id，如果为空则默认设置上级部门为根部门
        /// </summary>
        [XmlElement("parent_department_id")]
        public string ParentDepartmentId { get; set; }
    }
}
