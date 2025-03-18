using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryRecruitJobSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryRecruitJobSyncModel : AopObject
    {
        /// <summary>
        /// 学历要求
        /// </summary>
        [XmlElement("academic_require")]
        public string AcademicRequire { get; set; }

        /// <summary>
        /// 岗位详情地址
        /// </summary>
        [XmlElement("address_info")]
        public JobAddress AddressInfo { get; set; }

        /// <summary>
        /// 年龄要求，最小年龄(含),最大年龄(含)； 最小年龄18
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// C端岗位详情页面url
        /// </summary>
        [XmlElement("client_job_url")]
        public string ClientJobUrl { get; set; }

        /// <summary>
        /// 内容标签最多5个，每个标签最多7个中文字符
        /// </summary>
        [XmlArray("employee_welfare")]
        [XmlArrayItem("string")]
        public List<string> EmployeeWelfare { get; set; }

        /// <summary>
        /// 个人：填写姓名 个体/企业：填写企业全称
        /// </summary>
        [XmlElement("employer_name")]
        public string EmployerName { get; set; }

        /// <summary>
        /// 雇主类型
        /// </summary>
        [XmlElement("employer_type")]
        public string EmployerType { get; set; }

        /// <summary>
        /// 性别要求
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 毕业时间，格式:yyyy-MM-dd
        /// </summary>
        [XmlElement("graduation_time")]
        public string GraduationTime { get; set; }

        /// <summary>
        /// 招工方openId；hire_user_id和hire_open_id二选一填写，可以都为空
        /// </summary>
        [XmlElement("hire_open_id")]
        public string HireOpenId { get; set; }

        /// <summary>
        /// 岗位招聘状态：HIRING-招聘中,CLOSED-停止招聘
        /// </summary>
        [XmlElement("hire_status")]
        public string HireStatus { get; set; }

        /// <summary>
        /// 招工方UID；hire_user_id和hire_open_id二选一填写，可以都为空
        /// </summary>
        [XmlElement("hire_user_id")]
        public string HireUserId { get; set; }

        /// <summary>
        /// 招工方手机号
        /// </summary>
        [XmlElement("hire_user_mobile")]
        public string HireUserMobile { get; set; }

        /// <summary>
        /// 招工方姓名
        /// </summary>
        [XmlElement("hire_user_name")]
        public string HireUserName { get; set; }

        /// <summary>
        /// 岗位详情内容
        /// </summary>
        [XmlElement("job_detail")]
        public string JobDetail { get; set; }

        /// <summary>
        /// 岗位招聘结束时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("job_end_time")]
        public string JobEndTime { get; set; }

        /// <summary>
        /// 岗位名称
        /// </summary>
        [XmlElement("job_name")]
        public string JobName { get; set; }

        /// <summary>
        /// 当岗位状态 = 停止招聘时，必填；
        /// </summary>
        [XmlElement("job_off_reason")]
        public string JobOffReason { get; set; }

        /// <summary>
        /// 岗位类型 用于岗位筛选、岗位匹配等场景，具体枚举值清单如下（传第三级岗位类型Code）：<a href="https://jiuye.yuque.com/org-wiki-jiuye-cpfcqs/araxo9/nmowzfqvl8itkado" target="_blank">岗位类型清单</a>
        /// </summary>
        [XmlElement("job_type")]
        public string JobType { get; set; }

        /// <summary>
        /// 外部服务商雇主id
        /// </summary>
        [XmlElement("out_hire_user_id")]
        public string OutHireUserId { get; set; }

        /// <summary>
        /// ISV侧岗位唯一标识
        /// </summary>
        [XmlElement("out_job_id")]
        public string OutJobId { get; set; }

        /// <summary>
        /// 岗位就业模式
        /// </summary>
        [XmlElement("part_time_mode")]
        public string PartTimeMode { get; set; }

        /// <summary>
        /// 绩效奖金；（单位：元）
        /// </summary>
        [XmlElement("performance_bonus")]
        public string PerformanceBonus { get; set; }

        /// <summary>
        /// 0时为不限
        /// </summary>
        [XmlElement("recruit_count")]
        public long RecruitCount { get; set; }

        /// <summary>
        /// 最大薪资，薪资单位为面议时填面议；（单位：元）
        /// </summary>
        [XmlElement("salary_max")]
        public string SalaryMax { get; set; }

        /// <summary>
        /// 薪资单位为面议时填面议；（单位：元）
        /// </summary>
        [XmlElement("salary_min")]
        public string SalaryMin { get; set; }

        /// <summary>
        /// 岗位薪资单位
        /// </summary>
        [XmlElement("salary_unit")]
        public string SalaryUnit { get; set; }

        /// <summary>
        /// B端岗位详情地址
        /// </summary>
        [XmlElement("server_job_url")]
        public string ServerJobUrl { get; set; }

        /// <summary>
        /// 岗位来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 工作结束日期，格式:yyyy-MM-dd
        /// </summary>
        [XmlElement("work_end_date")]
        public string WorkEndDate { get; set; }

        /// <summary>
        /// 工作时段结束时间，格式：HH:mm:ss
        /// </summary>
        [XmlElement("work_end_time")]
        public string WorkEndTime { get; set; }

        /// <summary>
        /// 工作要求
        /// </summary>
        [XmlArray("work_require")]
        [XmlArrayItem("string")]
        public List<string> WorkRequire { get; set; }

        /// <summary>
        /// 工作开始日期，格式:yyyy-MM-dd
        /// </summary>
        [XmlElement("work_start_date")]
        public string WorkStartDate { get; set; }

        /// <summary>
        /// 工作时段开始时间，格式：HH:mm:ss
        /// </summary>
        [XmlElement("work_start_time")]
        public string WorkStartTime { get; set; }

        /// <summary>
        /// 工作年限
        /// </summary>
        [XmlElement("working_years")]
        public string WorkingYears { get; set; }
    }
}
