using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HdfHospital Data Structure.
    /// </summary>
    [Serializable]
    public class HdfHospital : AopObject
    {
        /// <summary>
        /// 例：医保卡、身份证  按三方业务定义传递卡名称即可
        /// </summary>
        [XmlElement("consultation_credentials")]
        public string ConsultationCredentials { get; set; }

        /// <summary>
        /// 就诊证件号
        /// </summary>
        [XmlElement("credentials_number")]
        public string CredentialsNumber { get; set; }

        /// <summary>
        /// 科室名称
        /// </summary>
        [XmlElement("faculty_name")]
        public string FacultyName { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }
    }
}
