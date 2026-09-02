using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActualVisitInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActualVisitInfo : AopObject
    {
        /// <summary>
        /// 就医信息-就诊城市
        /// </summary>
        [XmlElement("actual_city")]
        public string ActualCity { get; set; }

        /// <summary>
        /// 就医信息-就诊科室
        /// </summary>
        [XmlElement("actual_department")]
        public string ActualDepartment { get; set; }

        /// <summary>
        /// 就医信息-就诊医院
        /// </summary>
        [XmlElement("actual_hospital")]
        public string ActualHospital { get; set; }

        /// <summary>
        /// 就医信息-医生职称
        /// </summary>
        [XmlElement("doctor_title")]
        public string DoctorTitle { get; set; }

        /// <summary>
        /// 就医信息-就诊专家
        /// </summary>
        [XmlElement("expert")]
        public string Expert { get; set; }

        /// <summary>
        /// 就医信息-医院地址
        /// </summary>
        [XmlElement("hospital_address")]
        public string HospitalAddress { get; set; }

        /// <summary>
        /// 就医信息-用户相关描述
        /// </summary>
        [XmlElement("user_desc")]
        public string UserDesc { get; set; }

        /// <summary>
        /// 就医信息-就诊结束时间
        /// </summary>
        [XmlElement("visit_end_time")]
        public string VisitEndTime { get; set; }

        /// <summary>
        /// 就医信息-就诊开始时间
        /// </summary>
        [XmlElement("visit_start_time")]
        public string VisitStartTime { get; set; }
    }
}
