using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DepartmentVO Data Structure.
    /// </summary>
    [Serializable]
    public class DepartmentVO : AopObject
    {
        /// <summary>
        /// 能挂号
        /// </summary>
        [XmlElement("can_reg")]
        public bool CanReg { get; set; }

        /// <summary>
        /// 科室id
        /// </summary>
        [XmlElement("dept_id")]
        public string DeptId { get; set; }

        /// <summary>
        /// 一级科室
        /// </summary>
        [XmlElement("dept_level")]
        public string DeptLevel { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        [XmlElement("dept_name")]
        public string DeptName { get; set; }

        /// <summary>
        /// 父科室id
        /// </summary>
        [XmlElement("parent_dept_id")]
        public string ParentDeptId { get; set; }
    }
}
