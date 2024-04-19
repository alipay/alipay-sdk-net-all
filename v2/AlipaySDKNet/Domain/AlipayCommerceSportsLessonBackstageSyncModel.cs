using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceSportsLessonBackstageSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceSportsLessonBackstageSyncModel : AopObject
    {
        /// <summary>
        /// 投放结束时间
        /// </summary>
        [XmlElement("deliver_end_time")]
        public string DeliverEndTime { get; set; }

        /// <summary>
        /// 投放开始时间
        /// </summary>
        [XmlElement("deliver_start_time")]
        public string DeliverStartTime { get; set; }

        /// <summary>
        /// 卡路里
        /// </summary>
        [XmlElement("lesson_calorie")]
        public long LessonCalorie { get; set; }

        /// <summary>
        /// 收费类型
        /// </summary>
        [XmlElement("lesson_charge_type")]
        public string LessonChargeType { get; set; }

        /// <summary>
        /// 课程时长
        /// </summary>
        [XmlElement("lesson_duration")]
        public long LessonDuration { get; set; }

        /// <summary>
        /// 课程器械
        /// </summary>
        [XmlArray("lesson_ext_tag")]
        [XmlArrayItem("string")]
        public List<string> LessonExtTag { get; set; }

        /// <summary>
        /// 课程图片(URL),来自于三方上传至阿里云oss的URL
        /// </summary>
        [XmlElement("lesson_image")]
        public string LessonImage { get; set; }

        /// <summary>
        /// 课程介绍
        /// </summary>
        [XmlElement("lesson_intro")]
        public string LessonIntro { get; set; }

        /// <summary>
        /// 长图(URL)，来自于三方上传至阿里云oss后的图片url
        /// </summary>
        [XmlElement("lesson_intro_image")]
        public string LessonIntroImage { get; set; }

        /// <summary>
        /// 限免结束时间
        /// </summary>
        [XmlElement("lesson_limit_free_end_time")]
        public string LessonLimitFreeEndTime { get; set; }

        /// <summary>
        /// 限免开始时间
        /// </summary>
        [XmlElement("lesson_limit_free_start_time")]
        public string LessonLimitFreeStartTime { get; set; }

        /// <summary>
        /// 课程名
        /// </summary>
        [XmlElement("lesson_name")]
        public string LessonName { get; set; }

        /// <summary>
        /// 外部课程id
        /// </summary>
        [XmlElement("lesson_out_id")]
        public string LessonOutId { get; set; }

        /// <summary>
        /// 课程来源
        /// </summary>
        [XmlElement("lesson_source")]
        public string LessonSource { get; set; }

        /// <summary>
        /// 课程标签
        /// </summary>
        [XmlArray("lesson_tag")]
        [XmlArrayItem("string")]
        public List<string> LessonTag { get; set; }

        /// <summary>
        /// 课程类型
        /// </summary>
        [XmlElement("lesson_type")]
        public string LessonType { get; set; }

        /// <summary>
        /// 课程链接
        /// </summary>
        [XmlElement("lesson_url")]
        public string LessonUrl { get; set; }

        /// <summary>
        /// 版本号
        /// </summary>
        [XmlElement("version_no")]
        public long VersionNo { get; set; }
    }
}
