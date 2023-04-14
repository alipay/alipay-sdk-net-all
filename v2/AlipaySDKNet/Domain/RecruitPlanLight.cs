using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecruitPlanLight Data Structure.
    /// </summary>
    [Serializable]
    public class RecruitPlanLight : AopObject
    {
        /// <summary>
        /// 招商方案描述：富文本内容，可能包含html标签
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 报名结束时间
        /// </summary>
        [XmlElement("enroll_end_time")]
        public string EnrollEndTime { get; set; }

        /// <summary>
        /// 招商方案所属报名场景 枚举值： VOUCHER：券报名场景； MINI_APP：小程序报名场景；
        /// </summary>
        [XmlElement("enroll_scene_type")]
        public string EnrollSceneType { get; set; }

        /// <summary>
        /// 报名开始时间
        /// </summary>
        [XmlElement("enroll_start_time")]
        public string EnrollStartTime { get; set; }

        /// <summary>
        /// 方案头图链接，150x150 以上尺寸的方形图片
        /// </summary>
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 招商方案ID
        /// </summary>
        [XmlElement("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 招商方案名称
        /// </summary>
        [XmlElement("plan_name")]
        public string PlanName { get; set; }

        /// <summary>
        /// 方案状态: 可用:ENABLED
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
