using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SportsDepartment Data Structure.
    /// </summary>
    [Serializable]
    public class SportsDepartment : AopObject
    {
        /// <summary>
        /// 部门主键编码
        /// </summary>
        [XmlElement("department_code")]
        public string DepartmentCode { get; set; }

        /// <summary>
        /// 是否叶子节点
        /// </summary>
        [XmlElement("leaf")]
        public bool Leaf { get; set; }

        /// <summary>
        /// 部门层级
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父级部门code
        /// </summary>
        [XmlElement("parent_code")]
        public string ParentCode { get; set; }
    }
}
