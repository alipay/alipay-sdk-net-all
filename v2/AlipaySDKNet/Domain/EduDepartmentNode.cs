using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduDepartmentNode Data Structure.
    /// </summary>
    [Serializable]
    public class EduDepartmentNode : AopObject
    {
        /// <summary>
        /// 人员所属的部门、学院或班级等组织节点外部唯一标识
        /// </summary>
        [XmlElement("department_code")]
        public string DepartmentCode { get; set; }

        /// <summary>
        /// 人员所属的部门、学院或班级名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }
    }
}
