using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DepartmentInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class DepartmentInfoVO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("child_department_list")]
        [XmlArrayItem("sub_department_info_v_o")]
        public List<SubDepartmentInfoVO> ChildDepartmentList { get; set; }

        /// <summary>
        /// 科室医生数量
        /// </summary>
        [XmlElement("depart_doctor_num")]
        public string DepartDoctorNum { get; set; }

        /// <summary>
        /// 科室编码
        /// </summary>
        [XmlElement("depart_id")]
        public string DepartId { get; set; }

        /// <summary>
        /// 科室logo
        /// </summary>
        [XmlElement("depart_logo")]
        public string DepartLogo { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        [XmlElement("depart_name")]
        public string DepartName { get; set; }

        /// <summary>
        /// 父级科室ID
        /// </summary>
        [XmlElement("parent_depart_id")]
        public string ParentDepartId { get; set; }
    }
}
