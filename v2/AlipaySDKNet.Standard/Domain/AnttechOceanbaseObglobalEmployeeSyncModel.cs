using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechOceanbaseObglobalEmployeeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechOceanbaseObglobalEmployeeSyncModel : AopObject
    {
        /// <summary>
        /// 员工身份
        /// </summary>
        [XmlElement("employee_identity")]
        public string EmployeeIdentity { get; set; }

        /// <summary>
        /// 一级部门id
        /// </summary>
        [XmlElement("first_dept_id")]
        public string FirstDeptId { get; set; }

        /// <summary>
        /// 主属部门id
        /// </summary>
        [XmlElement("main_dept_id")]
        public string MainDeptId { get; set; }

        /// <summary>
        /// 二级部门id
        /// </summary>
        [XmlElement("second_dept_id")]
        public string SecondDeptId { get; set; }

        /// <summary>
        /// 人员状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("system_name")]
        public string SystemName { get; set; }

        /// <summary>
        /// 三级部门id
        /// </summary>
        [XmlElement("third_dept_id")]
        public string ThirdDeptId { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [XmlElement("work_no")]
        public string WorkNo { get; set; }
    }
}
