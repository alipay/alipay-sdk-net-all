using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateXuexinIdentityQueryResponse.
    /// </summary>
    public class AlipayCommerceEducateXuexinIdentityQueryResponse : AopResponse
    {
        /// <summary>
        /// 0表示非学生,1表示学生
        /// </summary>
        [XmlElement("college_online_tag")]
        public string CollegeOnlineTag { get; set; }

        /// <summary>
        /// 预计毕业时间 yyyyMM
        /// </summary>
        [XmlElement("graduate_time")]
        public string GraduateTime { get; set; }

        /// <summary>
        /// 学信网返回不是学生原因，仅6要素校验提供。 "LEVEL_NO_MATCH", "教育层次校验失败" "SCHOOL_NO_MATCH", "学校校验失败" "ENROLL_DATE_NO_MATCH", "入学日期校验失败" "DEGREE_NO_MATCH", "学历校验失败" "IDENTITY_CARD_NO_MATCH", "证件类型不是身份证"
        /// </summary>
        [XmlElement("reason_code")]
        public string ReasonCode { get; set; }
    }
}
