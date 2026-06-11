using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenapiInterviewUserInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class OpenapiInterviewUserInfoDTO : AopObject
    {
        /// <summary>
        /// 候选人教育经历文字描述，限制150字之内
        /// </summary>
        [XmlElement("user_education_info")]
        public string UserEducationInfo { get; set; }

        /// <summary>
        /// 候选人邮箱地址
        /// </summary>
        [XmlElement("user_email")]
        public string UserEmail { get; set; }

        /// <summary>
        /// 候选人手机号
        /// </summary>
        [XmlElement("user_mobile")]
        public string UserMobile { get; set; }

        /// <summary>
        /// 候选人姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 候选人工作经历文字描述，限制150字之内
        /// </summary>
        [XmlElement("user_project_experience")]
        public string UserProjectExperience { get; set; }

        /// <summary>
        /// 用户简历地址
        /// </summary>
        [XmlElement("user_resume_url")]
        public string UserResumeUrl { get; set; }
    }
}
