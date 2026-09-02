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
        /// 官网注册账号为手机号时返回；消费方仅对非空数据生成 CRM 线索。
        /// </summary>
        [XmlElement("account_mobile")]
        public string AccountMobile { get; set; }

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
        /// 当前取考试记录中的 examinee_department。
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

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
        /// 取 college_exam_enrollment.gmt_modified，表示官网侧从 ATAC 取回成绩并更新考试记录的时间；不是 ATAC 报名时间。
        /// </summary>
        [XmlElement("lead_time")]
        public string LeadTime { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [XmlElement("passport_id")]
        public string PassportId { get; set; }

        /// <summary>
        /// 当前取考生类型名称；消费方会过滤学生/在校/student。
        /// </summary>
        [XmlElement("position")]
        public string Position { get; set; }

        /// <summary>
        /// 考试记录中的考生姓名。
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 用户的出生年份
        /// </summary>
        [XmlElement("year_of_birth")]
        public string YearOfBirth { get; set; }
    }
}
