using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtHrcampuscoreEntrySyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtHrcampuscoreEntrySyncModel : AopObject
    {
        /// <summary>
        /// 校招签约三方名称（校招传）
        /// </summary>
        [XmlElement("agreement_name")]
        public string AgreementName { get; set; }

        /// <summary>
        /// 三方协议状态（校招传）
        /// </summary>
        [XmlElement("agreement_status")]
        public string AgreementStatus { get; set; }

        /// <summary>
        /// 是否需要添加预入职申请单
        /// </summary>
        [XmlElement("apply_status")]
        public bool ApplyStatus { get; set; }

        /// <summary>
        /// 校招必填
        /// </summary>
        [XmlElement("approval_id")]
        public string ApprovalId { get; set; }

        /// <summary>
        /// 校招批次英文名称
        /// </summary>
        [XmlElement("batch_en_name")]
        public string BatchEnName { get; set; }

        /// <summary>
        /// 入职薪资批次
        /// </summary>
        [XmlElement("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 校招批次中文名称
        /// </summary>
        [XmlElement("batch_name")]
        public string BatchName { get; set; }

        /// <summary>
        /// 校招批次类型
        /// </summary>
        [XmlElement("batch_type")]
        public string BatchType { get; set; }

        /// <summary>
        /// 上年度实际奖金
        /// </summary>
        [XmlElement("bonus_all_year_last")]
        public string BonusAllYearLast { get; set; }

        /// <summary>
        /// 年度目标奖金
        /// </summary>
        [XmlElement("bonus_of_year_last")]
        public string BonusOfYearLast { get; set; }

        /// <summary>
        /// 校招阶段
        /// </summary>
        [XmlElement("campus_phase_status")]
        public string CampusPhaseStatus { get; set; }

        /// <summary>
        /// 901入职单必填(工号)
        /// </summary>
        [XmlElement("candidate_work_no")]
        public string CandidateWorkNo { get; set; }

        /// <summary>
        /// 目前月资
        /// </summary>
        [XmlElement("current_salary_month")]
        public string CurrentSalaryMonth { get; set; }

        /// <summary>
        /// 其他薪资
        /// </summary>
        [XmlElement("current_salary_other")]
        public string CurrentSalaryOther { get; set; }

        /// <summary>
        /// 目前年薪
        /// </summary>
        [XmlElement("current_salary_year")]
        public string CurrentSalaryYear { get; set; }

        /// <summary>
        /// 入职部门
        /// </summary>
        [XmlElement("dept_no")]
        public string DeptNo { get; set; }

        /// <summary>
        /// 直接主管工号
        /// </summary>
        [XmlElement("direct_manager")]
        public string DirectManager { get; set; }

        /// <summary>
        /// 员工类型
        /// </summary>
        [XmlElement("employee_type")]
        public string EmployeeType { get; set; }

        /// <summary>
        /// 发放月数
        /// </summary>
        [XmlElement("give_out_month")]
        public string GiveOutMonth { get; set; }

        /// <summary>
        /// 毕业时间
        /// </summary>
        [XmlElement("graduation_time")]
        public string GraduationTime { get; set; }

        /// <summary>
        /// 是否有三方协议(针对校招)
        /// </summary>
        [XmlElement("has_agreement")]
        public string HasAgreement { get; set; }

        /// <summary>
        /// 候选人最高学历： 初中 高中 职高 中专 大学专科 大学本科 硕士研究生 博士研究生 未知 博士后 初中以下
        /// </summary>
        [XmlElement("hight_degree")]
        public string HightDegree { get; set; }

        /// <summary>
        /// 传渠道名称，入职系统没有该值，会自动保存到数据库
        /// </summary>
        [XmlElement("hire_channel")]
        public string HireChannel { get; set; }

        /// <summary>
        /// 招聘类型： 社招：1 校招：2
        /// </summary>
        [XmlElement("hire_channel_type")]
        public long HireChannelType { get; set; }

        /// <summary>
        /// 招聘来源地：郑州、杭州、长沙
        /// </summary>
        [XmlElement("hire_from_place")]
        public string HireFromPlace { get; set; }

        /// <summary>
        /// 招聘工作年限
        /// </summary>
        [XmlElement("hire_work_year")]
        public string HireWorkYear { get; set; }

        /// <summary>
        /// 期望薪资
        /// </summary>
        [XmlElement("hope_salary")]
        public string HopeSalary { get; set; }

        /// <summary>
        /// hrg域账号
        /// </summary>
        [XmlElement("hrg_work_no")]
        public string HrgWorkNo { get; set; }

        /// <summary>
        /// 居民身份证号
        /// </summary>
        [XmlElement("id_card")]
        public string IdCard { get; set; }

        /// <summary>
        /// 证件类型 默认：18位身份证
        /// </summary>
        [XmlElement("id_card_type")]
        public string IdCardType { get; set; }

        /// <summary>
        /// 面试确定的扩展层级（S1、S2、S3、S4、S5、S6、S7、S8、S9）
        /// </summary>
        [XmlElement("init_ext_level_code")]
        public string InitExtLevelCode { get; set; }

        /// <summary>
        /// 实习生定级
        /// </summary>
        [XmlElement("intern_grading")]
        public string InternGrading { get; set; }

        /// <summary>
        /// 面试评价信息
        /// </summary>
        [XmlElement("interview_info")]
        public string InterviewInfo { get; set; }

        /// <summary>
        /// 面试履历id
        /// </summary>
        [XmlElement("interview_resume_id")]
        public string InterviewResumeId { get; set; }

        /// <summary>
        /// 是否已婚
        /// </summary>
        [XmlElement("is_married")]
        public string IsMarried { get; set; }

        /// <summary>
        /// 是否901入职单
        /// </summary>
        [XmlElement("is_nine_zero_one")]
        public string IsNineZeroOne { get; set; }

        /// <summary>
        /// 是否海外招聘
        /// </summary>
        [XmlElement("is_oversea")]
        public string IsOversea { get; set; }

        /// <summary>
        /// 候选人是否实习生：true||false
        /// </summary>
        [XmlElement("is_practice")]
        public bool IsPractice { get; set; }

        /// <summary>
        /// 是否有股权
        /// </summary>
        [XmlElement("is_rsu_last")]
        public string IsRsuLast { get; set; }

        /// <summary>
        /// 社招应聘id
        /// </summary>
        [XmlElement("job_application_id")]
        public string JobApplicationId { get; set; }

        /// <summary>
        /// 上家公司名称
        /// </summary>
        [XmlElement("last_master")]
        public string LastMaster { get; set; }

        /// <summary>
        /// 层级（SZML-S1、SZML-S2、SZML-S3、SZML-S4、SZML-S5、SZML-S6、SZML-S7、SZML-S8、SZML-S9）
        /// </summary>
        [XmlElement("level_code")]
        public string LevelCode { get; set; }

        /// <summary>
        /// 层级细分(+、-、=)
        /// </summary>
        [XmlElement("level_code_ext")]
        public string LevelCodeExt { get; set; }

        /// <summary>
        /// 候选人邮箱
        /// </summary>
        [XmlElement("mail")]
        public string Mail { get; set; }

        /// <summary>
        /// 候选人手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 候选人电话区号
        /// </summary>
        [XmlElement("mobile_zone")]
        public string MobileZone { get; set; }

        /// <summary>
        /// 候选人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [XmlElement("national")]
        public string National { get; set; }

        /// <summary>
        /// 津贴
        /// </summary>
        [XmlElement("out_subsidy_before")]
        public string OutSubsidyBefore { get; set; }

        /// <summary>
        /// 岗位名称
        /// </summary>
        [XmlElement("position_name")]
        public string PositionName { get; set; }

        /// <summary>
        /// 面试详情
        /// </summary>
        [XmlElement("resume")]
        public string Resume { get; set; }

        /// <summary>
        /// 股权说明
        /// </summary>
        [XmlElement("rsu_last_remark")]
        public string RsuLastRemark { get; set; }

        /// <summary>
        /// 薪资币种
        /// </summary>
        [XmlElement("salary_currency")]
        public string SalaryCurrency { get; set; }

        /// <summary>
        /// 同等职位工作年限
        /// </summary>
        [XmlElement("same_work_exp")]
        public string SameWorkExp { get; set; }

        /// <summary>
        /// 毕业学校
        /// </summary>
        [XmlElement("school")]
        public string School { get; set; }

        /// <summary>
        /// 学校所在地
        /// </summary>
        [XmlElement("school_position")]
        public string SchoolPosition { get; set; }

        /// <summary>
        /// 候选人性别:男、女、未知
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 专业
        /// </summary>
        [XmlElement("specialty")]
        public string Specialty { get; set; }

        /// <summary>
        /// 公司福利
        /// </summary>
        [XmlElement("walfare_last")]
        public string WalfareLast { get; set; }

        /// <summary>
        /// 特色福利
        /// </summary>
        [XmlElement("walfare_text_last")]
        public string WalfareTextLast { get; set; }

        /// <summary>
        /// 工作年限
        /// </summary>
        [XmlElement("work_experience")]
        public string WorkExperience { get; set; }

        /// <summary>
        /// 工作地编号（6956 河南-郑州-郑州文化产业大厦 4234 浙江-杭州-飞天园区 7394 湖南-长沙-长沙市麓谷信息港）
        /// </summary>
        [XmlElement("work_place")]
        public string WorkPlace { get; set; }
    }
}
