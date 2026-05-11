using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ServicepackagePatientInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ServicepackagePatientInfo : AopObject
    {
        /// <summary>
        /// 年龄
        /// </summary>
        [XmlElement("patient_age")]
        public string PatientAge { get; set; }

        /// <summary>
        /// 患者疾病
        /// </summary>
        [XmlElement("patient_disease")]
        public string PatientDisease { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("patient_gender")]
        public string PatientGender { get; set; }

        /// <summary>
        /// 患者ID
        /// </summary>
        [XmlElement("patient_id")]
        public string PatientId { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        [XmlElement("patient_name")]
        public string PatientName { get; set; }

        /// <summary>
        /// 病例图片
        /// </summary>
        [XmlArray("patient_pic")]
        [XmlArrayItem("string")]
        public List<string> PatientPic { get; set; }
    }
}
