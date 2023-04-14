using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JobWorthJobdata Data Structure.
    /// </summary>
    [Serializable]
    public class JobWorthJobdata : AopObject
    {
        /// <summary>
        /// 证书发证机构
        /// </summary>
        [XmlElement("certificate_grant_institution")]
        public string CertificateGrantInstitution { get; set; }

        /// <summary>
        /// 证书编号
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 证书等级：中文
        /// </summary>
        [XmlElement("certificate_level")]
        public string CertificateLevel { get; set; }

        /// <summary>
        /// 证书名称
        /// </summary>
        [XmlElement("certificate_name")]
        public string CertificateName { get; set; }

        /// <summary>
        /// 工作证图片上传接口返回的id
        /// </summary>
        [XmlElement("certificate_pic_id")]
        public string CertificatePicId { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 学历，可以用以下字段HIGHSCHOOL_AND_BELOW（高中及以下），POLYTECHNIC（中专），COLLEGE（大专），BACHELOR（本科），MASTER（硕士），DOCTOR_AND_ABOVE（博士及以上）
        /// </summary>
        [XmlElement("degree")]
        public string Degree { get; set; }

        /// <summary>
        /// 商户侧投递岗位id
        /// </summary>
        [XmlElement("delivery_position_id")]
        public string DeliveryPositionId { get; set; }

        /// <summary>
        /// 投递时间戳
        /// </summary>
        [XmlElement("delivery_time")]
        public long DeliveryTime { get; set; }

        /// <summary>
        /// 教育状态只有两种，GRADUATE(毕业)，STUDY（未毕业）
        /// </summary>
        [XmlElement("education_status")]
        public string EducationStatus { get; set; }

        /// <summary>
        /// 报名流水号
        /// </summary>
        [XmlElement("entry_no")]
        public string EntryNo { get; set; }

        /// <summary>
        /// 考试分数
        /// </summary>
        [XmlElement("exam_score")]
        public string ExamScore { get; set; }

        /// <summary>
        /// 工作证图片上传接口返回的id
        /// </summary>
        [XmlElement("head_pic_id")]
        public string HeadPicId { get; set; }

        /// <summary>
        /// 求职意向，城市的adccode  例如110000（北京市）
        /// </summary>
        [XmlElement("intention_city")]
        public string IntentionCity { get; set; }

        /// <summary>
        /// 发证日期，ms时间戳
        /// </summary>
        [XmlElement("issue_date")]
        public string IssueDate { get; set; }

        /// <summary>
        /// 岗位对应的职业id，字段参考https://www.yuque.com/wx3dkp/gwckr4/bs03t3
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 职业名称
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 商户职业Id
        /// </summary>
        [XmlElement("ka_job_id")]
        public string KaJobId { get; set; }

        /// <summary>
        /// 商户职业名称
        /// </summary>
        [XmlElement("ka_job_name")]
        public string KaJobName { get; set; }

        /// <summary>
        /// 商户行业Id
        /// </summary>
        [XmlElement("ka_profession_id")]
        public string KaProfessionId { get; set; }

        /// <summary>
        /// 商户行业名称
        /// </summary>
        [XmlElement("ka_profession_name")]
        public string KaProfessionName { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 毕业的月
        /// </summary>
        [XmlElement("month")]
        public string Month { get; set; }

        /// <summary>
        /// 岗位对应的行业id，字段参考https://www.yuque.com/wx3dkp/gwckr4/bs03t3
        /// </summary>
        [XmlElement("profession_id")]
        public string ProfessionId { get; set; }

        /// <summary>
        /// 行业名称
        /// </summary>
        [XmlElement("profession_name")]
        public string ProfessionName { get; set; }

        /// <summary>
        /// 求职意向，薪水范围，不能低于salary_min
        /// </summary>
        [XmlElement("salary_max")]
        public string SalaryMax { get; set; }

        /// <summary>
        /// 求职意向，薪水范围，不能高于salary_max
        /// </summary>
        [XmlElement("salary_min")]
        public string SalaryMin { get; set; }

        /// <summary>
        /// 薪资单位，元/日(DAY)、元/次(TIME)、元/月(MONTH)、元/小时(HOUR)、元/件 (NUM)、元/周 (WEEK)、其他 (OTHER)
        /// </summary>
        [XmlElement("salary_unit")]
        public string SalaryUnit { get; set; }

        /// <summary>
        /// 学校
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 用英文逗号分隔，最多6项
        /// </summary>
        [XmlElement("skill_name")]
        public string SkillName { get; set; }

        /// <summary>
        /// 参加工作的时间，格式形如 2011-07
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 信息类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 有效期：开始结束 ms 时间戳
        /// </summary>
        [XmlElement("valid_date_end")]
        public string ValidDateEnd { get; set; }

        /// <summary>
        /// 有效期：开始时间 ms时间戳
        /// </summary>
        [XmlElement("valid_date_start")]
        public string ValidDateStart { get; set; }

        /// <summary>
        /// 校验状态
        /// </summary>
        [XmlElement("verify_status")]
        public string VerifyStatus { get; set; }

        /// <summary>
        /// 工作描述
        /// </summary>
        [XmlElement("work_desc")]
        public string WorkDesc { get; set; }

        /// <summary>
        /// 工作结束时间，毫秒级时间戳
        /// </summary>
        [XmlElement("work_end_time")]
        public string WorkEndTime { get; set; }

        /// <summary>
        /// 岗位属性：全职(FULL_TIME)或者兼职(PART_TIME)
        /// </summary>
        [XmlElement("work_property")]
        public string WorkProperty { get; set; }

        /// <summary>
        /// 工作开始时间，毫秒级时间戳
        /// </summary>
        [XmlElement("work_start_time")]
        public string WorkStartTime { get; set; }

        /// <summary>
        /// 毕业的年
        /// </summary>
        [XmlElement("year")]
        public string Year { get; set; }
    }
}
