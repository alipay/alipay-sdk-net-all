using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcDepartmentInfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcDepartmentInfoModifyModel : AopObject
    {
        /// <summary>
        /// 部门编码，不同部门的编码不能相同，为空则代表不修改
        /// </summary>
        [XmlElement("department_code")]
        public string DepartmentCode { get; set; }

        /// <summary>
        /// 待修改部门的部门id
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 部门名称，为空则代表不修改
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 上级部门id，为空则代表不修改
        /// </summary>
        [XmlElement("parent_department_id")]
        public string ParentDepartmentId { get; set; }
    }
}
