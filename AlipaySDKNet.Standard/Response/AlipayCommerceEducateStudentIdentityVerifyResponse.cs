using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateStudentIdentityVerifyResponse.
    /// </summary>
    public class AlipayCommerceEducateStudentIdentityVerifyResponse : AopResponse
    {
        /// <summary>
        /// 签名
        /// </summary>
        [XmlElement("biz_sign")]
        public string BizSign { get; set; }

        /// <summary>
        /// 是否是学生，1是；0否
        /// </summary>
        [XmlElement("college_online_tag")]
        public string CollegeOnlineTag { get; set; }

        /// <summary>
        /// 学历，枚举类型：专科0，本科1，研究生2，博士3，本硕连读4，硕博连读5，本硕博连读6
        /// </summary>
        [XmlElement("degree")]
        public string Degree { get; set; }

        /// <summary>
        /// 入学时间，格式yyyy-mm-dd
        /// </summary>
        [XmlElement("enroll_date")]
        public string EnrollDate { get; set; }

        /// <summary>
        /// 审核状态，0-审核中，2-审核不通过，3-审核通过，5-无数据
        /// </summary>
        [XmlElement("examine_status")]
        public string ExamineStatus { get; set; }

        /// <summary>
        /// 会员状态，1 校园会员；0 新用户
        /// </summary>
        [XmlElement("member_ship_status")]
        public string MemberShipStatus { get; set; }

        /// <summary>
        /// 学校内标
        /// </summary>
        [XmlElement("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [XmlElement("time_stamp")]
        public string TimeStamp { get; set; }

        /// <summary>
        /// 身份类型，1-学生；2-教师；3-校友；4-考生；5-家长
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
