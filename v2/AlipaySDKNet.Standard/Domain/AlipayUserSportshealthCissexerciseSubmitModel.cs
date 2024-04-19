using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserSportshealthCissexerciseSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserSportshealthCissexerciseSubmitModel : AopObject
    {
        /// <summary>
        /// 进行自测时填写的年龄
        /// </summary>
        [XmlElement("age")]
        public long Age { get; set; }

        /// <summary>
        /// 年龄组
        /// </summary>
        [XmlElement("age_group")]
        public string AgeGroup { get; set; }

        /// <summary>
        /// 自测日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 自测数据记录
        /// </summary>
        [XmlArray("exercise_data")]
        [XmlArrayItem("ciss_exercise_report_record")]
        public List<CissExerciseReportRecord> ExerciseData { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        [XmlElement("identification_number")]
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// openid
        /// </summary>
        [XmlElement("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// 性别 1:男 2:女
        /// </summary>
        [XmlElement("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 运动指导
        /// </summary>
        [XmlArray("sports_guidance")]
        [XmlArrayItem("ciss_sports_guidance")]
        public List<CissSportsGuidance> SportsGuidance { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
