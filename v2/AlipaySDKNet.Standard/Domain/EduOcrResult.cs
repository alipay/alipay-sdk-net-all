using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EduOcrResult Data Structure.
    /// </summary>
    [Serializable]
    public class EduOcrResult : AopObject
    {
        /// <summary>
        /// 出生年月日
        /// </summary>
        [XmlElement("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 证书编号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 学历类别
        /// </summary>
        [XmlElement("edu_category")]
        public string EduCategory { get; set; }

        /// <summary>
        /// 教育层次
        /// </summary>
        [XmlElement("edu_level")]
        public string EduLevel { get; set; }

        /// <summary>
        /// 入学日期
        /// </summary>
        [XmlElement("enroll_date")]
        public string EnrollDate { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [XmlElement("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 毕（结）业状态
        /// </summary>
        [XmlElement("graduate_conclusion")]
        public string GraduateConclusion { get; set; }

        /// <summary>
        /// 毕（结）业日期
        /// </summary>
        [XmlElement("graduate_date")]
        public string GraduateDate { get; set; }

        /// <summary>
        /// 专业
        /// </summary>
        [XmlElement("major")]
        public string Major { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 学校
        /// </summary>
        [XmlElement("school")]
        public string School { get; set; }

        /// <summary>
        /// 学制，一般以“年”为单位
        /// </summary>
        [XmlElement("study_duration")]
        public string StudyDuration { get; set; }

        /// <summary>
        /// 培养方式
        /// </summary>
        [XmlElement("training_mode")]
        public string TrainingMode { get; set; }
    }
}
