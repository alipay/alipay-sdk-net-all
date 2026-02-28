using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalDoctorinfoQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalDoctorinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 获奖情况
        /// </summary>
        [XmlElement("awards")]
        public string Awards { get; set; }

        /// <summary>
        /// 所属部门名称
        /// </summary>
        [XmlElement("department_name")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 个人简介
        /// </summary>
        [XmlElement("doc_desc")]
        public string DocDesc { get; set; }

        /// <summary>
        /// 医生内部id
        /// </summary>
        [XmlElement("doctor_inner_id")]
        public string DoctorInnerId { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 机构名称 医院
        /// </summary>
        [XmlElement("organization")]
        public string Organization { get; set; }

        /// <summary>
        /// 技能描述
        /// </summary>
        [XmlElement("skilled_desc")]
        public string SkilledDesc { get; set; }

        /// <summary>
        /// 职称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
