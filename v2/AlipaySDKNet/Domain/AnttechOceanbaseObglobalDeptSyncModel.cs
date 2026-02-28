using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalDeptSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalDeptSyncModel : AopObject
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        [XmlElement("dept_name")]
        public string DeptName { get; set; }

        /// <summary>
        /// 部门编码
        /// </summary>
        [XmlElement("dept_no")]
        public string DeptNo { get; set; }

        /// <summary>
        /// 部门负责人工号
        /// </summary>
        [XmlElement("master_work_no")]
        public string MasterWorkNo { get; set; }

        /// <summary>
        /// 上级部门id
        /// </summary>
        [XmlElement("parent_dept_id")]
        public string ParentDeptId { get; set; }

        /// <summary>
        /// 部门id层级路径
        /// </summary>
        [XmlElement("parent_path")]
        public string ParentPath { get; set; }

        /// <summary>
        /// 部门状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
