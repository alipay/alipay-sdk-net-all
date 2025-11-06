using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// HDFPatientCourseTime Data Structure.
    /// </summary>
    [Serializable]
    public class HDFPatientCourseTime : AopObject
    {
        /// <summary>
        /// 患病时间
        /// </summary>
        [XmlElement("patient_course_time")]
        public string PatientCourseTime { get; set; }
    }
}
