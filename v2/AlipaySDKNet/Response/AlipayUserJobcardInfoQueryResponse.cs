using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserJobcardInfoQueryResponse.
    /// </summary>
    public class AlipayUserJobcardInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 意向行政区域
        /// </summary>
        [XmlElement("admin_area")]
        public string AdminArea { get; set; }

        /// <summary>
        /// 性别;f：女；m：男
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 意向岗位，json数组
        /// </summary>
        [XmlElement("intent_post_tag")]
        public string IntentPostTag { get; set; }

        /// <summary>
        /// 用户意向工作地点类型
        /// </summary>
        [XmlElement("job_site_type")]
        public string JobSiteType { get; set; }

        /// <summary>
        /// 用户意向工作时间类型
        /// </summary>
        [XmlElement("job_time_type")]
        public string JobTimeType { get; set; }

        /// <summary>
        /// 就近距离，单位千米
        /// </summary>
        [XmlElement("local_range")]
        public long LocalRange { get; set; }

        /// <summary>
        /// 用户技能tag，json字符串
        /// </summary>
        [XmlElement("skill_tag")]
        public string SkillTag { get; set; }

        /// <summary>
        /// 适工年龄状态
        /// </summary>
        [XmlElement("suitable_age_status")]
        public string SuitableAgeStatus { get; set; }

        /// <summary>
        /// 用户年龄
        /// </summary>
        [XmlElement("user_age")]
        public long UserAge { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("user_phone")]
        public string UserPhone { get; set; }
    }
}
