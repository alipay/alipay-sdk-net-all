using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TuitionISVStudentInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TuitionISVStudentInfoDTO : AopObject
    {
        /// <summary>
        /// 电子邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 入学时间
        /// </summary>
        [XmlElement("entrance_date")]
        public string EntranceDate { get; set; }

        /// <summary>
        /// 姓
        /// </summary>
        [XmlElement("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 学生身份证号
        /// </summary>
        [XmlElement("identity_card_number")]
        public string IdentityCardNumber { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        [XmlElement("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        [XmlElement("student_name")]
        public string StudentName { get; set; }

        /// <summary>
        /// 20100120
        /// </summary>
        [XmlElement("student_number")]
        public string StudentNumber { get; set; }

        /// <summary>
        /// 学生手机号
        /// </summary>
        [XmlElement("student_phone_number")]
        public string StudentPhoneNumber { get; set; }
    }
}
