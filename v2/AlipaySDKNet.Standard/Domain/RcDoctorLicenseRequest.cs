using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RcDoctorLicenseRequest Data Structure.
    /// </summary>
    [Serializable]
    public class RcDoctorLicenseRequest : AopObject
    {
        /// <summary>
        /// 医生唯一id，关联到传入方医生信息
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生姓名，审核项，必传
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 性别，男/女/未知
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 医生职称
        /// </summary>
        [XmlElement("job_title")]
        public string JobTitle { get; set; }

        /// <summary>
        /// 医生资格证书编码，选传，传入时以此为依据进行审核
        /// </summary>
        [XmlElement("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 执业科室（专业方向）
        /// </summary>
        [XmlElement("main_department")]
        public string MainDepartment { get; set; }

        /// <summary>
        /// 主执业医院名称
        /// </summary>
        [XmlElement("main_hospital")]
        public string MainHospital { get; set; }

        /// <summary>
        /// 执业医院所在省份
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 次执业机构列表
        /// </summary>
        [XmlArray("second_hos_list")]
        [XmlArrayItem("string")]
        public List<string> SecondHosList { get; set; }
    }
}
