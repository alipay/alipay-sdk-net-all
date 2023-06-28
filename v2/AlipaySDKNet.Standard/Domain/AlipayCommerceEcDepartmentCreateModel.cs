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
        /// 部门编码
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
        /// 上级部门id
        /// </summary>
        [XmlElement("parent_department_id")]
        public string ParentDepartmentId { get; set; }
    }
}
