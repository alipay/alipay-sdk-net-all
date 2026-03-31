using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ArticleVo Data Structure.
    /// </summary>
    [Serializable]
    public class ArticleVo : AopObject
    {
        /// <summary>
        /// 科普文字内容
        /// </summary>
        [XmlElement("article_content")]
        public string ArticleContent { get; set; }

        /// <summary>
        /// 科普ID
        /// </summary>
        [XmlElement("article_id")]
        public string ArticleId { get; set; }

        /// <summary>
        /// 科普主题
        /// </summary>
        [XmlElement("article_title")]
        public string ArticleTitle { get; set; }

        /// <summary>
        /// 科普类型
        /// </summary>
        [XmlElement("article_type")]
        public string ArticleType { get; set; }

        /// <summary>
        /// 医生头像
        /// </summary>
        [XmlElement("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 医生ID
        /// </summary>
        [XmlElement("doctor_id")]
        public string DoctorId { get; set; }

        /// <summary>
        /// 医生名称
        /// </summary>
        [XmlElement("doctor_name")]
        public string DoctorName { get; set; }

        /// <summary>
        /// 视频时长，单位：秒
        /// </summary>
        [XmlElement("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 医院名称
        /// </summary>
        [XmlElement("hospital_name")]
        public string HospitalName { get; set; }

        /// <summary>
        /// 是否三甲
        /// </summary>
        [XmlElement("third_class")]
        public bool ThirdClass { get; set; }

        /// <summary>
        /// 医生职称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
