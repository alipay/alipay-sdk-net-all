using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StaffVO Data Structure.
    /// </summary>
    [Serializable]
    public class StaffVO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("department_jobs")]
        [XmlArrayItem("department_job_v_o")]
        public List<DepartmentJobVO> DepartmentJobs { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 员工id
        /// </summary>
        [XmlElement("staff_id")]
        public string StaffId { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [XmlElement("staff_no")]
        public string StaffNo { get; set; }
    }
}
