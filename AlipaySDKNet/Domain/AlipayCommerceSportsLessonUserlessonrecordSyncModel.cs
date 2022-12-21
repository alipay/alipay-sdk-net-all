using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsLessonUserlessonrecordSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsLessonUserlessonrecordSyncModel : AopObject
    {
        /// <summary>
        /// 数据来源
        /// </summary>
        [XmlElement("data_source")]
        public string DataSource { get; set; }

        /// <summary>
        /// 课程的外部存储id
        /// </summary>
        [XmlElement("lesson_out_id")]
        public string LessonOutId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 跟练记录外部存储id
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }

        /// <summary>
        /// 记录发生时间
        /// </summary>
        [XmlElement("record_time")]
        public string RecordTime { get; set; }

        /// <summary>
        /// 学习课程消耗卡路里，单位是卡
        /// </summary>
        [XmlElement("study_calorie")]
        public long StudyCalorie { get; set; }

        /// <summary>
        /// 实际学习时长，单位是秒
        /// </summary>
        [XmlElement("study_duration")]
        public long StudyDuration { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
