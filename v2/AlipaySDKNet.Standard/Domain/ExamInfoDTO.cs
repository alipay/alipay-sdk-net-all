using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExamInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ExamInfoDTO : AopObject
    {
        /// <summary>
        /// 证书颁发日期
        /// </summary>
        [XmlElement("certificate_issue_date")]
        public string CertificateIssueDate { get; set; }

        /// <summary>
        /// 认证等级
        /// </summary>
        [XmlElement("certificate_level")]
        public string CertificateLevel { get; set; }

        /// <summary>
        /// 认证状态
        /// </summary>
        [XmlElement("certificate_status")]
        public string CertificateStatus { get; set; }

        /// <summary>
        /// 用户考试报名信息id
        /// </summary>
        [XmlElement("college_exam_enrollment_id")]
        public string CollegeExamEnrollmentId { get; set; }

        /// <summary>
        /// 考试结束时间
        /// </summary>
        [XmlElement("exam_end_time")]
        public string ExamEndTime { get; set; }

        /// <summary>
        /// 考试开始时间
        /// </summary>
        [XmlElement("exam_start_time")]
        public string ExamStartTime { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }
    }
}
