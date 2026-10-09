using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCourseCheckincodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEducateCourseCheckincodeCreateModel : AopObject
    {
        /// <summary>
        /// 自动刷新二维码
        /// </summary>
        [XmlElement("automatic_refresh")]
        public bool AutomaticRefresh { get; set; }

        /// <summary>
        /// 课程id
        /// </summary>
        [XmlElement("course_id")]
        public string CourseId { get; set; }

        /// <summary>
        /// 课程签到规则ID，修改和删除的时候必填
        /// </summary>
        [XmlElement("course_rule_id")]
        public string CourseRuleId { get; set; }

        /// <summary>
        /// 课程签到规则名称
        /// </summary>
        [XmlElement("course_rule_name")]
        public string CourseRuleName { get; set; }

        /// <summary>
        /// 新增的时候必填
        /// </summary>
        [XmlElement("enable_course_rule")]
        public bool EnableCourseRule { get; set; }

        /// <summary>
        /// 结束签到
        /// </summary>
        [XmlElement("end_check_in")]
        public bool EndCheckIn { get; set; }

        /// <summary>
        /// 机构内标，取值来自学校内标
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 手动关闭标识
        /// </summary>
        [XmlElement("manual_close")]
        public bool ManualClose { get; set; }

        /// <summary>
        /// 刷新二维码频率（单位：秒）
        /// </summary>
        [XmlElement("refresh_qr_code_frequency")]
        public long RefreshQrCodeFrequency { get; set; }

        /// <summary>
        /// 花名册ID
        /// </summary>
        [XmlElement("roster_id")]
        public string RosterId { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [XmlElement("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// 状态，1代表有效，0代表删除
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
