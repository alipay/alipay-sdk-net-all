using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DepartmentInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class DepartmentInfoDTO : AopObject
    {
        /// <summary>
        /// 部门编码
        /// </summary>
        [XmlElement("department_code")]
        public string DepartmentCode { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 上级部门id，特殊值-1表示根部门
        /// </summary>
        [XmlElement("parent_department_id")]
        public string ParentDepartmentId { get; set; }
    }
}
