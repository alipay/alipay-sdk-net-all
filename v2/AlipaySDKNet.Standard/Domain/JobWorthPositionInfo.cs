using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// JobWorthPositionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class JobWorthPositionInfo : AopObject
    {
        /// <summary>
        /// 职位要求-年龄要求 无要求（不传）、28岁以上(OVER28)、40岁以下(BELOW40)、25岁～35岁(25TO35)
        /// </summary>
        [XmlElement("age")]
        public string Age { get; set; }

        /// <summary>
        /// 福利，现有标签，最多5个标签，使用英文,分割 参考 https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入----职位传入接口》的1.3.1.1
        /// </summary>
        [XmlElement("benefit")]
        public string Benefit { get; set; }

        /// <summary>
        /// 技能、证书等要求，比如学历、健康证、普通话或其他技能证书等
        /// </summary>
        [XmlElement("certifications")]
        public string Certifications { get; set; }

        /// <summary>
        /// 发布企业统一社会信用代码
        /// </summary>
        [XmlElement("company_certificate")]
        public string CompanyCertificate { get; set; }

        /// <summary>
        /// 上传的aftsid
        /// </summary>
        [XmlElement("company_logo_afts_id")]
        public string CompanyLogoAftsId { get; set; }

        /// <summary>
        /// 企业工商全称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 招聘人数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 学历要求,HIGHSCHOOL_AND_BELOW（高中及以下），POLYTECHNIC（中专），COLLEGE（大专），BACHELOR（本科），MASTER（硕士），DOCTOR_AND_ABOVE（博士及以上）
        /// </summary>
        [XmlElement("education")]
        public string Education { get; set; }

        /// <summary>
        /// 无要求（不传）、男或者女
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 合作方岗位id自定义保持唯一性
        /// </summary>
        [XmlElement("ka_position_id")]
        public string KaPositionId { get; set; }

        /// <summary>
        /// 长文本描述
        /// </summary>
        [XmlElement("position_desc")]
        public string PositionDesc { get; set; }

        /// <summary>
        /// 工作证岗位库的职位主键，只有更新职位信息时需要传入。第一次传入岗位后返回
        /// </summary>
        [XmlElement("position_id")]
        public string PositionId { get; set; }

        /// <summary>
        /// 岗位对应的行业id，字段参考https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入----职位传入接口》的1.3.1.2
        /// </summary>
        [XmlElement("position_job_id")]
        public string PositionJobId { get; set; }

        /// <summary>
        /// 岗位对应的职业名称
        /// </summary>
        [XmlElement("position_job_name")]
        public string PositionJobName { get; set; }

        /// <summary>
        /// 岗位对应的职业id，字段参考https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入----职位传入接口》的1.3.1.2
        /// </summary>
        [XmlElement("position_profession_id")]
        public string PositionProfessionId { get; set; }

        /// <summary>
        /// 岗位属性：全职(FULL_TIME)或者兼职(PART_TIME)
        /// </summary>
        [XmlElement("position_property")]
        public string PositionProperty { get; set; }

        /// <summary>
        /// 职位的状态，只有上架(UNCHECK)和下架(OFFLINE)两种
        /// </summary>
        [XmlElement("position_status")]
        public string PositionStatus { get; set; }

        /// <summary>
        /// 短文本描述
        /// </summary>
        [XmlElement("position_title")]
        public string PositionTitle { get; set; }

        /// <summary>
        /// 薪水范围，不能低于salary_min
        /// </summary>
        [XmlElement("salary_max")]
        public string SalaryMax { get; set; }

        /// <summary>
        /// 薪水范围，不能高于salary_max
        /// </summary>
        [XmlElement("salary_min")]
        public string SalaryMin { get; set; }

        /// <summary>
        /// 薪资类型：日结(DAY)、月结(MONTH)、周结(WEEK)、完工结(DONE)、其他(OTHER)
        /// </summary>
        [XmlElement("salary_type")]
        public string SalaryType { get; set; }

        /// <summary>
        /// 薪资单位，元/日(DAY)、元/次(TIME)、元/月(MONTH)、元/小时(HOUR)、元/件 (NUM)、元/周 (WEEK)、其他 (OTHER)
        /// </summary>
        [XmlElement("salary_unit")]
        public string SalaryUnit { get; set; }

        /// <summary>
        /// 岗位需要的技能标签，最多5个，使用英文逗号分割
        /// </summary>
        [XmlElement("skill_tag")]
        public string SkillTag { get; set; }

        /// <summary>
        /// 职位跳转链接，当前只支持支付宝小程序，也就是alipays://platformapi/ 开头
        /// </summary>
        [XmlElement("skip_url")]
        public string SkipUrl { get; set; }

        /// <summary>
        /// 高德city code，例：北京010，线上工作9999 参考https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入----职位传入接口》的1.3.1.3
        /// </summary>
        [XmlElement("work_city")]
        public string WorkCity { get; set; }

        /// <summary>
        /// 经纬度，前面是经度，后面是纬度，使用英文逗号隔开
        /// </summary>
        [XmlElement("work_longitude")]
        public string WorkLongitude { get; set; }

        /// <summary>
        /// 工作地所在的区县,使用高德的adcode，例：朝阳区110105 参考https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入----职位传入接口》的1.3.1.2
        /// </summary>
        [XmlElement("work_region")]
        public string WorkRegion { get; set; }

        /// <summary>
        /// 工作年限，1年以下（ONE）、1～3年（THREE）、3～5年（FIVE）、5～10年（TEN）、10年以上（OVER_TEN）
        /// </summary>
        [XmlElement("work_year")]
        public string WorkYear { get; set; }
    }
}
