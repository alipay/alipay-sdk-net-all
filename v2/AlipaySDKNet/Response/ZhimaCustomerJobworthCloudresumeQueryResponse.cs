using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerJobworthCloudresumeQueryResponse.
    /// </summary>
    public class ZhimaCustomerJobworthCloudresumeQueryResponse : AopResponse
    {
        /// <summary>
        /// 出生日期
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 证书名称
        /// </summary>
        [XmlArray("certificates")]
        [XmlArrayItem("cloud_resume_certificate_info")]
        public List<CloudResumeCertificateInfo> Certificates { get; set; }

        /// <summary>
        /// 教育经历
        /// </summary>
        [XmlArray("education_experiences")]
        [XmlArrayItem("cloud_resume_education_experience")]
        public List<CloudResumeEducationExperience> EducationExperiences { get; set; }

        /// <summary>
        /// 用户在芝麻工作证填写的邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 用户的求职状态
        /// </summary>
        [XmlElement("intention_status")]
        public string IntentionStatus { get; set; }

        /// <summary>
        /// 用户在芝麻工作证填写的自我介绍
        /// </summary>
        [XmlElement("person_desc")]
        public string PersonDesc { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 智能简历头像
        /// </summary>
        [XmlElement("pic_url")]
        public CloudResumeHeadPic PicUrl { get; set; }

        /// <summary>
        /// 求职期望
        /// </summary>
        [XmlArray("position_intentions")]
        [XmlArrayItem("cloud_resume_position_intention")]
        public List<CloudResumePositionIntention> PositionIntentions { get; set; }

        /// <summary>
        /// 职业身份
        /// </summary>
        [XmlElement("position_type")]
        public string PositionType { get; set; }

        /// <summary>
        /// 常驻地址
        /// </summary>
        [XmlElement("residential_area")]
        public string ResidentialArea { get; set; }

        /// <summary>
        /// 技能信息
        /// </summary>
        [XmlArray("skills")]
        [XmlArrayItem("cloud_resume_skill_info")]
        public List<CloudResumeSkillInfo> Skills { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 工作经历
        /// </summary>
        [XmlArray("work_experiences")]
        [XmlArrayItem("cloud_resume_work_experience")]
        public List<CloudResumeWorkExperience> WorkExperiences { get; set; }

        /// <summary>
        /// 工作开始日期（时间戳）
        /// </summary>
        [XmlElement("work_start_date")]
        public long WorkStartDate { get; set; }
    }
}
