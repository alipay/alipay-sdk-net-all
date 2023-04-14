using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DepartmentData Data Structure.
    /// </summary>
    [Serializable]
    public class DepartmentData : AopObject
    {
        /// <summary>
        /// 呼吸道疾病
        /// </summary>
        [XmlElement("department_disease_info")]
        public string DepartmentDiseaseInfo { get; set; }

        /// <summary>
        /// 科室id
        /// </summary>
        [XmlElement("department_id")]
        public string DepartmentId { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 科室标签
        /// </summary>
        [XmlElement("department_tag")]
        public string DepartmentTag { get; set; }

        /// <summary>
        /// 科室类型
        /// </summary>
        [XmlElement("department_type")]
        public string DepartmentType { get; set; }

        /// <summary>
        /// 科室挂号服务跳转
        /// </summary>
        [XmlElement("department_url")]
        public string DepartmentUrl { get; set; }

        /// <summary>
        /// 科室所属医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 所属上级科室id
        /// </summary>
        [XmlElement("parent_department_id")]
        public string ParentDepartmentId { get; set; }

        /// <summary>
        /// 所属上级科室名称
        /// </summary>
        [XmlElement("parent_department_name")]
        public string ParentDepartmentName { get; set; }
    }
}
