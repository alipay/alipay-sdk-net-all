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
        /// 学生的生日信息，格式为yyyyMMdd
        /// </summary>
        [XmlElement("birth_date")]
        public string BirthDate { get; set; }

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
        /// 学生信息中的身份地址信息，用于ECHECK收款方式
        /// </summary>
        [XmlElement("identity_address")]
        public IndrISVAddressDTO IdentityAddress { get; set; }

        /// <summary>
        /// 学生身份证号
        /// </summary>
        [XmlElement("identity_card_number")]
        public string IdentityCardNumber { get; set; }

        /// <summary>
        /// 学生的证件类型
        /// </summary>
        [XmlElement("identity_type")]
        public string IdentityType { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        [XmlElement("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 学制信息，可根据枚举值传入，学年制
        /// </summary>
        [XmlElement("length_of_schooling")]
        public string LengthOfSchooling { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        [XmlElement("student_name")]
        public string StudentName { get; set; }

        /// <summary>
        /// 学号
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
