using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DepartmentDetailsDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DepartmentDetailsDTO : AopObject
    {
        /// <summary>
        /// departmentId-否-部门唯一标识-无枚举-被调方结果返回-无特殊说明
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// departmentName-否-部门名称，前端展示-无枚举-被调方结果返回-无特殊说明
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// parentId-否-上级部门id-无枚举-被调方结果返回-无特殊说明
        /// </summary>
        [XmlElement("parent_id")]
        public string ParentId { get; set; }
    }
}
